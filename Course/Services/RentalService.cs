using System;
using Course.Entities;

namespace Course.Services
{
    internal class RentalService // a classe rentalservice não mais intancia a dependência dela, ela só recebe o obj instanciado (ITaxService)
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private ITaxService _taxService; // interface

        public RentalService(double pricePerHouser, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHouser;
            PricePerDay = pricePerDay;
            _taxService = taxService; // inversão de controle por meio de injeção de dependência
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start); // SUBTRAINDO FINISH PELO START

            double basicPayment = 0.0;
            if(duration.TotalHours <= 12.0)
            {                                 // \/ Arredonda os valores pra cima
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours); 
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment); // pegando taxas do basicPayment (imposto)

            carRental.Invoice = new Invoice(basicPayment, tax);

        }
    }
}
