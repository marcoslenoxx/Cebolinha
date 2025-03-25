String pudim;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("Escreva uma frase");
Console.ResetColor();
pudim = Console.ReadLine()!.Replace("r", "l");
Console.WriteLine($"{pudim}");

