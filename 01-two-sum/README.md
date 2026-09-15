# 01. Two Sum

LeetCode #1

Dificuldade: Fácil

Tópicos: Array, Hash Table

Problema: https://leetcode.com/problems/two-sum/

## Abordagem

Percorro o array uma vez e armazeno no `Dictionary` o índice de cada valor visitado. Para cada número, verifico se o complemento necessário para chegar ao alvo já foi encontrado. Assim, identifico os dois índices em tempo linear.

## Complexidade

Tempo: O(n)

Espaço: O(n)

## Executando localmente

```bash
dotnet run
```

Os casos de teste utilizados localmente estão em `Program.cs`.
