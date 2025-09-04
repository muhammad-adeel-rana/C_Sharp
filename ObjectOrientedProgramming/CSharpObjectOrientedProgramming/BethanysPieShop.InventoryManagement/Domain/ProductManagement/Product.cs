using BethanysPieShop.InventoryManagement.Domain.General;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShop.InventoryManagement.Domain.ProductManagement
{
    public abstract class Product : ICloneable
    {
        #region Fields
        private int id;
        private string name = string.Empty;
        private string? description;

        protected int maxNoOfItems = 100;

        public static int stockThreshold = 10;
        #endregion

        #region Properties
        public int Id //Full Property
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value.Length > 50 ? value[..50] : value;
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                description = value.Length > 250 ? value[..250]: value;
            }
        }

        public UnitType UnitType { get; set; }
        public int AmountInStock { get; protected set; } = 0;
        public bool IsBelowStockThreshold {  get; protected set; } = false;
        public Price Price { get; set; }
        #endregion

        #region Constructors
        public Product(int id) : this(id, string.Empty)
        {
        }
        public Product(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Product(int id, string name, string? description, Price price, int maxNoOfItems, UnitType unitType)
        {
            Id = id;
            Name = name;
            Description = description;
            this.maxNoOfItems = maxNoOfItems;
            Price = price;
            this.UnitType = unitType;

            UpdateLowStock();

        }

        #endregion 
        public virtual void UseProduct(int items)
        {
            if (items <= AmountInStock)
            {
                AmountInStock -= items;

                UpdateLowStock();

                Log($"Amount in stock updated. Now {AmountInStock} items are there in stock.");
            }
            else
            {
                Log($"Not enough items on stock for {CreateSimpleProductRepresentation()}. " +
                    $"{AmountInStock} available but {items} requested.");
            }
        }

        //public virtual void IncreaseStock()
        //{
        //    AmountInStock++;
        //}


        #region Abstract Methods
        public abstract object Clone();
        public abstract void IncreaseStock();
        #endregion

        #region Virtual Methods
        public virtual void IncreaseStock(int amount)
        {
            int totalStock = AmountInStock + amount;
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

            if (AmountInStock > stockThreshold)
            {
                IsBelowStockThreshold = false;
            }
        }
        public virtual void UpdateLowStock()
        {
            if(AmountInStock <= stockThreshold)
            {
                IsBelowStockThreshold = true;
            }
        }

        protected virtual void Log(string message)
        {
            Console.WriteLine(message);
        }

        protected virtual string CreateSimpleProductRepresentation()
        {
            return $"Product {id} ({name})";
        }

        protected virtual void DecreaseStock(int items, string reason)
        {
            if (items <= AmountInStock)
            {
                AmountInStock -= items;
            }
            else
            {
                AmountInStock = 0;
            }
            UpdateLowStock();

            Log(reason);
        }

        public virtual string DisplayDetailsShort()
        {
            return $"{id} {name} \n{AmountInStock} items in stock";
        }

        public virtual string DisplayDetailsFull()
        {
            //StringBuilder sb = new StringBuilder();
            //sb.Append($"{id} {name} \n{description}\n{amountInStock} item(s) in stock");

            //if (isBelowStackThreshold)
            //{
            //    sb.Append("\n!!STOCK LOW!!");
            //}

            //return sb.ToString();
            return DisplayDetailsFull("");
        }

        public virtual string DisplayDetailsFull(string extraDetails)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Id} {Name} \n{Description}\n{Price}\n{AmountInStock} item(s) in stock");
            sb.Append(extraDetails);
            if (IsBelowStockThreshold)
            {
                sb.Append("\n!!STOCK LOW!!");
            }

            return sb.ToString();
        }
        #endregion

        #region Static Method
        public static void ChangeStockThreshold(int newStockThreshold)
        {
            if (newStockThreshold > 0)
                stockThreshold = newStockThreshold;
        }
        #endregion

    }
}
