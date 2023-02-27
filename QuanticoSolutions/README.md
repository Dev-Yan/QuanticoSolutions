## Desafio Limpeza C# JSON:

Este trecho de código faz uma requisição para a URL https://coderbyte.com/api/challenges/json/json-cleaning, recebe a resposta da solicitação e, em seguida, 
lê o conteúdo da resposta em um objeto string usando um StreamReader. 
Em seguida, a string de resposta é analisada em um objeto JSON usando o método Parse() da classe JObject.

A função CleanJson() é chamada para limpar o objeto JSON. 
Essa função usa recursividade(uma função chama a si mesma repetidamente, geralmente com diferentes parâmetros, até que uma condição de parada seja atendida) 
para percorrer todas as propriedades do objeto JSON e remove as propriedades que possuem valor igual a "N/A", "-", ou são valores vazios ou nulos. 
Se a propriedade for um array, a função remove todos os elementos do array que possuem um valor igual a "N/A" ou "-". 
Se a propriedade for um objeto JSON, a função chama a si mesma para limpar o objeto JSON.

Por fim, o código imprime o objeto JSON limpo na saída padrão usando o método ToString() da classe JObject e fecha a resposta da solicitação.

Em resumo, esse código realiza a limpeza de um objeto JSON recebido de uma API, removendo propriedades e elementos de array que possuem valores indesejados :) 
