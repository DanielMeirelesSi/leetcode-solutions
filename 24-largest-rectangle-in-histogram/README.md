# 24. Largest Rectangle in Histogram

LeetCode #84

Dificuldade: Difícil

Tópicos: Array, Monotonic Stack

Problema: https://leetcode.com/problems/largest-rectangle-in-histogram/

## Descrição

Calcule a maior área de um retângulo formado por barras contíguas de um histograma. Cada barra tem largura 1 e altura não negativa.

## Abordagem

Mantenho uma Stack de índices com alturas crescentes. Ao encontrar uma altura menor ou igual à do topo, removo a barra e calculo sua área usando a posição atual e o novo topo como limites. Uma altura sentinela zero após o fim esvazia a pilha. Cada índice entra e sai no máximo uma vez, eliminando a necessidade de testar todos os pares de limites.

## Exemplo

```text
Entrada: heights = [2,1,5,6,2,3]
Saída: 10
```

## Complexidade

Tempo: O(n)

Espaço: O(n)

n é a quantidade de barras. Alturas iguais, zeros e sequências monotônicas são tratados pela comparação da pilha. A maior área oficial é 100000 * 10000 = 1000000000, dentro de int.

## Executando localmente

Dentro da pasta `24-largest-rectangle-in-histogram`:

```bash
dotnet run
```

Os casos de teste utilizados localmente estão em `Program.cs`. Cada caso imprime `PASS` ou `FAIL`; uma falha também define o código de saída como 1.
