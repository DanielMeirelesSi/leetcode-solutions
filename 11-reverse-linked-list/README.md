# 11. Reverse Linked List

LeetCode #206

Dificuldade: Fácil

Tópicos: Linked List, Recursion

Problema: https://leetcode.com/problems/reverse-linked-list/

## Abordagem

Percorro a lista usando três referências: `previous`, `current` e `next`. Em cada passo, salvo o próximo nó, inverto o ponteiro de `current` e avanço as referências. Ao final, `previous` aponta para o novo início da lista.

## Complexidade

Tempo: O(n)

Espaço: O(1)

## Executando localmente

```bash
dotnet run
```

Os casos de teste utilizados localmente estão em `Program.cs`.
