# 16. Search in Rotated Sorted Array

LeetCode #33

Dificuldade: Médio

Tópicos: Array, Binary Search

Problema: https://leetcode.com/problems/search-in-rotated-sorted-array/

## Descrição

Retorne o índice de um alvo em um array crescente que pode ter sido rotacionado, ou -1 se ele estiver ausente. Os valores são distintos.

## Abordagem

Uso Binary Search. Em cada iteração, pelo menos uma das metades está ordenada. Comparo o alvo com os extremos dessa metade para decidir qual intervalo descartar. Assim, reduzo a busca pela metade mesmo sem conhecer o ponto de rotação.

## Exemplo

```text
Entrada: nums = [4,5,6,7,0,1,2], target = 0
Saída: 4
```

## Complexidade

Tempo: O(log n)

Espaço: O(1)

n é o tamanho do array. Valores duplicados não fazem parte das restrições oficiais; essa hipótese permite descartar metade do intervalo.

## Executando localmente

Dentro da pasta `16-search-in-rotated-sorted-array`:

```bash
dotnet run
```

Os casos de teste utilizados localmente estão em `Program.cs`. Cada caso imprime `PASS` ou `FAIL`; uma falha também define o código de saída como 1.
