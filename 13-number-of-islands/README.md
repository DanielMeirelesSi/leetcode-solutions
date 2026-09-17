# 13. Number of Islands

LeetCode #200

Dificuldade: Médio

Tópicos: Array, DFS, BFS, Matrix

Problema: https://leetcode.com/problems/number-of-islands/

## Abordagem

Percorro a matriz procurando células de terra ainda não visitadas. Ao encontrar uma, incremento a quantidade de ilhas e uso uma `Stack` para visitar todas as células conectadas horizontalmente ou verticalmente, marcando cada uma como visitada.

## Complexidade

Tempo: O(m * n)

Espaço: O(m * n) no pior caso devido à `Stack` utilizada na busca.

## Executando localmente

```bash
dotnet run
```

Os casos de teste utilizados localmente estão em `Program.cs`.
