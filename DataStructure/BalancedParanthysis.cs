using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class BalancedParenthysis
    {
        public void ReadFile5(string filePath)
        {
            LinkedListStack2<string> listStack2 = new LinkedListStack2<string>();
            string readDaata = File.ReadAllText(filePath);
            string[] words = readDaata.Split(" ");
            foreach (var data in words)
            {
                if (data.Equals("("))
                    listStack2.Push(data);
                if (data.Equals(")"))
                    listStack2.Pop();
            }
            listStack2.Peak();
        }
    }
}

