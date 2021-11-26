using Ex2Lambda.Entities;
using System;

namespace Ex2Lambda
{
    public class Program
    {
        public delegate double Calculo(double x, double y);

        static void Main(string[] args)
        {
            var pessoa = new Pessoa(80, 1.70);

            var imc = pessoa.CalcularImc((x, y) => x / Math.Pow(y, 2));

            Console.WriteLine(imc);
        }
    }
}
