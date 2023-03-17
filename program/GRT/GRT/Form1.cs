using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace GRT
{
    public partial class Form1 : Form
    {
        Customer n = null;
        Stream reader;
        IFormatter file;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void txtName_Click(object sender, EventArgs e)
        {

        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          n=new Customer(txtN.Text,txtA.Text);
            try
            {
                 file = new BinaryFormatter();
                reader= new FileStream(@"C:\Users\VMUser\program\uday1.dat",FileMode.Append,FileAccess.Write);
                file.Serialize(reader,n);
                reader.Close();
                
                
            }
            catch(Exception f)
            {
                Console.WriteLine(f.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                 file = new BinaryFormatter();
                 reader= new FileStream(@"C:\Users\VMUser\program\uday1.dat", FileMode.Open, FileAccess.Read);
                n=(Customer)file.Deserialize(reader);
                
                txtN.Text = n.Name;
                txtA.Text = n.Address;

            }
            catch(Exception v)
            {
                Console.WriteLine(v.Message);   
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
           if (reader.Position < reader.Length)
            {
                n=(Customer)file.Deserialize(reader);
                txtN.Text = n.Name;
                txtA.Text = n.Address;
            }
        }

        private void CLose_Click(object sender, EventArgs e)
        {
            reader.Close();
            Environment.Exit(0);
        }
    }
}