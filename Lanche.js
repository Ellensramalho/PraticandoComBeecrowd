/*Com base na tabela (que está no site do beecrowd), escreva um programa que leia o código de um item e a quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.

Entrada
O arquivo de entrada contém dois valores inteiros correspondentes ao código e à quantidade de um item conforme tabela (que está no site do beecrowd).

Saída
O arquivo de saída deve conter a mensagem "Total: R$ " seguido pelo valor a ser pago, com 2 casas após o ponto decimal. */


const fs = require('fs');

const input = fs.readFileSync(0, 'utf8').trim().split(' ');

const codigo = Number(input[0]);
const quantidade = Number(input[1]);

let preco = 0;

if (codigo === 1) preco = 4.00;
else if (codigo === 2) preco = 4.50;
else if (codigo === 3) preco = 5.00;
else if (codigo === 4) preco = 2.00;
else if (codigo === 5) preco = 1.50;

const total = preco * quantidade;

console.log(`Total: R$ ${total.toFixed(2)}`);