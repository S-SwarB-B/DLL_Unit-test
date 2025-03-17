using Xunit;
using Dll_UnitTest.AddDelUpd;
using Dll_UnitTest.InfoFile;

namespace Dll_UnitTest.Test
{
    public class TestDll
    {
        [Fact]
        public void TestAddFile() //Тестирование добавления расписания
        {
            WorkFileAdd workFileAdd = new WorkFileAdd();
            int expected = 1;
            int actual = workFileAdd.AddFile("","","","","","");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDeleteFile() //Тестирование удаления расписания
        {
            WorkDeleteFile workFileDel = new WorkDeleteFile();
            int expected = 1;
            int actual = workFileDel.DeleteFile();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestUpdateFile() //Тестирование обновления расписания
        {
            WorkUpdateFile workFileUpd = new WorkUpdateFile();
            int expected = 1;
            int actual = workFileUpd.UpdateFile("1","","","","","","");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestInfoFileID() //Тестирование вывода расписаний по ID
        {
            WorkInfoFileID workInfoFileID = new WorkInfoFileID();
            int expected = 1;
            int actual = workInfoFileID.InfoFileID("1");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestInfoFileAll() //Тестирование вывода всех расписаний
        {
            WorkInfoFileAll workInfoFileAll = new WorkInfoFileAll();
            int expected = 1;
            int actual = workInfoFileAll.InfoFileALL();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestInfoFileDate() //Тестирование вывода расписаний по дате
        {
            WorkInfoFileDate workInfoFileDate = new WorkInfoFileDate();
            int expected = 1;
            int actual = workInfoFileDate.InfoFileDate("Сегодня");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestInfoFileType() //Тестирование вывода расписаний по типу
        {
            WorkInfoFileType workInfoFileType = new WorkInfoFileType();
            int expected = 1;
            int actual = workInfoFileType.InfoFileType("Починка");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestInfoFileCount() //Тестирование вывода количества расписаний
        {
            WorkInfoFileCount workInfoFileCount = new WorkInfoFileCount();
            int expected = 1;
            int actual = workInfoFileCount.InfoFileCount();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestInfoFilePerson() //Тестирование вывода расписаний по участникам
        {
            WorkInfoFilePerson workInfoFilePerson = new WorkInfoFilePerson();
            int expected = 1;
            int actual = workInfoFilePerson.InfoFilePerson("Я");

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestInfoFileOrganizer() //Тестирование вывода расписаний по организаторам
        {
            WorkInfoFileOrganizer workInfoFileOrganizer = new WorkInfoFileOrganizer();
            int expected = 1;
            int actual = workInfoFileOrganizer.InfoFileOrganizer("Дедушка");

            Assert.Equal(expected, actual);
        }
    }
}
