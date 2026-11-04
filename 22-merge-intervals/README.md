# 22. Merge Intervals

LeetCode #56

Dificuldade: Médio

Tópicos: Array, Sorting

Problema: https://leetcode.com/problems/merge-intervals/

## Descrição

Una os intervalos que se sobrepõem e retorne intervalos disjuntos cobrindo os mesmos pontos. Intervalos cujas extremidades se tocam também se sobrepõem.

## Abordagem

Ordeno os intervalos pelo início. Mantenho um intervalo atual e amplio seu final enquanto o próximo início não ultrapassa esse final. Quando há um espaço, adiciono o intervalo atual à resposta e começo outro. Uso novos arrays na resposta; a ordenação altera a ordem do array de entrada.

## Exemplo

```text
Entrada: intervals = [[1,3],[2,6],[8,10],[15,18]]
Saída: [[1,6],[8,10],[15,18]]
```

## Complexidade

Tempo: O(n log n)

Espaço: O(n), incluindo a lista de intervalos e o array retornado

n é a quantidade de intervalos. Duplicatas, intervalos contidos e intervalos de comprimento zero são cobertos pela mesma comparação. A entrada oficial contém pares válidos com início menor ou igual ao final.

## Executando localmente

Dentro da pasta `22-merge-intervals`:

```bash
dotnet run
```

Os casos de teste utilizados localmente estão em `Program.cs`. Cada caso imprime `PASS` ou `FAIL`; uma falha também define o código de saída como 1.
