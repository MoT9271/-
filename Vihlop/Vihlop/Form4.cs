using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vihlop
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Note.FullName.Count; i++)
            {
                textBox1.Text += "Заказ №" + (i + 1) + "\r\n";
                textBox1.Text += Note.FullName[i] + "\r\n";
                textBox1.Text += Note.MarkAuto[i] + "\r\n";
                textBox1.Text += Note.TypeWork[i] + "\r\n";
                textBox1.Text += Note.NumberAuto[i] + "\r\n";
                textBox1.Text += Note.Price[i] + "\r\n";
                textBox1.Text += Note.Date[i] + "\r\n";
                textBox1.Text += "---------------------------------\r\n";
            }
        }
    }
}
