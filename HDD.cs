using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages
{
    public static class HDD
    {
        public static List<Page> Pages = new List<Page>();

        public static void Save(Page page)
        {
            if (Pages.FirstOrDefault(p => p.Id == page.Id) != null)
            {
                Pages.Remove(page);
            }

            Pages.Add(page);
        }

        public static Page getPageById(int id)
        {
            return Pages.FirstOrDefault(p => p.Id == id);
        }
    }
}
