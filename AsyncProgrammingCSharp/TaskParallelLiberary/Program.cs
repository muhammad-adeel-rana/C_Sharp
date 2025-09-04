using System.Runtime.CompilerServices;
using TaskParallelLiberary;
//Task Task1 = new Task(() =>
//{
//    //Thread.Sleep(2000);
//});

//Task<int> Task2 = new Task<int>(() =>
//{
//    Thread.Sleep(20000);
//    return 20;
//});

//Task1.Start();
//Task2.Start(); 


Task<Bitmap> ProcessBitmap =Task.Factory.StartNew<Bitmap>(() =>
{
    string imagePath = "myimage.png";
    return ApplyFilters(imagePath);
});

await ProcessBitmap;
//ProcessBitmap.Start();
Console.WriteLine("Hello, World!");
Console.ReadLine();
static Bitmap ApplyFilters(string imagePath)
{
    Thread.Sleep(2000);
    Console.WriteLine("Processing is done!");
    return new Bitmap() { Name = "RandomGeneratedName" };
}