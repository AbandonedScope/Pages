using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages
{
    public static class Proccess
    {
        public static readonly int VIRTUAL_ADDRESS_SPACE_SIZE = 65536;
        public static readonly int PAGE_SIZE = 4096;
        public static Page[] VirtualPages { get; set; } 

        static Proccess()
        {
            VirtualPages = new Page[VIRTUAL_ADDRESS_SPACE_SIZE / PAGE_SIZE];
            for (int i = 0; i < VirtualPages.Length; i++)
            {
                VirtualPages[i] = new Page(PAGE_SIZE, i);
            }
        }

        public static int Address(long vAddress, bool isMod)
        {
            return OperatingSystem.addressOnVirtualProcessAddress((int)vAddress, isMod);
        }
    }
}
