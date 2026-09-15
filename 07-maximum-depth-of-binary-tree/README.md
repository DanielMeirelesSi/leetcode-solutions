# 07. Maximum Depth of Binary Tree

LeetCode #104

Dificuldade: Fácil

Tópicos: Tree, DFS, BFS

Problema: https://leetcode.com/problems/maximum-depth-of-binary-tree/

## Abordagem

Uso DFS recursivo. A profundidade de uma árvore vazia é zero; para os demais nós, calculo a profundidade das duas subárvores e somo um ao maior resultado.

## Complexidade

Tempo: O(n)

Espaço: O(h), em que h é a altura da árvore devido à pilha de recursão.

## Executando localmente

```bash
dotnet run
```

Os casos de teste utilizados localmente estão em `Program.cs`.
