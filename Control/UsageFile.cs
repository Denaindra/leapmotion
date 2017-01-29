using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandMotion.Control
{
    public class UsageFile
    {
        private static UsageFile instance;

        public UsageFile()
        {

        }
        public static UsageFile getinstance()
        {
            instance = new UsageFile();
            return instance;
        }
        public void WriteFile()
        {
            try
            {
                StreamWriter file = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\" + "swaps.txt", true);
                file.WriteLine(DateTime.Now);
                file.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
