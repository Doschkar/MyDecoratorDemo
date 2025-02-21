using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDecoratorDemo;

public class Decorator(Component component) : Component
{
    public override void Operation() => component.Operation();
}
