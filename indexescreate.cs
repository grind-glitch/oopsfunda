using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsfunda
{
    internal class indexescreate
    {
        private string[] names = new string[3];

        public string this[int index]
        {
            get { return names[index]; } //special properties. for indexes exclusively
            set { names[index] = value; }
        }
    }
}
