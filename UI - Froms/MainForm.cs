﻿using Dom.Composite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI___Froms
{
    public partial class MainForm : Form
    {
        private static readonly MainForm _instance = new MainForm();
        public ObjetoZ objetoZ { get; set; }
        public static MainForm Instance {
            get 
            {
                return _instance;
            }
        }
        private MainForm()
        {
            InitializeComponent();
        }
        private void btnAddObject_Click(object sender, EventArgs e)
        {

        }
    }
}
