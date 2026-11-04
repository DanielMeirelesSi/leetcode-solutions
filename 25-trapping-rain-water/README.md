# 25. Trapping Rain Water

LeetCode #42

Dificuldade: Difícil

Tópicos: Array, Two Pointers

Problema: https://leetcode.com/problems/trapping-rain-water/

## Descrição

Calcule o volume de água retido entre barras de alturas não negativas, todas com largura 1.

## Abordagem

Uso Two Pointers e mantenho a maior altura vista em cada extremidade. Processo o lado cuja barra atual é menor: já existe uma barreira do lado oposto suficiente para limitar a água desse lado. Somo a diferença entre o máximo daquele lado e a altura atual. Isso evita armazenar arrays de máximos para todas as posições.

## Exemplo

```text
Entrada: height = [0,1,0,2,1,0,1,3,2,1,2,1]
Saída: 6
```

## Complexidade

Tempo: O(n)

Espaço: O(1)

n é a quantidade de barras. Sequências monotônicas e alturas iguais não retêm água. O maior volume permitido é 19998 * 100000 = 1999800000, dentro de int.

## Executando localmente

Dentro da pasta `25-trapping-rain-water`:

```bash
dotnet run
```

Os casos de teste utilizados localmente estão em `Program.cs`. Cada caso imprime `PASS` ou `FAIL`; uma falha também define o código de saída como 1.
