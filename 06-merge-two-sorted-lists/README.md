# 06. Merge Two Sorted Lists

LeetCode #21

Dificuldade: Fácil

Tópicos: Linked List, Recursion

Problema: https://leetcode.com/problems/merge-two-sorted-lists/

## Abordagem

Uso um nó inicial temporário para construir a lista resultante. Comparo os nós atuais das duas listas e conecto o menor deles à resposta, avançando apenas nessa lista. No final, conecto o restante da lista que ainda não terminou.

## Complexidade

Tempo: O(n + m)

Espaço: O(1)

## Executando localmente

```bash
dotnet run
```

Os casos de teste utilizados localmente estão em `Program.cs`.
