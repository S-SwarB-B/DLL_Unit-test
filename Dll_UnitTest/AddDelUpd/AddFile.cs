using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dll_UnitTest.AddDelUpd
{
    public class WorkFileAdd
    {
        public int AddFile(string? Title, string? Type, string? Date, string? Position, string? Person, string? Organaizer) // создание файла
        {
            try
            { 
                int countLines = 0;
                using (StreamReader streamReader = new StreamReader("Расписание.txt")) // подсчет количества строк для нумерации
                {
                    while (streamReader.ReadLine() != null)
                    {
                        countLines++;
                    }
                }
                string total_string = $"{countLines+1};{Title};{Type};{Date};{Position};{Person};{Organaizer}";
                    
                using (StreamWriter streamWriter = new StreamWriter("Расписание.txt", true, System.Text.Encoding.Default)) // запись в файл
                {
                    streamWriter.WriteLine(total_string);
                }
                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
