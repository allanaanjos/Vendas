

namespace Vendas.entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManuFactureDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price,DateTime manuFactureDate): base(name,price)
        {
            ManuFactureDate = manuFactureDate;
        }

        public override string priceTag()
        {
            return Name + " (Used)  $ " + Price + " (ManufactureDate date:  " + ManuFactureDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}
