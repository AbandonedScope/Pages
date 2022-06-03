using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages
{
    public class PageTable
    {
        public (int PageBlockAddress, bool PresenceBit)[] _table;

        public PageTable(int size)
        {
            _table = new (int, bool)[size];
        }

        public (int PageBlockAddress, bool PresenceBit) GetPage(int index)
        {
            return _table[index];
        }

        public bool IsPresented(int index)
        {
            return _table[index].PresenceBit;
        }

        public int GetPageBlockAddress(int index)
        {
            return _table[index].PageBlockAddress;
        }

        public void setLoaded(int index, int phisAddress)
        {
            _table[index] = (phisAddress, true);
        }

        public void setUnloaded(int index)
        {
            _table[index] = (default(int), false);
        }
    }
}
