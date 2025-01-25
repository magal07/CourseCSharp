namespace Course.ModulosDeEstudo.Metodos
{
    public class Calculadora
    {

        public static double Iof = 6.0;
        public static double DolarParaReal(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * Iof / 100.0;
        }


        public static double Pi = 3.14;

        public static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;

        }

        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0); // PI = formula 3 ª Terceira, r* r* r* = Math.Pow(r, 3.0)
        }
    }
}
