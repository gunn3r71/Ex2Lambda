# Exercício 2 - Lambda

1º Crie uma classe Pessoa, definida desta forma:

class Pessoa 
{ 
 public double Peso { get; set; } 
 public double Altura { get; set; } 
 public double CalcularImc(Calculo calculo) 
 { 
 return calculo(Peso, Altura); 
 } 
} 

#

2º O tipo Calculo é um delegate, que deve ser criado por você. Como é possível perceber na 
definição da classe, os parâmetros passados para ele são o peso e a altura, e o retorno é o 
valor do IMC. 

#

3º Crie um objeto do tipo Pessoa, com um determinado peso e altura. Depois chame o método 
CalcularImc() para descobrir o IMC dessa pessoa. Utilize uma expressão lambda como 
parâmetro para o método, a fim de realizar o cálculo.
