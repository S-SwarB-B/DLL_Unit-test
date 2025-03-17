using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll_UnitTest.InfoFile
{
    public class WorkInfoFileCount
    {
        public int InfoFileCount()
        {
            try
            {
                int countLines = 0;
                using (StreamReader reader = new StreamReader("Расписание.txt"))
                {
                    string? line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        countLines++;
                    }
                }
                Console.WriteLine($"Количество расписаний: {countLines}");
                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
