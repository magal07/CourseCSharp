namespace Content.Modulos.Modulo10.ComparcaoGetHashCode.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Product))
            {
                return false;
            }

            Product other = obj as Product;
            return Name.Equals(other.Name) && Price.Equals(other.Price);
            // validando se o nome e o preço são iguais ao outro objeto nome e preço
            // e tornando true o Program principal, considerando que obj referenciados
            // em outras instâncias e formas mesmo que sendo diferentes, se tornarão iguais
            // pelo GetHashCode
        }
    }
}