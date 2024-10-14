using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExDemoBuilder.Entities
{
    internal class Commennt
    {

        public string Text { get; set; }

        public Commennt()
        {

        }


        public Commennt(string text)
        {
            Text = text;
        }
    }
}
