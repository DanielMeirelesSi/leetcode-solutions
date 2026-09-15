# 10. Longest Substring Without Repeating Characters

LeetCode #3

Dificuldade: Médio

Tópicos: String, Hash Table, Sliding Window

Problema: https://leetcode.com/problems/longest-substring-without-repeating-characters/

## Abordagem

Mantenho uma janela entre `left` e `right` sem caracteres repetidos. O `Dictionary` armazena a última posição de cada caractere; quando um caractere se repete dentro da janela, movo `left` para depois da ocorrência anterior.

## Complexidade

Tempo: O(n)

Espaço: O(n)

## Executando localmente

```bash
dotnet run
```

Os casos de teste utilizados localmente estão em `Program.cs`.
