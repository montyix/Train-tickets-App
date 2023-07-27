using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Train_Ticket
{
    class FileEdit
    {
        static public void save(String fileofname, String inputstr)
        {
            StreamWriter writefile = new StreamWriter(fileofname, true, Encoding.Unicode);
            writefile.WriteLine(inputstr);
            writefile.Close();
        }
        static public string open(String fileofname)
        {
            string Text = string.Empty;
            StreamReader readfile = new StreamReader(fileofname);
            while(!readfile.EndOfStream)
            {
                Text += readfile.ReadLine();
            }
            readfile.Close();
            return Text;
        }

    }
}
