using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDecoratorDemo;

public sealed class SimpleComponent(string text)
{
    public string? Mask { get; set; }
    public bool DoShowDate { get; set; }
    public bool ChangeColor { get; set; }
    public ConsoleColor Color { get; set; }

    public void Operation()
    {
        if (DoShowDate) Console.Write(DateTime.Now.ToString("HH:mm:ss: "));
        if (Mask is not null) Console.Write(Mask);
        var previous = Console.ForegroundColor;
        if (ChangeColor) Console.ForegroundColor = Color;
        Console.Write(text);
        Console.ForegroundColor = previous;
        if (Mask is not null) Console.Write(Mask);
    }
}
