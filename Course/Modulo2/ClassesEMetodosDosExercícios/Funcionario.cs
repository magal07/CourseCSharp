using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Course.Modulo2.ExercícioModulo2.ClassesDosExercícios
{
    internal class Funcionario
    {
        public string NomeFuncionario;
        public double SalarioFuncionario;
        public double SalarioBruto;
        public double Imposto;


        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto * porcentagem / 100.0;
        }

        public override string ToString()
        {
            return NomeFuncionario 
                + ", R$ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
