namespace Pages
{
    public static class OperatingSystem
    {
        public static int _virtualSpaceSize = 65536;
        public static int _pageSize = 4096;
        public static MemoryManagmentUnit _MMU = new MemoryManagmentUnit(_virtualSpaceSize, _pageSize);
        public static RAM _ram = new RAM(8);
        private static bool isNRUAlg;

        public static void LoadProccess()
        {
            foreach (var smt in Proccess.VirtualPages)
            {
                HDD.Save(smt);
            }
        }

        public static int addressOnVirtualProcessAddress(int address, bool Writing)
        {
            int phisicalAddress;
            while (true)
            {
                phisicalAddress = _MMU.ConvetVirtualToPhisical(address);
                if (phisicalAddress == -1)
                {
                    writeToRam(address / _pageSize);
                }
                else
                {
                    Proccess.VirtualPages[address / _pageSize].R = true;
                    Proccess.VirtualPages[address / _pageSize].M = Writing;
                    break;
                }
            }

            return phisicalAddress;
        }

        private static void writeToRam(int newPageIndex)
        {
            int index = _ram.FirstEmpty();
            if (index == -1)
            {
                int oddVirtualPageIndex = findOdd();
                int oddPhisicalAddress = _MMU.getRAMIndexByVirtualIndex(oddVirtualPageIndex);
                _MMU.setProcessPageUnloaded(oddVirtualPageIndex);
                index = oddPhisicalAddress;
            }

            _MMU.setProcessPageLoaded(newPageIndex, index);
            _ram.addRange(index, HDD.getPageById(newPageIndex));
        }

        private static int findOdd()
        {
            if (isNRUAlg)
            {
                return oddVirtualPageId();
            } else
            {
                return fifoOdd();
            }
        }

        private static int oddVirtualPageId()
        {
            int index = -1;
            var result = Proccess.VirtualPages[0];
            int level = 4;
            for (int i = 0; i < Proccess.VirtualPages.Length; i++)
            {
                var page = Proccess.VirtualPages[i];
                if (_MMU.getPresenceBitByVirtIndex(i))
                {
                    bool isWrited = page.M;
                    bool isReaded = page.R;
                    if (!isReaded && !isWrited)
                    {
                        level = 0;
                        result = page;
                        index = i;
                        break;
                    }
                    else if (!isReaded && isWrited)
                    {
                        if (level > 1)
                        {
                            level = 1;
                            result = page;
                            index = i;
                        }
                    }
                    else if (isReaded && !isWrited)
                    {
                        if (level > 2)
                        {
                            level = 2;
                            result = page;
                            index = i;
                        }
                    }
                    else if (isReaded && isWrited && level > 3)
                    {
                        level = 3;
                        result = page;
                        index = i;
                    }
                }
            }
            if (result.M && index != -1)
            {
                saveToHDD(result);
            }
            return index;
        }

        public static int fifoOdd()
        {
            if (_ram.Ram[0].M)
            {
                saveToHDD(_ram.Ram[0]);
            }

            for (int i = 1; i < _ram.Ram.Length; i++)
            {
                _ram.Ram[i - 1] = _ram.Ram[i]; 
            }

            return _ram.Ram.Length - 1;
        }

        private static void saveToHDD(Page page)
        {
            page.M = false;
            page.R = false;
            HDD.Save(page);
        }

        public static void setAlgorithm(bool isNRU)
        {
            isNRUAlg = isNRU;
        }
    }
}
