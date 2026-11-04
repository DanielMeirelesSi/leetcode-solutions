# 17. Combination Sum

LeetCode #39

Dificuldade: Médio

Tópicos: Array, Backtracking

Problema: https://leetcode.com/problems/combination-sum/

## Descrição

Encontre todas as combinações de candidatos positivos distintos cuja soma seja igual ao alvo. Cada candidato pode ser reutilizado.

## Abordagem

Ordeno uma cópia dos candidatos e construo as combinações com Backtracking. A chamada seguinte mantém o índice atual para permitir reutilização, mas nunca volta a índices anteriores, evitando permutações da mesma combinação. Quando o candidato supera o restante, interrompo o laço. Copio cada caminho completo para que o retorno não seja alterado pelo backtracking.

## Exemplo

```text
Entrada: candidates = [2,3,6,7], target = 7
Saída: [[2,2,3],[7]]
```

## Complexidade

Tempo: O(n log n + (d + 1) * n^d + S)

Espaço: O(n + d) auxiliar; O(S) para a saída

n é a quantidade de candidatos, d = floor(target / menor candidato) limita a profundidade e S é o total de elementos das combinações retornadas. O limite de tempo é conservador: a poda reduz a busca, mas enumerar todas as respostas pode exigir tempo exponencial. Os candidatos oficiais são distintos e maiores ou iguais a 2. A entrada original é preservada.

## Executando localmente

Dentro da pasta `17-combination-sum`:

```bash
dotnet run
```

Os casos de teste utilizados localmente estão em `Program.cs`. Cada caso imprime `PASS` ou `FAIL`; uma falha também define o código de saída como 1.
