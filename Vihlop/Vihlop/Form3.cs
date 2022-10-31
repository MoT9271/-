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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            int index = int.Parse(textBox1.Text) - 1;
            Note.Date.RemoveAt(index);
            Note.FullName.RemoveAt(index);
            Note.MarkAuto.RemoveAt(index);
            Note.NumberAuto.RemoveAt(index);
            Note.Price.RemoveAt(index);
            Note.TypeWork.RemoveAt(index);
            Note.CorruptName.RemoveAt(index);
            Close();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 44 && number != 8 && number != '-')
            {
                e.Handled = true;
            }
        }
    }

}
