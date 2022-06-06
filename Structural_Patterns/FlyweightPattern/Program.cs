// See https://aka.ms/new-console-template for more information

using FlyweightPattern;

Console.WriteLine("Flyweight Pattern - client Side");

Console.WriteLine("---------------");


ImageController imageController = new ImageController();

for (int i = 0; i < 10; i++)
{
    var sliceID = "BlueSlice" + i.ToString();
    imageController.AddSlices(sliceID, "Blue", "64x64", 24);
}

for (int i = 0; i < 20; i++)
{
    var sliceID = "RedSlice" + i.ToString();
    imageController.AddSlices(sliceID, "Red", "64x64", 48);
}

imageController.DisplayWholeImage();
