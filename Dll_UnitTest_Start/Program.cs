using Dll_UnitTest;
using System;
using System.Diagnostics;

namespace StartWorkProgramm
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            if (File.Exists("Расписание.txt") == false)
            {
                File.Create("Расписание.txt");
                Console.WriteLine("Произошло создание файла. Перезагрузите приложение");
                Environment.Exit(0);
            }
            
            GlavWorkFile glavWorkFile = new GlavWorkFile();
            glavWorkFile.GlavMetod();
        }
    }
}