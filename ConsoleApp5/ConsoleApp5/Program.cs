using System;
using System.IO;

namespace ConsoleApp5
{
    class Program
    {
        private int m,x,k,n;
        private string pathInp;//= @"C:\";
        private string pathOut;
        private string[] Data;

        public Program(string pathInp, string pathOut)
        {
            this.pathInp = @pathInp;
            this.pathOut = @pathOut;
        }

        public void InputNum()
        {
            try
            {
                Data = File.ReadAllText(pathInp + "input.txt").Split(" ");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Заданная директория не найдена");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Файл ввода по заданному пути не найден");
                Environment.Exit(0);
            }
            try { 
            m = Int32.Parse(Data[0]);
                n = Int32.Parse(Data[1]);
                Console.WriteLine("Введите K");
                k = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка формата передаваемых чисел");
                Environment.Exit(0);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Переданно пустое значение");
                Environment.Exit(0);
            }
        }
            public void CalcNums()
            {
                for (int i = 0; i <= n; i++)
                {
                    x += m ^ i;
                }

                try
                {
                    x = x / k;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("К не может быть равен 0");
                    Environment.Exit(0);
                }

            }
            public void OutputNum()
            {
                try
                {
                    File.WriteAllText(pathOut + "output.txt", string.Join("", x));
                    Console.WriteLine("Файл output.txt успешно записан по пути " + pathOut);
            }
                catch (DirectoryNotFoundException)
                {
                    Console.WriteLine("Файл вывода не может быть создан по заданному пути");
                    Environment.Exit(0);
                }
            }
        }
    }

