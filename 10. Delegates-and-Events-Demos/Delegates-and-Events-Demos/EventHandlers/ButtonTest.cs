using System;

public class ButtonTest
{
    private static void Button_Click(object sender, EventArgs eventArgs)
    {
        Console.WriteLine("Button_Click() event called.");
    }

    private static void Custom(object sender, EventArgs eventArgs)
    {
        Console.WriteLine("Custom text message. {0}");
    }

    public static void Main()
    {
        Button button = new Button();
        button.Click += Button_Click;
        button.Click += Custom;
        button.FireClick();
    }
}
