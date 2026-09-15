# 03. Binary Search

LeetCode #704

Dificuldade: Fácil

Tópicos: Array, Binary Search

Problema: https://leetcode.com/problems/binary-search/

## Abordagem

Mantenho os limites da parte do array que ainda pode conter o alvo. A cada passo, comparo o elemento do meio com o alvo e descarto metade dos elementos restantes até encontrar o valor ou esvaziar o intervalo.

## Complexidade

Tempo: O(log n)

Espaço: O(1)

## Executando localmente

```bash
dotnet run
```

Os casos de teste utilizados localmente estão em `Program.cs`.
