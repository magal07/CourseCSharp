using Course.Entities; // Importa entidades definidas no projeto
using Course.Entities.Enums; // Importa enumerações do projeto

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criação de um objeto da classe Order (Pedido)
            Order order = new Order
            {
                Id = 1080, // Define o ID do pedido
                Moment = DateTime.Now, // Define o momento atual como a data e hora do pedido
                Status = OrderStatus.PendingPayment // Define o status inicial do pedido como "Pagamento Pendente"
            };

            // Exibe as informações do pedido
            Console.WriteLine(order);

            // Converte o enum OrderStatus.PendingPayment para string
            string txt = OrderStatus.PendingPayment.ToString();

            // Converte uma string ("Delivered") para um valor do enum OrderStatus
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            // Exibe os valores convertidos
            Console.WriteLine(os); // Exibe "D
            Console.WriteLine(txt); // Exibe "PendingPayment"

        }
    }
}