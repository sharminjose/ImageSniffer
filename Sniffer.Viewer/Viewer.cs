﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sniffer.Viewer
{
    public partial class Viewer : Form
    {        
        public Viewer()
        {
            InitializeComponent();
        }

        private void ShowChildPage(Form form)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }

            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void dicomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new DicomViewer();
            ShowChildPage(form);
        }

        private void hL7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new HL7Viewer();
            ShowChildPage(form);
        }
    }
}
