﻿
using CommandDesignPattern;

Console.WriteLine("Command Design Pattern");

Console.WriteLine("Enter Commands (ON/OFF) : ");
string cmd = Console.ReadLine();

Light lamp = new Light();
ICommand switchUp = new FlipUpCommand(lamp);
ICommand switchDown = new FlipDownCommand(lamp);

Switch s = new Switch();

if (cmd == "ON")
{
    s.StoreAndExecute(switchUp);
}
else if (cmd == "OFF")
{
    s.StoreAndExecute(switchDown);
}
else
{
    Console.WriteLine("Command \"ON\" or \"OFF\" is required.");
}

Console.ReadKey();
