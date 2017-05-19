using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsPractice
{
    public class ReadMSG
    {
        static void MainR(string[] args)
        {
            var path = @"C:\Users\rajeshm\AppData\Roaming\Skype\My Skype Received Files\FW WO0000000433082.msg";
            string content = File.ReadAllText(path);
        }
    }
}
