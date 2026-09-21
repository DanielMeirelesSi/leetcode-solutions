# 15. Product of Array Except Self

LeetCode #238

Dificuldade: Médio

Tópicos: Array, Prefix Sum

Problema: https://leetcode.com/problems/product-of-array-except-self/

## Abordagem

Primeiro armazenamos no resultado o produto dos elementos anteriores a cada posição. Depois percorremos o array de trás para frente, mantendo o produto dos elementos posteriores e multiplicando esse valor pelo prefixo já armazenado. Assim evitamos divisão e mantemos complexidade linear.

## Complexidade

Tempo: O(n)

Espaço auxiliar: O(1)

O array retornado não é considerado espaço auxiliar para essa análise, seguindo a convenção do problema.

## Executando localmente

```bash
dotnet run
```

Os casos de teste utilizados localmente estão em `Program.cs`.
