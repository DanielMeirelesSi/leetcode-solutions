# 28. Word Search II

LeetCode #212

Dificuldade: Difícil (Hard)

Tópicos: Array, String, Trie, Backtracking

Problema: https://leetcode.com/problems/word-search-ii/

## Descrição

Retorne as palavras do dicionário que podem ser formadas no tabuleiro por movimentos horizontais ou verticais. Uma célula não pode ser reutilizada dentro da mesma palavra.

## Abordagem

Construo uma Trie para compartilhar a busca dos prefixos e uso Backtracking para percorrer o tabuleiro.

1. Conto as letras disponíveis e descarto palavras que exigem mais células ou mais ocorrências de alguma letra que o tabuleiro oferece. Esse filtro é necessário, mas não suficiente: a adjacência ainda será verificada.
2. Insiro as palavras restantes na Trie. Cada nó terminal guarda a própria palavra.
3. Inicio uma busca em cada célula. Se não houver um filho correspondente na Trie, abandono esse caminho imediatamente.
4. Marco temporariamente a célula com `#`, exploro seus quatro vizinhos e restauro a letra antes de retornar. A marca impede reutilização no caminho atual.
5. Ao encontrar um terminal, adiciono a palavra e limpo esse terminal para evitar respostas duplicadas. Continuo buscando palavras maiores com o mesmo prefixo.
6. Quando um nó deixa de ter palavra e filhos, removo seu vínculo com o pai. Esse ramo não contém respostas pendentes e pode ser eliminado com segurança.

Todo caminho válido segue um prefixo da Trie, então a poda não descarta respostas possíveis. A restauração das células mantém os caminhos independentes e preserva o tabuleiro. A Trie é criada dentro de cada chamada, evitando estado residual entre execuções.

## Exemplo

```text
Entrada: board = [["o","a","a","n"],["e","t","a","e"],["i","h","k","r"],["i","f","l","v"]], words = ["oath","pea","eat","rain"]
Saída: ["eat","oath"]
```

## Complexidade

Tempo: O(S + R * C * 4 * 3^(L - 1)) como limite conservador

Espaço: O(S + L) auxiliar; O(K) referências para a saída

S é a soma dos comprimentos do dicionário, R e C são as dimensões do tabuleiro, L é o maior comprimento de palavra e K é a quantidade encontrada. Após o primeiro movimento há no máximo três escolhas, pois não posso voltar à célula anterior. A Trie e as podas reduzem a busca na prática, mas o pior caso continua exponencial em L. O alfabeto tem 26 letras; a contagem de letras custa O(S). Pelas restrições, R,C <= 12, o dicionário tem até 30000 palavras únicas e L <= 10, limitando a profundidade recursiva a 10 células.

## Executando localmente

Dentro da pasta `28-word-search-ii`:

```bash
dotnet run
```

Os casos de teste utilizados localmente estão em `Program.cs`. Cada caso imprime `PASS` ou `FAIL`; uma falha também define o código de saída como 1. As referências independentes ficam apenas em `Program.cs`, e os testes aleatórios usam seeds fixas para reprodução.

Incluo os exemplos oficiais, proibição de diagonal e reutilização, prefixos compartilhados, letras repetidas, palavra de comprimento 10 e tabuleiro/dicionário máximos. Um segundo caso máximo insere 30000 palavras de dez letras que passam pelo filtro de frequência, exercitando a construção da Trie: todas começam com `ab`, mas o tabuleiro não tem células `a` e `b` adjacentes, portanto a resposta é vazia. Em 200 casos pequenos, comparo com busca separada de cada palavra usando máscara de células visitadas; também verifico restauração do tabuleiro e chamadas repetidas.
