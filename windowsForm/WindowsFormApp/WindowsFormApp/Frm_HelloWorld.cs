﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormApp
{
    public partial class Frm_HelloWorld : Form
    {
        public Frm_HelloWorld()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Btn_ModificarLbl_Click(object sender, EventArgs e)
        {
            lbl_Titulo.Text = Txt_ConteudoLabel.Text;
            
        }
    }
}
