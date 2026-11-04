# 19. Course Schedule

LeetCode #207

Dificuldade: Médio

Tópicos: Graph, Topological Sort, BFS

Problema: https://leetcode.com/problems/course-schedule/

## Descrição

Determine se todos os cursos podem ser concluídos, respeitando os pares [curso, pré-requisito]. Um ciclo de dependências torna a conclusão impossível.

## Abordagem

Construo um grafo do pré-requisito para o curso dependente e conto os graus de entrada. Uso o algoritmo de Kahn: começo pelos cursos sem dependências e libero os próximos ao remover cada aresta. Se a quantidade processada for menor que o total de cursos, existe um ciclo, inclusive em componentes desconectados. A fila evita recursão em cadeias longas.

## Exemplo

```text
Entrada: numCourses = 2, prerequisites = [[1,0]]
Saída: true
```

## Complexidade

Tempo: O(V + E)

Espaço: O(V + E)

V é a quantidade de cursos e E é a quantidade de pré-requisitos. Cursos isolados também entram na fila. Cada ocorrência de uma aresta é contada e removida uma vez, mesmo se a entrada local repetir um par.

## Executando localmente

Dentro da pasta `19-course-schedule`:

```bash
dotnet run
```

Os casos de teste utilizados localmente estão em `Program.cs`. Cada caso imprime `PASS` ou `FAIL`; uma falha também define o código de saída como 1.
