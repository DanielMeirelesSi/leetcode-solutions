# 14. Linked List Cycle

LeetCode #141

Dificuldade: Fácil

Tópicos: Hash Table, Linked List, Two Pointers

Problema: https://leetcode.com/problems/linked-list-cycle/

## Abordagem

Utilizamos Fast and Slow Pointers para percorrer a lista em velocidades diferentes. O ponteiro `slow` avança um nó por vez, enquanto `fast` avança dois. Se existir um ciclo, os dois ponteiros eventualmente se encontram. Se `fast` ou `fast.next` alcançar o final da lista, não existe ciclo.

## Complexidade

Tempo: O(n)

Espaço: O(1)

## Executando localmente

```bash
dotnet run
```

Os casos de teste utilizados localmente estão em `Program.cs`.
