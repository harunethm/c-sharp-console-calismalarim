using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace butonControlDeneme
{
    public partial class Form1 : Form
    {
        public int[] dizi = new int[5];
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = dizi.Length.ToString();
        }

        private void deneme(object sender, EventArgs e)
        {
            Button buton = (Button)sender;
            Button btn = (Button)(this.Controls.Find(buton.Name, true)[0]);
            btn.BackColor = Color.Red;
            label1.Text = buton.Name;
        }

    }
}
