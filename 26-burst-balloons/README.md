# 26. Burst Balloons

LeetCode #312

Dificuldade: Difícil (Hard)

Tópicos: Array, Dynamic Programming, Interval DP

Problema: https://leetcode.com/problems/burst-balloons/

## Descrição

Estoure todos os balões para maximizar as moedas. Ao estourar um balão, multiplique seu valor pelos valores dos vizinhos que ainda existem. Fora do array, o vizinho tem valor 1.

## Abordagem

Uso Dynamic Programming por intervalos, escolhendo o último balão de cada intervalo a ser estourado. Escolher o primeiro não fixa seus futuros vizinhos; escolher o último mantém os dois limites conhecidos.

1. Copio os valores entre duas sentinelas de valor 1.
2. Defino `best[left, right]` como a maior pontuação ao remover os balões estritamente entre os limites, mantendo os limites presentes.
3. Processo intervalos por largura crescente. Para cada possível último balão `last`, somo os resultados dos dois subintervalos e `values[left] * values[last] * values[right]`.
4. Guardo o máximo e retorno o intervalo completo.

Quando `last` é removido, todos os outros balões do intervalo já desapareceram, portanto seus vizinhos são exatamente os limites. Os subintervalos são independentes enquanto `last` permanece presente; isso justifica a recorrência. A implementação é iterativa e preserva a entrada.

## Exemplo

```text
Entrada: nums = [3,1,5,8]
Saída: 167
```

## Complexidade

Tempo: O(n³)

Espaço: O(n²)

n é a quantidade de balões, no máximo 300. Os valores vão de 0 a 100. Cada remoção rende no máximo 1000000 moedas, e até 300 remoções cabem em int; zeros e valores repetidos são válidos.

## Executando localmente

Dentro da pasta `26-burst-balloons`:

```bash
dotnet run
```

Os casos de teste utilizados localmente estão em `Program.cs`. Cada caso imprime `PASS` ou `FAIL`; uma falha também define o código de saída como 1. As referências independentes ficam apenas em `Program.cs`, e os testes aleatórios usam seeds fixas para reprodução.

Incluo os dois exemplos oficiais, limites com 300 balões e comparação de 200 entradas pequenas com uma referência que tenta todas as ordens de remoção. Também verifico que a entrada permanece intacta.
