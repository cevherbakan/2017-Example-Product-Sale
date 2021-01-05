using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomasyon
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

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox txt = new TextBox();
            txt.Text = "merhaba";
            txt.Height = 60;
            txt.Width = 120;
            txt.Location = new System.Drawing.Point(200, 36);
            txt.Clear();
            this.Controls.Add(txt);
            Form2 frm2 = new Form2();
            frm2.MdiParent = this;
            frm2.Show();
            
        }
    }
}
