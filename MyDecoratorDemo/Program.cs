using MyDecoratorDemo;

/*
var simpleComponent = new SimpleComponent("Hallo, 5C!");

simpleComponent.Operation();
Console.WriteLine();

simpleComponent.Mask = "***";
simpleComponent.Operation();
Console.WriteLine();

simpleComponent.DoShowDate = true;
simpleComponent.Operation();
Console.WriteLine();

simpleComponent.ChangeColor = true;
simpleComponent.Color = ConsoleColor.Red;
simpleComponent.Operation();
Console.WriteLine();
*/

var concreteComponent = new ConcreteComponent("Hallo, 5C!");
concreteComponent.Operation();
Console.WriteLine();

var colorDecorator = new ColorDecorator(concreteComponent, ConsoleColor.Red);

var maskDecorator = new MaskDecorator(colorDecorator, "***");
maskDecorator.Operation();
Console.WriteLine();

var maskDecorator2 = new MaskDecorator(maskDecorator, "+++");
maskDecorator2.Operation();
Console.WriteLine();

new ColorDecorator(new MaskDecorator(new ConcreteComponent("Meinen Text"),
    "+++"),
    ConsoleColor.Green).Operation();
