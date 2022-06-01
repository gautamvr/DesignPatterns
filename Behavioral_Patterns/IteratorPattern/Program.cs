// See https://aka.ms/new-console-template for more information

using IteratorPattern;

Console.WriteLine("Iterator Pattern");
Console.WriteLine("Client Code\n");

IImageCollection imageCollection = new ScanImageCollection();
var image1 = "Image1";
var image2 = "Image2";
var image3 = "Image3";

imageCollection.AddImage(image1);
imageCollection.AddImage(image2);
imageCollection.AddImage(image3);

var iter= imageCollection.CreateIterator();

while (!iter.IsDone())
{
    Console.WriteLine($"Current Image is {iter.NextSlice()}");
}
