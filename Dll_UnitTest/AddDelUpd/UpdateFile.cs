using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dll_UnitTest.AddDelUpd
{
    public class WorkUpdateFile
    {
        public int UpdateFile(string? ID,string? Title, string? Type, string? Date, string? Position, string? Person, string? Organaizer)
        {
            try
            {
                int countLines = 0;
                string OLD_Title = "";
                string OLD_Type = "";
                string OLD_Date = "";
                string OLD_Position = "";
                string OLD_Person = "";
                string OLD_Organaizer = "";
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
                            OLD_Title = words[1];
                            OLD_Type = words[2];
                            OLD_Date = words[3];
                            OLD_Position = words[4];
                            OLD_Person = words[5];
                            OLD_Organaizer = words[6];
                        }
                        line = line.Trim();                  
                    }                                      
                }
                string total_string = $"{ID};{Title};{Type};{Date};{Position};{Person};{Organaizer}";
                var text = new StringBuilder();
                foreach (string s in File.ReadAllLines("Расписание.txt"))
                {
                    text.AppendLine(s.Replace($"{ID};{OLD_Title};{OLD_Type};{OLD_Date};{OLD_Position};{OLD_Person};{OLD_Organaizer}", total_string));
                }
                using (var file = new StreamWriter("Расписание.txt"))
                {
                    file.Write(text.ToString());
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
