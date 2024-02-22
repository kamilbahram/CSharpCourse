using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadingDemo
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
        // Asekraon proğramlamada bir thread de aynı anda ik işlem yapılabiliyor.
        // sekron proğramlamada işlem1 bitmeden işlem iki yapılamıyor. tabii burda durumlar fark
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşem2 çalıştı...");
        }

        private void btnProcess1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İşem1 çalıştı...");
        }
    }
}
