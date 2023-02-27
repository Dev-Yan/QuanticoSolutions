## Desafio Buracos de Bitmap - C# 

Esse código implementa uma função chamada: <strong>BitmapHoles</strong>, que recebe um array de strings: <strong> strArr</strong>, 
representando uma matriz binária, ou seja, com elementos iguais a 0 ou 1. 
A função usa o algoritmo de busca em largura (BFS) para encontrar as regiões contíguas de zeros na matriz e retorna o número de buracos existentes.

O algoritmo percorre a matriz e verifica se é um 0 e se ainda não foi visitado. Se for verdadeira, o algoritmo inicia uma busca em 
largura a partir desse elemento para encontrar a região contígua de zeros e marca todos os elementos da região como visitados para não visitá-los novamente. 
O contador é incrementado para contar a região encontrada e o processo é repetido para todos os elementos não visitados da matriz.

A função privada BFS é responsável por fazer a busca em largura. 
Ela recebe a linha e a coluna do elemento atual, o array de strings e uma matriz visited para marcar quais elementos já foram visitados. 
A função inicia criando uma fila vazia e enfileirando o elemento atual, marca como visitado. 
Em seguida, ela entra em um loop enquanto a fila não estiver vazia e começa a verificar os elementos próximos ao elemento atual. 
Se um elemento próximo for um 0 e ainda não tiver sido visitado, ele é enfileirado e marcado como visitado. 
O loop continua até que não haja mais elementos na fila.

O método Main é apenas p testar a função BitmapHoles com um exemplo simples. 
