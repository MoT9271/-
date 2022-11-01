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
        public void button1_Click(object sender, EventArgs e)
        {
            int a;
            if (int.TryParse(textBox1.Text, out a) && a > 0){
                
                Note.Date.RemoveAt(a-1);
                Note.FullName.RemoveAt(a - 1);
                Note.MarkAuto.RemoveAt(a - 1);
                Note.NumberAuto.RemoveAt(a - 1);
                Note.Price.RemoveAt(a - 1);
                Note.TypeWork.RemoveAt(a - 1);
                Note.CorruptName.RemoveAt(a - 1);
                Close();
            }
            
        }
        
    }

}
