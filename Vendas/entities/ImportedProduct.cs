﻿using System;
using System.Globalization;

namespace Vendas.entities
{
    internal class ImportedProduct : Product
    {
        public double  CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee) : base(name,price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
          return Price += CustomsFee;
        }
        public override string priceTag()
        {
            return Name + " $ " + TotalPrice().ToString("F2",CultureInfo.InvariantCulture) + " (CustomsFree: " + CustomsFee + ")";
        }
    }
}
