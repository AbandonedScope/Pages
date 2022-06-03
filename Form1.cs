namespace Pages
{
    public partial class Form1 : Form
    {
        public static int counter = 0;
        public Form1()
        {
            InitializeComponent();
            OperatingSystem.LoadProccess();
            updateGrid();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            counter++;
            long address = int.Parse(vAddresInput.Text);
            string readWrite = rmInput.Text;
            bool write = true;
            if (readWrite == "Read")
            {
                write = false;
            }

            string algorithm = algorithmInput.Text;
            bool isRNU = false;
            if (algorithm == "NRU") { isRNU = true; }
            OperatingSystem.setAlgorithm(isRNU);
                int phisAddress = Proccess.Address(address, write);
                Thread.Sleep(50);
                updateGrid();
                Thread.Sleep(50);
            PageFrameNumberL.Text = (phisAddress / OperatingSystem._pageSize).ToString();
            PAddressL.Text = phisAddress.ToString();
            if (counter == 4)
            {
                foreach(var page in OperatingSystem._ram.Ram)
                {
                    if (page != null)
                    {
                        page.R = false;
                    }
                }
                counter = 0;
            }
        }

        void updateGrid()
        {
            RAMGrid.Rows.Clear();
            PTGrid.Rows.Clear();
            for (int i = 0; i < Proccess.VirtualPages.Length; i++)
            {
                var page = Proccess.VirtualPages[i];
                var startAdr = i * OperatingSystem._pageSize;
                var endAdr = (i + 1) * OperatingSystem._pageSize - 1;
                bool presenceBit = OperatingSystem._MMU.getPresenceBitByVirtIndex(i);
                long address = OperatingSystem._MMU._table.GetPage(i).PageBlockAddress;
                PTGrid.Rows.Add(i, startAdr + "..." + endAdr, presenceBit ? 1 : 0, address, page.R ? 1 : 0, page.M ? 1 : 0);
            }

            for (int i = 0; i < OperatingSystem._ram.Ram.Length; i++)
            {
                var page = OperatingSystem._ram.Ram[i];
                string id = page == null ? "" : page.Id.ToString();
                RAMGrid.Rows.Add(i, id);
            }
        }
    }
}