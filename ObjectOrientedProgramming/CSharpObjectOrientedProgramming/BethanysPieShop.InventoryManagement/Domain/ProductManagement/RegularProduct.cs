using BethanysPieShop.InventoryManagement.Domain.Contracts;
using BethanysPieShop.InventoryManagement.Domain.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShop.InventoryManagement.Domain.ProductManagement
{
    public class RegularProduct : Product, ISaveable
    {
        public RegularProduct(int id, string name, string? description, Price price, int maxNoOfItems, UnitType unitType) 
            : base(id, name, description, price, maxNoOfItems, unitType)
        {
        }

        public string ConvertToStringForSaving()
        {
            return $"{Id};{Name};{Description};{maxNoOfItems};{Price.ItemPrice};{(int)Price.Currency};{(int)UnitType};4;";
        }

        #region Override Methods
        public override void IncreaseStock()
        {
            AmountInStock++;
        }

        public override object Clone()
        {
            return new RegularProduct(0, this.Name, this.Description, new Price() { ItemPrice = this.Price.ItemPrice, Currency = this.Price.Currency },
                this.maxNoOfItems, this.UnitType);
        }

        #endregion
    }
}
