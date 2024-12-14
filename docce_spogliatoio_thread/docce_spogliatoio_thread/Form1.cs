using System.Timers;

namespace docce_spogliatoio_thread
{
    public partial class Form1 : Form
    {
        private Doccia doccia01;
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            doccia01 = new Doccia("Doccia1");
        }

        private void doccia1_Click(object sender, EventArgs e)
        {
            doccia01.UsaDoccia(10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            

        }
        private void provaT_Click(object sender, EventArgs e)
        {

        }
    }
}
