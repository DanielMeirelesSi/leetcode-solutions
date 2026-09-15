# 08. Move Zeroes

LeetCode #283

Dificuldade: Fácil

Tópicos: Array, Two Pointers

Problema: https://leetcode.com/problems/move-zeroes/

## Abordagem

Uso um ponteiro para indicar a próxima posição que deve receber um valor diferente de zero. Primeiro, movo esses valores para o início do array e, depois, preencho as posições restantes com zeros. A alteração é feita in-place.

## Complexidade

Tempo: O(n)

Espaço: O(1)

## Executando localmente

```bash
dotnet run
```

Os casos de teste utilizados localmente estão em `Program.cs`.
