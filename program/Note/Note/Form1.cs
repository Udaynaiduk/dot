namespace Note
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.ShowDialog();
            StreamReader r=new StreamReader(o.FileName);
            textBox1.Text = r.ReadToEnd();
            r.Close();


        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog();
            s.ShowDialog();
            StreamWriter w=new StreamWriter(s.FileName);
            w.Write(textBox1.Text);
            w.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
Environment.Exit(0);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
           File.C
        }
    }
}