﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll_UnitTest.AddDelUpd
{
    public class WorkDeleteFile
    {
        public int DeleteFile()
        {
            try
            {
                File.Delete("Расписание.txt"); // очистка файла
                File.Create("Расписание.txt");
                return 1;
            }
            catch
            {
                return 0;
            } 
        }
    }
}
