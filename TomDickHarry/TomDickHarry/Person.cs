using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace TomDickHarry
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }

        public void savetoFile()
        {

            string FileName = @"D:/test.txt";

            //StreamWriter writer = new StreamWriter(FileName, append: true);
            //writer.Close();

       

            using (StreamWriter sw = File.AppendText(FileName))
            {
                sw.Write(Environment.NewLine);
                sw.Write("{0},{1},{2}", FirstName, LastName, JobTitle);
               

            }

        }
    }
}
