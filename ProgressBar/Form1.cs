namespace ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
   
        private void button1_Click_1(object sender, EventArgs e)
        {
            //progressBar -> Barra de progresso
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0; 

            timer1.Enabled = true; 
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Enabled = false; 
                MessageBox.Show("Download concluído! XD");
            }
            else
            {
                progressBar1.Value++;
            }
          
        }
    }
}