using BethanysPieShop.InventoryManagement.Domain.ProductManagement;
using BethanysPieShop.InventoryManagement.Domain.General;

namespace Bethany_sPieShop.InventoryManagement.Tests
{
    public class ProductTests
    {
        [Fact]
        public void UseProduct_Reduces_AmountInStock()
        {
            //Arrange
            RegularProduct p1 = new(1, "Sugar", "Lorem ipsum", new Price() { ItemPrice = 10, Currency = Currency.Euro }, 100, UnitType.PerKG);
            p1.IncreaseStock(100);

            //Act
            p1.UseProduct(20);

            //Assert
            Assert.Equal(80, p1.AmountInStock);
        }

        [Fact]
        public void UseProduct_ItemsHigherThanStock_NoChangetoStack()
        {
            //Arrange
            RegularProduct p1 = new(1, "Sugar", "Lorem ipsum", new Price() { ItemPrice = 10, Currency = Currency.Euro }, 100, UnitType.PerKG);
            p1.IncreaseStock(30);

            //Act
            p1.UseProduct(50);

            //Assert
            Assert.Equal(30, p1.AmountInStock);
        }

    }
}
