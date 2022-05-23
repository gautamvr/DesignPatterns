// See https://aka.ms/new-console-template for more information

using ChainOfResponsibilityPattern;

Console.WriteLine("Client - Code ");
Console.WriteLine("------------------\n");
Console.WriteLine("Demo for Chain of Responsibility Design Pattern\n");

RotateHandler _rotate = new RotateHandler();
ScalingHandler _scaling = new ScalingHandler();
TransformImageHandler _transform = new TransformImageHandler();
BrightnessHandler _brightness = new BrightnessHandler();

_rotate.SetNextHandler(_scaling);
_scaling.SetNextHandler(_transform);
_transform.SetNextHandler(_brightness);

_rotate.ProcessImage();

