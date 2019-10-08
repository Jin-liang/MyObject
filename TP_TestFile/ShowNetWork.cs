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
    public partial class ShowNetWork : Form
    {

        Form1 _Form1;
        public ShowNetWork()
        {
            InitializeComponent();
        }

        private void ShowNetWork_Load(object sender, EventArgs e)
        {

        }

        public void LoadSetting(object _obj)
        {
            _Form1 = _obj as Form1;

           this.txtPort.Text= _Form1.ENetWork[0];
           this.txtIPAddress.Text = _Form1.ENetWork[1];
           this.txtNetwort.Text = _Form1.ENetWork[2];
           this.txtGatewayIPAddress.Text = _Form1.ENetWork[3];
           this.txtServerIPAddress.Text = _Form1.ENetWork[4];
           this.txtFileSubfolder.Text = _Form1.ENetWork[5];
           this.checkBox1.Checked = _Form1.ENetWork[5] == "1" ? true : false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _Form1.ENetWork[0] = this.txtPort.Text;
            _Form1.ENetWork[1] = this.txtIPAddress.Text;
            _Form1.ENetWork[2] = this.txtNetwort.Text;
            _Form1.ENetWork[3] = this.txtGatewayIPAddress.Text;
            _Form1.ENetWork[4] = this.txtServerIPAddress.Text;
            _Form1.ENetWork[5] = this.txtFileSubfolder.Text;
            _Form1.ENetWork[6] = this.checkBox1.Checked==true ?"1":"0";
            this.Close();
        }
    }
}
