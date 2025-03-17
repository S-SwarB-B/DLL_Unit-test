using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll_UnitTest.InfoFile
{
    public class WorkInfoFileDate
    {
        public int InfoFileDate(string? Date)
        {
            try
            {
                using (StreamReader reader = new StreamReader("Расписание.txt"))
                {
                    
                    string? line;                 
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] words = line.Split(';');
                        if (words[3] == Date)
                        {                            
                            Console.Write($"{words[0]} - {words[1]}" +
                                $"\nТип: {words[2]}" +
                                $"\nДата: {words[3]}" +
                                $"\nМесто: {words[4]}" +
                                $"\nУчастник: {words[5]}" +
                                $"\nОрганизатор: {words[6]}\n\n");
                        }
                    }
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
