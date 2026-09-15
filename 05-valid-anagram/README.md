# 05. Valid Anagram

LeetCode #242

Dificuldade: Fácil

Tópicos: Hash Table, String

Problema: https://leetcode.com/problems/valid-anagram/

## Abordagem

Conto a frequência de cada caractere da primeira string usando um `Dictionary`. Depois, consumo essas frequências com a segunda string. Se um caractere estiver ausente ou aparecer uma quantidade diferente de vezes, as strings não são anagramas.

## Complexidade

Tempo: O(n)

Espaço: O(n)

## Executando localmente

```bash
dotnet run
```

Os casos de teste utilizados localmente estão em `Program.cs`.
