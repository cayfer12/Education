using System;


namespace ConsoleApp5
{
    class Begin
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Введите путь до файла ввода");
            string pathInput = Console.ReadLine();
            Console.WriteLine("Введите путь до файла вывода");
            string pathOutput = Console.ReadLine();
            Program program = new Program(pathInput, pathOutput);

            program.InputNum();
            program.CalcNums();
            program.OutputNum();
        }
    }
}
