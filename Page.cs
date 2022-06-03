using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages
{
    public class Page
    {
        public int Id { get; }
        public int[] Addresses { get; set; }
        public bool R { get; set; }
        public bool M { get; set; }

        public Page(int size, int id)
        {
            Id = id;
            Addresses = new int[size];
        }
    }
}
