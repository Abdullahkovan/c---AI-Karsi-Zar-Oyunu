using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rastgele=new Random();
        int toplamben = 0;
        int toplampc = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            int a=rastgele.Next(1,7);
            int b = rastgele.Next(1, 7);
            
            toplamben = toplamben + a + b;
            label16.Text = toplamben.ToString();
            pictureBox1.ImageLocation = "../../../zar"+a+".png";
            pictureBox2.ImageLocation = "../../../zar"+b+".png";

            label3.Text = a.ToString();
            label4.Text = b.ToString();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;

            int c = rastgele.Next(1, 7);
            int d = rastgele.Next(1, 7);

            toplampc = toplampc + c + d;
            label15.Text = toplampc.ToString();
            label9.Text = c.ToString();
            label10.Text = d.ToString();
                pictureBox1.ImageLocation = "../../../zar"+c+".png";
                pictureBox2.ImageLocation = "../../../zar"+d+".png";
            if (toplamben > 100 && toplamben > toplampc)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                
                label13.Text = "KAZANAN SİZSİNİZ TEBRİKLER";
            }
            if(toplampc>100 && toplampc>toplamben){
                label13.Text = "KAZANAN PC";
                button1.Enabled = false;
                button2.Enabled = false;

            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
