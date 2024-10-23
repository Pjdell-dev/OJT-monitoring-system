namespace navbar
{
    public partial class Form1 : Form
    {
        FormHome Home;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 69)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                    
                   
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 307)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                   
                    

                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
           