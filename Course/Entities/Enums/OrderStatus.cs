namespace Course.Entities.Enums
{
        enum OrderStatus : int // informando que cada valor do meu OrderStatus será de um int (:) = order status é derivado de um int

    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3

    }
}
