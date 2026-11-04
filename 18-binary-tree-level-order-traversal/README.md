# 18. Binary Tree Level Order Traversal

LeetCode #102

Dificuldade: Médio

Tópicos: Tree, BFS, Queue

Problema: https://leetcode.com/problems/binary-tree-level-order-traversal/

## Descrição

Retorne os valores de uma árvore binária separados por nível, da esquerda para a direita. Uma árvore vazia produz uma lista vazia.

## Abordagem

Uso BFS com uma Queue de nós. No início de cada nível, salvo o tamanho atual da fila e processo exatamente essa quantidade, adicionando os filhos da esquerda antes dos da direita. Isso separa corretamente os níveis e evita recursão em árvores profundas.

## Exemplo

```text
Entrada: root = [3,9,20,null,null,15,7]
Saída: [[3],[9,20],[15,7]]
```

## Complexidade

Tempo: O(n)

Espaço: O(w) auxiliar; O(n) para a saída

n é a quantidade de nós e w é a largura máxima da árvore. TreeNode.cs reproduz o tipo fornecido pelo LeetCode para execução local. Na plataforma, envio apenas Solution.cs.

## Executando localmente

Dentro da pasta `18-binary-tree-level-order-traversal`:

```bash
dotnet run
```

Os casos de teste utilizados localmente estão em `Program.cs`. Cada caso imprime `PASS` ou `FAIL`; uma falha também define o código de saída como 1.
