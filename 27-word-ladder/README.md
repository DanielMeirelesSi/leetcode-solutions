# 27. Word Ladder

LeetCode #127

Dificuldade: Difícil (Hard)

Tópicos: String, Graph, BFS, Hash Table

Problema: https://leetcode.com/problems/word-ladder/

## Descrição

Encontre a quantidade de palavras na menor sequência entre beginWord e endWord. Cada transformação altera uma letra e deve gerar uma palavra do dicionário. Retorne 0 se não existir sequência.

## Abordagem

Modelo cada palavra como um vértice e cada alteração válida de uma letra como uma aresta de custo 1. Uso BFS sem construir todas as arestas explicitamente.

1. Armazeno o dicionário em um HashSet. Se o destino estiver ausente, não há solução.
2. Inicio a fila com a origem e comprimento 1, pois a resposta conta palavras, não arestas. Removo a origem do conjunto se estiver presente.
3. Para cada palavra do nível atual, substituo cada posição pelas outras letras de a a z.
4. Uma palavra encontrada no conjunto é removida imediatamente, evitando enfileiramento repetido. Se for o destino, retorno o comprimento do próximo nível; caso contrário, enfileiro a palavra.
5. Se a fila esvaziar, retorno 0.

A BFS visita os níveis por distância crescente. Assim, o primeiro encontro com o destino corresponde ao menor número de transformações. Gerar vizinhos sob demanda evita comparar todos os pares de palavras. Uma BFS bidirecional pode visitar menos vértices, mas a BFS simples já atende ao limite e mantém o controle dos níveis mais direto.

## Exemplo

```text
Entrada: beginWord = "hit", endWord = "cog", wordList = ["hot","dot","dog","lot","log","cog"]
Saída: 5
```

## Complexidade

Tempo: O(26 * N * L²), considerando hashing e construção de strings

Espaço: O(N * L)

N é a quantidade de palavras e L é seu comprimento. Para cada palavra visitada, gero até 26 * L candidatos de comprimento L. As operações de HashSet têm custo esperado de tabela hash; o fator L inclui processar os caracteres da string. As restrições garantem palavras únicas, letras minúsculas, comprimentos iguais, origem diferente do destino, N <= 5000 e L <= 10.

## Executando localmente

Dentro da pasta `27-word-ladder`:

```bash
dotnet run
```

Os casos de teste utilizados localmente estão em `Program.cs`. Cada caso imprime `PASS` ou `FAIL`; uma falha também define o código de saída como 1. As referências independentes ficam apenas em `Program.cs`, e os testes aleatórios usam seeds fixas para reprodução.

Incluo ambos os exemplos oficiais, destino desconectado, caminhos convergentes, uma cadeia com dez transformações e 5000 palavras de comprimento 10. Comparo 300 dicionários pequenos com Floyd-Warshall sobre um grafo construído por comparação de todos os pares.
