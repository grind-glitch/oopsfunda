using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsfunda
{
    internal class account
    {
        public string account_name;
        public int account_id;
        public static float ROI=5.5f;
        public static int count;

        static account()
        {
            count = 0;
        }
        public account(string name, int id)
        {
            account_name = name;
            account_id = id;
            count++;

        }

        public void display()
        {
            Console.WriteLine("Account Name: {0}", account_name);
            Console.WriteLine("Account ID: {0}", account_id);
            Console.WriteLine("Rate of Interest: {0}", ROI);

        }

    }
}
