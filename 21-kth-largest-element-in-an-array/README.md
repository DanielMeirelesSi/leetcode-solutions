# 21. Kth Largest Element in an Array

LeetCode #215

Dificuldade: Médio

Tópicos: Array, Heap (Priority Queue)

Problema: https://leetcode.com/problems/kth-largest-element-in-an-array/

## Descrição

Retorne o k-ésimo maior elemento do array. Ocorrências repetidas contam como posições distintas na ordenação.

## Abordagem

Mantenho uma min-heap com os k maiores elementos vistos usando PriorityQueue. Quando a quantidade ultrapassa k, removo o menor. Ao final, o topo é o k-ésimo maior elemento. A abordagem preserva o array e tem limite de tempo previsível; Quickselect pode usar menos espaço e ser linear em média, mas exige outros cuidados para controlar o pior caso.

## Exemplo

```text
Entrada: nums = [3,2,1,5,6,4], k = 2
Saída: 5
```

## Complexidade

Tempo: O(n log(k + 1))

Espaço: O(k)

n é o tamanho do array. Escrevo log(k + 1) para incluir k = 1, caso linear. As restrições oficiais garantem 1 <= k <= n; array vazio ou k inválido não possuem resposta definida neste problema. PriorityQueue faz parte do .NET 8 e não exige dependência externa.

## Executando localmente

Dentro da pasta `21-kth-largest-element-in-an-array`:

```bash
dotnet run
```

Os casos de teste utilizados localmente estão em `Program.cs`. Cada caso imprime `PASS` ou `FAIL`; uma falha também define o código de saída como 1.
