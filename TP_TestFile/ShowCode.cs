using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TP_TestFile
{
    public partial class ShowCode : Form
    {
        public ShowCode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
//            Trigger-None
//Trigger-Test Only
//Trigger-Test +Reflsh
            this.Close();
        }

        public int sget()
        {
            int ip = 0;
            if (comboBox2.Text == "Trigger-None")
            {
                ip = 0;
            }
            if (comboBox2.Text == "Trigger-Test Only")
            {
                ip = 1;
            }
            if (comboBox2.Text == "Trigger-Test +Reflsh")
            {
                ip = 2;
            }
            return ip;
        }
    }
}
