# 23. Minimum Window Substring

LeetCode #76

Dificuldade: Difícil

Tópicos: String, Hash Table, Sliding Window

Problema: https://leetcode.com/problems/minimum-window-substring/

## Descrição

Encontre a menor substring de s que contenha todos os caracteres de t, respeitando suas frequências. Se não houver janela válida, retorne uma string vazia.

## Abordagem

Conto os caracteres necessários e expando uma Sliding Window até cobrir todas as ocorrências de t. Enquanto a janela for válida, registro a menor e avanço a esquerda. Frequências negativas representam caracteres excedentes, por isso não basta testar presença em um conjunto. Cada ponteiro avança no máximo uma vez por posição.

## Exemplo

```text
Entrada: s = "ADOBECODEBANC", t = "ABC"
Saída: "BANC"
```

## Complexidade

Tempo: O(m + n)

Espaço: O(1) auxiliar; O(m) no pior caso para a string retornada

m e n são os comprimentos de s e t. Uso uma tabela de 128 posições para o alfabeto ASCII: as restrições oficiais permitem apenas letras inglesas maiúsculas e minúsculas. Uma string vazia produz resposta vazia. A cópia da substring só ocorre ao final.

## Executando localmente

Dentro da pasta `23-minimum-window-substring`:

```bash
dotnet run
```

Os casos de teste utilizados localmente estão em `Program.cs`. Cada caso imprime `PASS` ou `FAIL`; uma falha também define o código de saída como 1.
