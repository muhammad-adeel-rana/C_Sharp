using BethanysPieShop.InventoryManagement.Domain.Contracts;
using BethanysPieShop.InventoryManagement.Domain.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BethanysPieShop.InventoryManagement.Domain.ProductManagement
{
    internal class BulkProduct : RegularProduct, ISaveable
    {
        public BulkProduct(int id, string name, string? description, Price price, int maxNoOfItems) :
            base(id, name, description, price, maxNoOfItems, UnitType.PerKG)
        {
        }

        public override void IncreaseStock()
        {
            AmountInStock++;
        }

        public string ConvertToStringForSaving()
        {
            return $"{Id};{Name};{Description};{maxNoOfItems};{Price.ItemPrice};{(int)Price.Currency};{(int)UnitType};3;";
        }

        public override object Clone()
        {
            return new BulkProduct(0, this.Name, this.Description, new Price() { ItemPrice = this.Price.ItemPrice, Currency = this.Price.Currency },
                this.maxNoOfItems);
        }
    }
}
