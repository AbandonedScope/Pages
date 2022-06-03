namespace Pages
{
    public class RAM
    {
        private int _pageSize = 4096;
        public int Size { get; }

        public Page[] Ram { get; }

        public RAM(int size)
        {
            Size = size;
            Ram = new Page[Size];
        }

        public int AddressByFullAddress(int fullPhisicalAddress)
        {
            int phisicalPageIndex = fullPhisicalAddress / _pageSize;
            int phisicalPageWithinAddress = fullPhisicalAddress % _pageSize;

            return Ram[phisicalPageIndex].Addresses[phisicalPageWithinAddress];
        }

        public void addRange(int phisizalIndex, Page page)
        {
            Ram[phisizalIndex] = page;
        }

        public int FirstEmpty()
        {
            int index = -1;
            for (int i = 0; i < Ram.Length; i++)
            {
                if (Ram[i] == null)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }
    }
}
