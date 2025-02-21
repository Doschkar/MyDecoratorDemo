using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDecoratorDemo;

public sealed class ConcreteComponent(string text) : Component
{
    public override void Operation() => Console.Write(text);
}
