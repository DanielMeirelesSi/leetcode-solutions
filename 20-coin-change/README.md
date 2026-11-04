# 20. Coin Change

LeetCode #322

Dificuldade: Médio

Tópicos: Array, Dynamic Programming

Problema: https://leetcode.com/problems/coin-change/

## Descrição

Retorne a menor quantidade de moedas necessária para formar um valor, com uso ilimitado de cada denominação. Retorne -1 quando não houver combinação possível.

## Abordagem

Uso Dynamic Programming bottom-up: dp[value] guarda a menor quantidade de moedas para formar value. Inicializo os estados como impossíveis, exceto dp[0] = 0, e tento cada moeda que cabe no valor atual. Assim considero combinações que uma escolha greedy poderia perder, como coins = [1,3,4] e amount = 6, cuja resposta é 2.

## Exemplo

```text
Entrada: coins = [1,2,5], amount = 11
Saída: 3
```

## Complexidade

Tempo: O(n * A)

Espaço: O(A)

n é a quantidade de denominações e A é amount. Para A = 0, a resposta é 0. Comparo a moeda com o valor antes de subtrair, permitindo denominações até int.MaxValue sem overflow. As moedas oficiais são positivas.

## Executando localmente

Dentro da pasta `20-coin-change`:

```bash
dotnet run
```

Os casos de teste utilizados localmente estão em `Program.cs`. Cada caso imprime `PASS` ou `FAIL`; uma falha também define o código de saída como 1.
