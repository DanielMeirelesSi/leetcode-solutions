# 12. Maximum Subarray

LeetCode #53

Dificuldade: Médio

Tópicos: Array, Divide and Conquer, Dynamic Programming

Problema: https://leetcode.com/problems/maximum-subarray/

## Abordagem

Uso o algoritmo de Kadane. Para cada posição, decido se vale mais a pena começar uma nova subarray naquele valor ou continuar a soma atual. Também mantenho a maior soma encontrada globalmente.

## Complexidade

Tempo: O(n)

Espaço: O(1)

## Executando localmente

```bash
dotnet run
```

Os casos de teste utilizados localmente estão em `Program.cs`.
