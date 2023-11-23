# Prática - 0003
## Motivação:
Este projeto proporciona uma oportunidade prática para os
discentes aplicarem e integrarem os conceitos de tuplas,
expressões lambda, LINQ e tratamento de exceções em um
contexto realista de gerenciamento de estoque, algo comum em
ambientes corporativos e industriais

## Objetivo:
Desenvolver um sistema de gerenciamento de estoque que utiliza conceitos de tuplas,
expressões lambda, LINQ e tratamento de exceções.

## Desenvolvimento:

- **Produto:**
  - Crie uma tupla representando um produto no estoque, contendo os
  seguintes elementos: código do produto, nome do produto, quantidade
  em estoque e preço unitário.

- **Cadastro de Produtos:**
  - Permita que o usuário cadastre novos produtos no estoque, informando
  código, nome, quantidade e preço.
  - Utilize tratamento de exceções para lidar com possíveis erros durante o
  cadastro, como entradas inválidas.

- **Consulta de Produtos:**
  - Implemente uma função que permita ao usuário buscar um produto pelo
  código. Caso o produto não exista, lance uma exceção personalizada
  indicando que o produto não foi encontrado.

- **Atualização de Estoque:**
  - Crie funções que permitam a atualização da quantidade em estoque de um
  produto, levando em consideração entradas ou saídas. Faça o tratamento lógico
  para lidar com casos em que a quantidade atual seja insuficiente
  para uma saída.

- **Relatórios:**
  - Utilize LINQ para gerar 3 relatórios:
    1. Lista de produtos com quantidade em estoque abaixo de um
    determinado limite informado pelo usuário.
    1. Lista de produtos com valor entre um mínimo e um máximo informados
    pelo usuário.
    1. Informar o valor total do estoque e o valor total de cada produto de
    acordo com seu estoque.


