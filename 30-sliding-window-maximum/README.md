# 30. Sliding Window Maximum

LeetCode #239

Dificuldade: Difícil (Hard)

Tópicos: Array, Sliding Window, Monotonic Queue, Deque

Problema: https://leetcode.com/problems/sliding-window-maximum/

## Descrição

Retorne o maior elemento de cada janela contígua de tamanho k, percorrendo o array da esquerda para a direita.

## Abordagem

Mantenho uma deque de índices cujos valores estão em ordem estritamente decrescente. Uso um buffer circular de tamanho k para evitar alocações por elemento e limitar o espaço auxiliar.

1. Removo da frente os índices que saíram da janela.
2. Removo do final os índices cujo valor é menor ou igual ao novo valor. O elemento novo é tão bom quanto eles e permanece válido por mais tempo.
3. Insiro o índice atual no final da deque.
4. Quando a primeira janela estiver completa, o índice da frente identifica o seu máximo.

Os índices continuam em ordem de chegada e todos pertencem à janela atual. Qualquer valor removido do final está dominado por um valor posterior, então nunca será necessário para uma janela futura. Cada índice entra uma vez e sai no máximo uma vez: os laços internos somam O(n) operações, mesmo em sequências monotônicas ou com duplicatas. O buffer usa índices com módulo k para reutilizar as posições.

## Exemplo

```text
Entrada: nums = [1,3,-1,-3,5,3,6,7], k = 3
Saída: [3,3,5,5,6,7]
```

## Complexidade

Tempo: O(n)

Espaço: O(k) auxiliar; O(n - k + 1) para a saída

n é o tamanho do array. As restrições garantem 1 <= k <= n <= 100000 e valores entre -10000 e 10000. A implementação trata k = 1 e k = n pelo mesmo algoritmo e preserva a entrada.

## Executando localmente

Dentro da pasta `30-sliding-window-maximum`:

```bash
dotnet run
```

Os casos de teste utilizados localmente estão em `Program.cs`. Cada caso imprime `PASS` ou `FAIL`; uma falha também define o código de saída como 1. As referências independentes ficam apenas em `Program.cs`, e os testes aleatórios usam seeds fixas para reprodução.

Incluo os exemplos oficiais, janela unitária e completa, valores negativos, máximos repetidos e expiração do maior. Os testes grandes usam 100000 elementos, janela de 50000 e reutilização do buffer circular. Comparo 500 entradas pequenas com uma referência que percorre cada janela.
