using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dll_UnitTest.InfoFile
{
    public class WorkInfoFileID
    {
        public int InfoFileID(string? ID)
        {
            try
            {
                int countLines = 0;
                using (StreamReader reader = new StreamReader("Расписание.txt"))
                {
                    string? line;
                    string[] words;
                    while ((line = reader.ReadLine()) != null)
                    {
                        countLines++;
                        if (Convert.ToString(countLines) == ID)
                        {
                            words = line.Split(';');
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
