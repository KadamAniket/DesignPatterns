using Strategy.Taxes;

namespace Strategy.Models
{
    public class Invoice
    {
        private readonly Order o1;
        private readonly ITaxForCountry tax;

        public Invoice(Order o1, ITaxForCountry tax)
        {
            this.o1 = o1;
            this.tax = tax;
        }

        public double calculate()
        {
            return this.tax.CalculateFinalAmount(this.o1.Amount);
        }
    }
}
