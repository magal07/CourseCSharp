/* using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Metodos
{
    public class EstoqueDeProdutos
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
            return Name + ", $ " + Price;
        }
    }
}
*/ 