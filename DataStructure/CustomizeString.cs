using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class CustomizeString
    {
        public void Customize()
        {
            string line = "Hello <<name>>, We have your full nname as <<full name>> in our system. your contact number is 91-xxxxxxxxxx.";
            line = line.Replace("<<name>>", "Vaibhav");
            line = line.Replace("<<full name>>", "Vaibhav Ovhal");
            line = line.Replace("91-xxxxxxxxxx", "91-9340596362");
            Console.WriteLine(line);

        }
    }
}
