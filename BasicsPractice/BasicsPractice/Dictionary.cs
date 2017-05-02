using System;
using System.Collections.Generic;

namespace BasicsPractice
{
    internal class Dictionary
    {
        public static void Main1(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            List<string> output = new List<string>();

            try
            {
                GetInput(phoneBook, output);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }

        private static void GetInput(Dictionary<string, string> phoneBook, List<string> output)
        {
            int count = Convert.ToInt32(Console.ReadLine());
            while (count != 0)
            {
                string input = Console.ReadLine();
                string name = input.Split(' ')[0];
                string phoneNumber = input.Split(' ')[1];
                phoneBook.Add(name, phoneNumber);
                count--;
            }

            while (true)
            {
                string lookUpName = Console.ReadLine();
                if (string.IsNullOrEmpty(lookUpName))
                    break;
                string phone;
                try
                {
                    phone = phoneBook[lookUpName];
                    output.Add(lookUpName + "=" + phone);
                }
                catch (KeyNotFoundException)
                {
                    output.Add("Not found");
                }
            }
        }
    }
}