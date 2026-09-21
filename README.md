# LeetCode Solutions

Este repositório reúne minhas soluções de problemas do LeetCode utilizando C#, visando praticar e desenvolver lógica de programação, algoritmos e estruturas de dados.

Cada exercício possui sua própria solução, documentação e casos de teste para execução local.

## Problemas

| # | LeetCode | Problema | Dificuldade | Tópicos | Solução |
|---|---:|---|---|---|---|
| 01 | 1 | [Two Sum](./01-two-sum/README.md) | Fácil | Array, Hash Table | [C#](./01-two-sum/Solution.cs) |
| 02 | 20 | [Valid Parentheses](./02-valid-parentheses/README.md) | Fácil | String, Stack | [C#](./02-valid-parentheses/Solution.cs) |
| 03 | 704 | [Binary Search](./03-binary-search/README.md) | Fácil | Array, Binary Search | [C#](./03-binary-search/Solution.cs) |
| 04 | 121 | [Best Time to Buy and Sell Stock](./04-best-time-to-buy-and-sell-stock/README.md) | Fácil | Array | [C#](./04-best-time-to-buy-and-sell-stock/Solution.cs) |
| 05 | 242 | [Valid Anagram](./05-valid-anagram/README.md) | Fácil | Hash Table, String | [C#](./05-valid-anagram/Solution.cs) |
| 06 | 21 | [Merge Two Sorted Lists](./06-merge-two-sorted-lists/README.md) | Fácil | Linked List, Recursion | [C#](./06-merge-two-sorted-lists/Solution.cs) |
| 07 | 104 | [Maximum Depth of Binary Tree](./07-maximum-depth-of-binary-tree/README.md) | Fácil | Tree, DFS, BFS | [C#](./07-maximum-depth-of-binary-tree/Solution.cs) |
| 08 | 283 | [Move Zeroes](./08-move-zeroes/README.md) | Fácil | Array, Two Pointers | [C#](./08-move-zeroes/Solution.cs) |
| 09 | 70 | [Climbing Stairs](./09-climbing-stairs/README.md) | Fácil | Dynamic Programming | [C#](./09-climbing-stairs/Solution.cs) |
| 10 | 3 | [Longest Substring Without Repeating Characters](./10-longest-substring-without-repeating-characters/README.md) | Médio | String, Hash Table, Sliding Window | [C#](./10-longest-substring-without-repeating-characters/Solution.cs) |
| 11 | 206 | [Reverse Linked List](./11-reverse-linked-list/README.md) | Fácil | Linked List, Recursion | [C#](./11-reverse-linked-list/Solution.cs) |
| 12 | 53 | [Maximum Subarray](./12-maximum-subarray/README.md) | Médio | Array, Divide and Conquer, Dynamic Programming | [C#](./12-maximum-subarray/Solution.cs) |
| 13 | 200 | [Number of Islands](./13-number-of-islands/README.md) | Médio | Array, DFS, BFS, Matrix | [C#](./13-number-of-islands/Solution.cs) |
| 14 | 141 | [Linked List Cycle](./14-linked-list-cycle/README.md) | Fácil | Hash Table, Linked List, Two Pointers | [C#](./14-linked-list-cycle/Solution.cs) |
| 15 | 238 | [Product of Array Except Self](./15-product-of-array-except-self/README.md) | Médio | Array, Prefix Sum | [C#](./15-product-of-array-except-self/Solution.cs) |

## Progresso

Resolvidos: 15

Fácil: 11  
Médio: 4  
Difícil: 0

## Executando localmente

Cada exercício possui um Console independente.

Para executar um exercício:

```bash
cd 01-two-sum
dotnet run
```

Para compilar todos os projetos:

```bash
dotnet build ./LeetCodeSolutions.sln -m:1
```

Para executar os testes locais de todos os exercícios de uma vez no PowerShell:

```powershell
.\run-all.ps1
```

`Solution.cs` contém a implementação da solução no formato utilizado pelo LeetCode.

`Program.cs` contém os casos de teste utilizados para executar e validar a solução que criei.
