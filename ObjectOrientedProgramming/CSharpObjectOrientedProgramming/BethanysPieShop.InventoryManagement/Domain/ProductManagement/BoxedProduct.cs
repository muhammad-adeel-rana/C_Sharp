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
    internal class BoxedProduct : RegularProduct, ISaveable
    {
        private int amountPerBox;

        public int AmountPerBox
        {
            get { return amountPerBox; }
            set { amountPerBox = value; }
        }
        public BoxedProduct(int id, string name, string? description, Price price, int maxAmountInStock, int amountPerBox) :
            base(id, name, description, price, maxAmountInStock, UnitType.PerBox)
        {
            AmountPerBox = amountPerBox;
        }

        public override string DisplayDetailsFull()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Boxed Product\n");
            sb.Append($"{Id} {Name} \n{Description}\n{Price}\n{AmountInStock} item(s) in stock");
            if (IsBelowStockThreshold)
            {
                sb.Append("\n!!STOCK LOW!!");
            }

            return sb.ToString();
        }

        public override void UseProduct(int items)
        {
            DecreaseStock(0, "test");
            int smallestMultiple = 0;
            int batchSize;

            while (true)
            {
                smallestMultiple++;
                if (smallestMultiple * AmountPerBox > items)
                {
                    batchSize = (smallestMultiple * AmountPerBox);
                    break;
                }
            }

            base.UseProduct(batchSize);
        }

        //public void UseBoxedProduct(int items)
        //{
        //    DecreaseStock(0, "test");
        //    int smallestMultiple = 0;
        //    int batchSize;

        //    while(true)
        //    {
        //        smallestMultiple++;
        //        if(smallestMultiple * AmountPerBox > items)
        //        {
        //            batchSize = (smallestMultiple * AmountPerBox);
        //            break;
        //        }
        //    }

        //    UseProduct(batchSize);
        //}

        public override void IncreaseStock()
        {
            AmountInStock += AmountPerBox;
        }

        public override void IncreaseStock(int amount)
        {
            int totalStock = AmountInStock + amount * AmountPerBox;
            if (totalStock <= maxNoOfItems)
            {
                AmountInStock = totalStock;
            }
            else
            {
                AmountInStock = maxNoOfItems;
                Log($"{CreateSimpleProductRepresentation} stock overflow. " +
                    $"{totalStock - AmountInStock} item(s) ordered that couldn't be stored.");
            }
        }

        public string ConvertToStringForSaving()
        {
            return $"{Id};{Name};{Description};{maxNoOfItems};{Price.ItemPrice};{(int)Price.Currency};{(int)UnitType};1;{AmountPerBox}";
        }

        public override object Clone()
        {
            return new BoxedProduct(0, this.Name, this.Description, new Price() { ItemPrice = this.Price.ItemPrice, Currency = this.Price.Currency },
                this.maxNoOfItems, this.AmountPerBox);
        }
    }
}
