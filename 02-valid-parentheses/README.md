# 02. Valid Parentheses

LeetCode #20

Dificuldade: Fácil

Tópicos: String, Stack

Problema: https://leetcode.com/problems/valid-parentheses/

## Abordagem

Uso uma `Stack` para armazenar os parênteses de abertura. Quando encontro um parêntese de fechamento, comparo-o com o caractere no topo da pilha. A string só é válida quando todos os pares são fechados na ordem correta e a pilha termina vazia.

## Complexidade

Tempo: O(n)

Espaço: O(n)

## Executando localmente

```bash
dotnet run
```

Os casos de teste utilizados localmente estão em `Program.cs`.
