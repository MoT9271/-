﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            
=======
            Note.FullName.Add(FullNameBox.Text);
            Note.MarkAuto.Add(MarkAutoBox.Text);
            Note.Date.Add(Convert.ToString(DateBox.Text));
            Note.CorruptName.Add(TypeCorruptBox.Text);
            Note.Price.Add(PriceBox.Text);
            Note.NumberAuto.Add(NumberAutoBox.Text);
            Note.TypeWork.Add(TypeWorkBox.Text);

>>>>>>> 344c63ae28c02b899d900c98a9540f46e8e86d92
        }
    }
}
