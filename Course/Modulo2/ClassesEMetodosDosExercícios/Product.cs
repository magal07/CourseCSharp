using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Course.Modulo2.ClassesDosExercícios
{
    public class Product
    {
        public string Name;
        public double Price;
        public int Quantity;


        public double ValorTotalEmEstoque()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return Name
                    + ", $ "
                    + Price.ToString("F2", CultureInfo.InvariantCulture)
                    + ", "
                    + Quantity
                    + " unidades, Total: $ "
                    + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
