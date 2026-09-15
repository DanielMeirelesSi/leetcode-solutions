# 04. Best Time to Buy and Sell Stock

LeetCode #121

Dificuldade: Fácil

Tópicos: Array

Problema: https://leetcode.com/problems/best-time-to-buy-and-sell-stock/

## Abordagem

Percorro os preços uma única vez, mantendo o menor preço encontrado até o momento. Para cada preço atual, calculo o lucro de vender nesse dia e atualizo o maior lucro encontrado.

## Complexidade

Tempo: O(n)

Espaço: O(1)

## Executando localmente

```bash
dotnet run
```

Os casos de teste utilizados localmente estão em `Program.cs`.
