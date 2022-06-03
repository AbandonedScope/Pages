namespace Pages
{
    public class MemoryManagmentUnit
    {
        public PageTable _table;
        private int _pageSize;

        public MemoryManagmentUnit(int virtualAddressSpaceSize, int pageSize)
        {
            _pageSize = pageSize;
            _table = new PageTable(virtualAddressSpaceSize/pageSize);
        }

        public int ConvetVirtualToPhisical(int virtualAddress)
        {
            int addressWithinPage = virtualAddress % _pageSize;
            int pageIndex = virtualAddress / _pageSize;
            var page = _table.GetPage(pageIndex);
            if (!page.PresenceBit)
            {
                return -1;
            }

            int phisicalAddress = page.PageBlockAddress * _pageSize + addressWithinPage;
            return phisicalAddress;
        }

        public void setProcessPageLoaded(int pageIndex, int phisicalAddress)
        {
            _table.setLoaded(pageIndex, phisicalAddress);
        }

        public void setProcessPageUnloaded(int pageIndex)
        {
            _table.setUnloaded(pageIndex);
        }

        public int getRAMIndexByVirtualIndex(int id)
        {
            return _table.GetPage(id).PageBlockAddress;
        }

        public bool getPresenceBitByVirtIndex(int index)
        {
            return _table.GetPage(index).PresenceBit;
        }
    }


}
