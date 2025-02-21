using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDecoratorDemo;

public class ColorDecorator(Component component, ConsoleColor color) : Decorator(component)
{
    public override void Operation()
    {
        var previousColor = Console.ForegroundColor;
        Console.ForegroundColor = color;
        base.Operation();
        Console.ForegroundColor = previousColor;
    }
}
