using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetExtensionMethodsApp
{
    internal partial class User
    {
        public string Name { set; get; }
        public partial void PrintName();

        public void Print()
        {
            PrintName();
        }
    }
}
