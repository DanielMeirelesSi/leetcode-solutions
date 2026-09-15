# 09. Climbing Stairs

LeetCode #70

Dificuldade: Fácil

Tópicos: Dynamic Programming

Problema: https://leetcode.com/problems/climbing-stairs/

## Abordagem

O número de formas de chegar a um degrau é a soma das formas de chegar aos dois degraus anteriores. Calculo essa sequência iterativamente e mantenho apenas os dois últimos valores, sem precisar de uma tabela completa.

## Complexidade

Tempo: O(n)

Espaço: O(1)

## Executando localmente

```bash
dotnet run
```

Os casos de teste utilizados localmente estão em `Program.cs`.
