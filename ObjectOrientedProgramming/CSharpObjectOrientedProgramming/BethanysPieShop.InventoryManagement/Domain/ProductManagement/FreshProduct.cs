using BethanysPieShop.InventoryManagement.Domain.Contracts;
using BethanysPieShop.InventoryManagement.Domain.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShop.InventoryManagement.Domain.ProductManagement
{
    internal class FreshProduct : RegularProduct, ISaveable
    {
        public DateTime ExpiryDateTime { get; set; }
        public string? StorageInstruction { get; set; }
        public FreshProduct(int id, string name, string? description, Price price, int maxNoOfItems, UnitType unitType) : base(id, name, description, price, maxNoOfItems, unitType)
        {
        }

        #region Override Methods
        public override string DisplayDetailsFull()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Boxed Product\n");
            sb.Append($"{Id} {Name} \n{Description}\n{Price}\n{AmountInStock} item(s) in stock");
            if (IsBelowStockThreshold)
            {
                sb.Append("\n!!STOCK LOW!!");
            }
            sb.AppendLine($"Storage Instructions: {StorageInstruction}");
            sb.AppendLine($"Expiry Date: {ExpiryDateTime.ToShortDateString()}");


            return sb.ToString();
        }

        public override void IncreaseStock()
        {
            AmountInStock++;
        }

        public override object Clone()
        {
            return new FreshProduct(0, this.Name, this.Description, new Price() { ItemPrice = this.Price.ItemPrice, Currency = this.Price.Currency },
                this.maxNoOfItems, this.UnitType);
        }
        #endregion

        public string ConvertToStringForSaving()
        {
            return $"{Id};{Name};{Description};{maxNoOfItems};{Price.ItemPrice};{(int)Price.Currency};{(int)UnitType};2;";
        }
    }
}
