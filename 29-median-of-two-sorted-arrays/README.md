# 29. Median of Two Sorted Arrays

LeetCode #4

Dificuldade: Difícil (Hard)

Tópicos: Array, Binary Search, Divide and Conquer

Problema: https://leetcode.com/problems/median-of-two-sorted-arrays/

## Descrição

Retorne a mediana dos elementos de dois arrays já ordenados em ordem não decrescente. Um deles pode estar vazio, mas a soma dos tamanhos é positiva. O algoritmo deve ser logarítmico.

## Abordagem

Faço Binary Search sobre a posição de uma partição no menor array, sem juntar os elementos.

1. Coloco o menor array na primeira referência local. A metade esquerda deverá conter `(m + n + 1) / 2` elementos.
2. Escolho quantos elementos do primeiro array ficam à esquerda; a quantidade do segundo é determinada pela soma desejada.
3. Leio os quatro valores ao redor dos cortes. Uso sentinelas para lados vazios, evitando acessos fora dos arrays.
4. A partição é válida quando o maior valor à esquerda de cada array não ultrapassa o menor valor à direita do outro. Se o primeiro corte deixou um valor grande demais à esquerda, movo a busca para a esquerda; caso contrário, para a direita.
5. Com total ímpar, retorno o maior valor à esquerda. Com total par, retorno a média entre o maior à esquerda e o menor à direita, convertendo para double antes da soma.

Os arrays já são ordenados internamente; as duas comparações entre arrays garantem que toda a metade esquerda vem antes de toda a direita. Como os tamanhos também estão equilibrados, os valores adjacentes ao corte são os elementos centrais. Buscar no menor array mantém o outro corte dentro dos limites.

## Exemplo

```text
Entrada: nums1 = [1,2], nums2 = [3,4]
Saída: 2.5
```

## Complexidade

Tempo: O(1 + log(min(m,n) + 1))

Espaço: O(1)

m e n são os tamanhos dos arrays. O termo constante contempla um array vazio, que exige apenas uma iteração. Os tamanhos individuais são no máximo 1000 e os valores pertencem a [-1000000,1000000]. A implementação preserva ambos os arrays; entradas desordenadas ou ambos vazios não pertencem ao contrato oficial.

## Executando localmente

Dentro da pasta `29-median-of-two-sorted-arrays`:

```bash
dotnet run
```

Os casos de teste utilizados localmente estão em `Program.cs`. Cada caso imprime `PASS` ou `FAIL`; uma falha também define o código de saída como 1. As referências independentes ficam apenas em `Program.cs`, e os testes aleatórios usam seeds fixas para reprodução.

Incluo os exemplos oficiais, arrays vazios individualmente, duplicatas, valores extremos, partições nas bordas, tamanhos desbalanceados e dois arrays de tamanho máximo. Comparo 500 pares aleatórios com concatenação e ordenação, verificando também a ordem invertida dos argumentos.
