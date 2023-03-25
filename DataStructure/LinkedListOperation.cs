using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class LinkedListOperation
    {
        public void ReadFile2(string filePath)
        {
            LinkedList2<string> list = new LinkedList2<string>();
            string readData = File.ReadAllText(filePath);
            string[] words = readData.Split(" ");
            foreach (var data in words)
            {
                list.Add(data);
            }
            string input = Console.ReadLine();
            int result = list.Search(input);
            if (result != -1)
            {
                Console.WriteLine("Found");
                list.DeleteNodeAtParticularPosition(result);
            }
            else
            {
                list.Add(input);
            }
            list.Display();
        }
    }
}

