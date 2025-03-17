using Dll_UnitTest.AddDelUpd;
using Dll_UnitTest.InfoFile;

namespace Dll_UnitTest
{
    public class GlavWorkFile
    {   
        internal void P_Interface_Info(ref int Error)
        {
            Console.Write("\n\n1 - Вывод расписаний по ID\n" +
                "2 - Вывод всех расписаний\n" +
                "3 - Вывод расписаний по дате\n" +        
                "4 - Вывод расписания по типу\n" +
                "5 - Вывод количества расписаний\n" +
                "6 - Вывод расписаний по участникам\n" +
                "7 - Вывод расписаний по организаторам\n" +
                "Ваш выбор: ");
            string? PRK = Console.ReadLine(); // переключатель
            if (PRK == "1")
            {
                WorkInfoFileID workInfoFileID = new WorkInfoFileID();
                Console.WriteLine("\nПРОСМОТР РАСПИСАНИЙ ПО ID\n");
                Console.Write("Идентификатор расписания: ");
                string? ID = Console.ReadLine();
                Error = workInfoFileID.InfoFileID(ID);
            }
            else if (PRK == "2")
            {
                WorkInfoFileAll workInfoFileAll = new WorkInfoFileAll();
                Console.WriteLine("\nПРОСМОТР ВСЕХ РАСПИСАНИЙ\n");
                Error = workInfoFileAll.InfoFileALL();
            }
            else if (PRK == "3")
            {
                WorkInfoFileDate workInfoFileDate = new WorkInfoFileDate();
                Console.WriteLine("\nПРОСМОТР РАСПИСАНИЙ ПО ДАТЕ\n");
                Console.Write("Дата расписания: ");
                string? Date = Console.ReadLine();
                Error = workInfoFileDate.InfoFileDate(Date);
            }
            else if (PRK == "4")
            {
                WorkInfoFileType workInfoFileType = new WorkInfoFileType();
                Console.WriteLine("\nПРОСМОТР РАСПИСАНИЙ ПО ТИПУ\n");
                Console.Write("Тип расписания: ");
                string? Type = Console.ReadLine();
                Error = workInfoFileType.InfoFileType(Type);
            }
            else if (PRK == "5")
            {
                WorkInfoFileCount workInfoFileCount = new WorkInfoFileCount();
                Console.WriteLine("\nПРОСМОТР КОЛИЧЕСТВА РАСПИСАНИЙ\n");
                Error = workInfoFileCount.InfoFileCount();
            }
            else if (PRK == "6")
            {
                WorkInfoFilePerson workInfoFilePerson = new WorkInfoFilePerson();
                Console.WriteLine("\nПРОСМОТР РАСПИСАНИЙ ПО ПОЛЬЗОВАТЕЛЯМ\n");
                Console.Write("Участник расписания: ");
                string? Person = Console.ReadLine();
                Error = workInfoFilePerson.InfoFilePerson(Person);
            }
            else if (PRK == "7")
            {
                WorkInfoFileOrganizer workInfoFileOrganizer = new WorkInfoFileOrganizer();
                Console.WriteLine("\nПРОСМОТР РАСПИСАНИЙ ПО ОРГАНИЗАТОРАМ\n");
                Console.Write("Идентификатор расписания: ");
                string? Organaizer = Console.ReadLine();
                Error = workInfoFileOrganizer.InfoFileOrganizer(Organaizer);
            }
            else
            {
                Console.WriteLine("Ввод некоректного числа");
            }
        }

        internal void P_Interface_Glavn()
        {
            Console.Write("1 - Добавление в расписание\n" +
                "2 - Очистка расписания\n" +
                "3 - Изменение в расписании\n" +
                "4 - Вывод информации по расписанию\n" +
                "Ваш выбор: ");

            string? PRK = Console.ReadLine(); // переключатель
            int Error = 1; // проверка на ошибку

            if (PRK == "1") // добавление в расписание
            {
                WorkFileAdd workFileAdd = new WorkFileAdd();
                Console.WriteLine("\nДОБАВЛЕНИЕ В РАСПИСАНИЕ\n");
                Console.Write("Название расписания: ");
                string? Title = Console.ReadLine();
                Console.Write("Тип расписания: ");
                string? Type = Console.ReadLine();
                Console.Write("Дата: ");
                string? Date = Console.ReadLine();
                Console.Write("Место: ");
                string? Position = Console.ReadLine();
                Console.Write("Участник: ");
                string? Person = Console.ReadLine();
                Console.Write("Организатор: ");
                string? Organizer = Console.ReadLine();
                Error = workFileAdd.AddFile(Title, Type, Date, Position, Person, Organizer);
            }
            else if (PRK == "2") // очистка расписания
            {
                WorkDeleteFile workDeleteFile = new WorkDeleteFile();
                Error = workDeleteFile.DeleteFile();
                Console.WriteLine("\nРАСПИСАНИЕ ОЧИЩЕНО");

            }
            else if (PRK == "3") // изменение расписания
            {
                WorkUpdateFile workUpdateFile = new WorkUpdateFile();
                Console.WriteLine("\nИЗМЕНЕНИЕ РАСПИСАНИЯ\n");
                Console.Write("Идентификатор расписания: ");
                string? ID = Console.ReadLine();
                Console.Write("Название расписания: ");
                string? Title = Console.ReadLine();
                Console.Write("Тип расписания: ");
                string? Type = Console.ReadLine();
                Console.Write("Дата: ");
                string? Date = Console.ReadLine();
                Console.Write("Место: ");
                string? Position = Console.ReadLine();
                Console.Write("Участник: ");
                string? Person = Console.ReadLine();
                Console.Write("Организатор: ");
                string? Organizer = Console.ReadLine();
                Error = workUpdateFile.UpdateFile(ID,Title,Type,Date,Position,Person,Organizer);
            }
            else if (PRK == "4")
            {
                P_Interface_Info(ref Error);
            }
            else
            {
                Console.WriteLine("Ввод некоректного символа");
            }
            if (Error == 0)
            {
                Console.WriteLine("Error -_-");
            }
        } 
        public void GlavMetod()
        {
            P_Interface_Glavn();
        }
    }
}
