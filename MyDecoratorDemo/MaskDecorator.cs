using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDecoratorDemo;

public class MaskDecorator(Component component, string mask) : Decorator(component)
{
    public override void Operation()
    {
        Console.Write(mask);
        base.Operation();
        Console.Write(mask);
    }
}
