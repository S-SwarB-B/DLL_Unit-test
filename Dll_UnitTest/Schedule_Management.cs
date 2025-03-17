using Dll_UnitTest.AddDelUpd;

namespace Dll_UnitTest
{
    public class GlavWorkFile
    {   
        internal void P_Interface_Info(ref int Error)
        {
            Console.Write("\n\n1 - Вывод расписаний по ID\n" +
                "2 - Вывод всех расписаний\n" +
                "3 - Вывод расписаний по дате\n" +
                "4 - Вывод информации по расписаниям\n" +
                "5 - Вывод расписания по типу\n" +
                "6 - Вывод количества расписаний\n" +
                "7 - Вывод расписаний по участникам\n" +
                "8 - Вывод расписаний по организаторам\n" +
                "Ваш выбор: ");
            string PRK = Console.ReadLine(); // переключатель
            if (PRK == "1")
            {

            }
            else if (PRK == "2")
            {

            }
            else if (PRK == "3")
            {

            }
            else if (PRK == "4")
            {

            }
            else if (PRK == "5")
            {

            }
            else if (PRK == "6")
            {

            }
            else if (PRK == "7")
            {

            }
            else if (PRK == "8")
            {

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

            string PRK = Console.ReadLine(); // переключатель
            int Error = 1; // проверка на ошибку

            if (PRK == "1") // добавление в расписание
            {
                WorkFileAdd workFileAdd = new WorkFileAdd();
                Console.WriteLine("\nДОБАВЛЕНИЕ В РАСПИСАНИЕ\n");
                Console.Write("Название расписания: ");
                string Title = Console.ReadLine();
                Console.Write("Тип расписания: ");
                string Type = Console.ReadLine();
                Console.Write("Дата: ");
                string Date = Console.ReadLine();
                Console.Write("Место: ");
                string Position = Console.ReadLine();
                Error = workFileAdd.AddFile(Title, Type, Date, Position);
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
                string ID = Console.ReadLine();
                Console.Write("Название расписания: ");
                string Title = Console.ReadLine();
                Console.Write("Тип расписания: ");
                string Type = Console.ReadLine();
                Console.Write("Дата: ");
                string Date = Console.ReadLine();
                Console.Write("Место: ");
                string Position = Console.ReadLine();
                Error = workUpdateFile.UpdateFile(ID,Title,Type,Date,Position);
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
