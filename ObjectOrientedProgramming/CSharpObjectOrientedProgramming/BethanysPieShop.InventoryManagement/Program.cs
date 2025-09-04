using BethanysPieShop.InventoryManagement.Domain.General;
using BethanysPieShop.InventoryManagement.Domain.ProductManagement;
using BethanysPieShop.InventoryManagement;

PrintWelcome();


#region Layout

static void PrintWelcome()
{

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(@"
    ()()()()()()   ____       _   _                       _       _____ _         _____ _                                        
    |\         |  |  _ \     | | | |                     ( )     |  __ (_)       / ____| |                                         ()()()()()()
    |.\. . . . |  | |_) | ___| |_| |__   __ _ _ __  _   _|/ ___  | |__) |  ___  | (___ | |__   ___  _ __                           |\         |
    \'.\       |  |  _ < / _ \ __| '_ \ / _` | '_ \| | | | / __| |  ___/ |/ _ \  \___ \| '_ \ / _ \| '_ \                          |.\. . . . |
     \.:\ . . .|  | |_) |  __/ |_| | | | (_| | | | | |_| | \__ \ | |   | |  __/  ____) | | | | (_) | |_) |                         \'.\       |
      \'o\     |  |____/ \___|\__|_| |_|\__,_|_| |_|\__, | |___/ |_|__ |_|\___| |_____/|_| |_|\___/| .__/                    _      \.:\ . . .|
       \.'\. . |  |_   _|                    | |     __/ |         |  \/  |                        | |                      | |      \'o\     |
        \'.\   |    | |  _ ____   _____ _ __ | |_ __|___/__ _   _  | \  / | __ _ _ __   __ _  __ _ |_|_ _ __ ___   ___ _ __ | |_      \.'\. . |
         \'`\ .|    | | | '_ \ \ / / _ \ '_ \| __/ _ \| '__| | | | | |\/| |/ _` | '_ \ / _` |/ _` |/ _ \ '_ ` _ \ / _ \ '_ \| __|      \'.\   |
          \.'\ |   _| |_| | | \ V /  __/ | | | || (_) | |  | |_| | | |  | | (_| | | | | (_| | (_| |  __/ | | | | |  __/ | | | |_        \'`\ .|
           \__\|  |_____|_| |_|\_/ \___|_| |_|\__\___/|_|   \__, | |_|  |_|\__,_|_| |_|\__,_|\__, |\___|_| |_| |_|\___|_| |_|\__|        \.'\ |
                                                             __/ |                            __/ |                                       \__\|
                                                            |___/                            |___/                               
    ");

    Console.ResetColor();

    Console.WriteLine("Press enter key to start logging in!");

    //accepting enter here
    Console.ReadLine();

    Console.Clear();
}
#endregion


//Price samplePrice = new Price() { ItemPrice = 10, Currency = Currency.Dollar };
//printWelcome();



//Product p1 = new(1) { Name = "Sugar", Description = "Lorem ipsem", Price = samplePrice, UnitType = UnitType.PerKG };
//p1.IncreaseStock(10);
//p1.Description = "Sample Product";
////Console.Write(p1.DisplayDetailsFull());
//Console.WriteLine(p1.AmountInStock);

//Product p2 = new("Pr002") { Name = "Cake Decorations", Description = "Lorem ipsem", Price = new Price() { ItemPrice = 8, Currency = Currency.Euro}, UnitType = UnitType.PerItem };

//Product.ChangeStockThreshold(15);



Utilities.InitializeStock();
Utilities.ShowMainMenu();
Console.WriteLine("Application shutting down");
Console.ReadLine();

//Product p1 = new Product(1, "Sugar", "Lorem ipsum", new Price() { ItemPrice = 10, Currency = Currency.Euro }, 100, UnitType.PerKG);
//p1.IncreaseStock(100);

////Act
//p1.UseProduct(20);

//Console.WriteLine(p1.AmountInStock);

//BoxedProduct bp = new BoxedProduct(6, "Eggs", "Lorem Ipsum", new Price() { ItemPrice = 10, Currency = Currency.Dollar}, 100, 6);
//bp.IncreaseStock(30);
//bp.UseProduct(23);

//RegularProduct rp = new(1, "Sugar", "Lorem ipsum", new Price() { ItemPrice = 10, Currency = Currency.Dollar}, 100, UnitType.PerKG);
//Console.WriteLine(rp.ConvertProductPrice(Currency.Euro));