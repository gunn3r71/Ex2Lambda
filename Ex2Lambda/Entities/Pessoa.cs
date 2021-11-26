using static Ex2Lambda.Program;

namespace Ex2Lambda.Entities
{
    public class Pessoa
    {
        public Pessoa(double peso, double altura)
        {
            Peso = peso;
            Altura = altura;
        }

        public double Peso { get; private set; }
        public double Altura { get; private set; }

        public double CalcularImc(Calculo calculo)
        {
            return calculo(Peso, Altura);
        }
    }
}
