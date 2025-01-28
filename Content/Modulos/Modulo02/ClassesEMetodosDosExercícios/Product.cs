using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Xml.Linq;
namespace Course.ModulosDeEstudo.Modulo2.ClassesEMetodosDosExercícios
{
    public class Product
    {
        private string _name;
        public double Price { get; private set; }
        public double Quantity { get; set; }

        public Product()
        {
        }

        public Product(string name, double price, int quantity)
        {
            _name = name;
            Price = price;
            Quantity = quantity;
        }


        // IMPLEMENTAÇÃO DE UMA PROPERTY
        public string Name
        {
            get { return _name; }

            set
            {
                if (value != null && value.Length > 1)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Digite corretamente o nome do ítem para alterar o produto!");
                }
            }

        }

        /* Usando Get e Set 
        public string GetName()
        {
            return _name;
        }

        public void SetName(string name) {
            if (name != null && name.Length > 1)
            {
                _name = name;
            }
            else
            {
                Console.WriteLine("Digite corretamente o nome do ítem para alterar o produto!");
            }   
        }
        */

        //public double Quantity
        //{
        //    get { return Quantity;  }
        //}

        /* USANDO PROPERTY AO INVÉS DE METODOS GET/SET
        public int GetQuantity()
        {
            return Quantity;
        }

        public double GetPrice()
        {
            return Price;
        }                   
                            */


        public double ValorTotalEmEstoque()
        {
            return Price * Quantity;
        }

        public void AdicionarProdutos(int quantity)
        {
            Quantity += quantity;
        }

        public void RemoverProdutos(int quantity)
        {
            Quantity -= quantity;
        }

        public override string ToString()
        {
            return _name
                    + ", $ "
                    + Price.ToString("F2", CultureInfo.InvariantCulture)
                    + ", "
                    + Quantity
                    + " unidades, Total: $ "
                    + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
