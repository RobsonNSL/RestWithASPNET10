namespace RestWithASPNET10.Service
{
    public class MathService
    {
        public decimal Sum(decimal primeiroNumero, decimal segundoNumero) => primeiroNumero + segundoNumero;
        public decimal Subtracao(decimal primeiroNumero, decimal segundoNumero) => primeiroNumero - segundoNumero;
    }
}
