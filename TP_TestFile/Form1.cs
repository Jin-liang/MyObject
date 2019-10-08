using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;

using System.Text;
using System.Windows.Forms;



namespace TP_TestFile
{

    public partial class Form1 : Form
    {

        string PathApp = "";

        string UserID = "";
        Dictionary<object, string> testFlow;//测试项
        Dictionary<object, string> testAllFlow;//测试项
        List<string> testlistItem;//测试总项

        List<string> CancelKey;//取消项

        FileAI _FileAI;//文件解析

        public  string[] ENetWork;

        public string[] ECode;

        public int ecodeid = 1;
        public Form1()
        {
            InitializeComponent();

            PathApp = Application.StartupPath + "\\Build\\";


            ENetWork = new string[7];

            ECode = new string[3];

        }

        public void Loadstring()
        {

        }

        private void CFunction(object sender, EventArgs e)
        {
            Control Cotrl = sender as Control;

            switch (Cotrl.Name)
            {
                case "btnIn"://
                    OpenFileDialog fileDialog = new OpenFileDialog();
                    fileDialog.Multiselect = false;
                    fileDialog.Title = "Please Select the Config File ...";
                    fileDialog.Filter = "DSO File (*.cal)|*.cal|DSO File (*.fac)|*.fac";
                    if (fileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string file = fileDialog.FileName;
                        this.txtInput.Text = file;
                    }
                    break;
                case "btnOut"://
                    //System.Diagnostics.Process.Start("explorer", PathApp);

                    FolderBrowserDialog dialog = new FolderBrowserDialog();
                    dialog.Description = "请选择生成文件所在文件夹";
                    if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        if (string.IsNullOrEmpty(dialog.SelectedPath))
                        {
                            MessageBox.Show(this, "文件夹路径不能为空", "提示");
                            return;
                        }
                    }
                    txtOutput.Text = dialog.SelectedPath;
                    break;
                case "btnRead"://
                    if (this.txtInput.Text.Trim().Length > 0)
                    {
                        chkTestSelection.Items.Clear();
                        LoadSettings(this.txtInput.Text.Trim());
                    }
                    else
                    {
                        MessageBox.Show("Please Select File!");
                        return;
                    }
               

                    if (UserID == "1")
                    {
                        InitchkFlow();
                    }
                    else
                    {
                        btnGoShow();
                    }
                 
                   
                    break;
                case "btnGenerate"://生成二进制文件
                    if (chkFlow.Items.Count > 0)
                    {
                        CreateFile();
                        MessageBox.Show("CreateFile OK");
                    }
                    else
                    {
                        MessageBox.Show("Flow Not Null");
                    }

                    break;

                case "btnGo"://

                    //
                    break;
            }
        }

        public void btnGoShow()
        {
            if (testFlow != null)
            {
                chkFlow.Items.Clear();

                for (int i = 0; i < chkTestSelection.Items.Count; i++)
                {
                    if (chkTestSelection.GetItemChecked(i))
                    {
                        string keyR = chkTestSelection.Items[i].ToString().Split('.')[1];
                        chkFlow.Items.Add((chkFlow.Items.Count + 1).ToString() + "." + keyR, true);
                    }
                }
                for (int i = 0; i < chkTestSelection.Items.Count; i++)
                {
                    if (chkTestSelection.GetItemChecked(i))
                    {
                        string keyR = chkTestSelection.Items[i].ToString().Split('.')[1];
                        SetListItem(keyR);
                    }
                }
                RomoveID();
            }
        }

        public void RomoveID()
        {
            Dictionary<string, string> tempDic = new Dictionary<string, string>();
            string[] tempsplit;
            for (int i = 0; i < chkFlow.Items.Count; i++)
            {
                tempsplit = chkFlow.Items[i].ToString().Split('.'); 
                tempDic.Add(tempsplit[1],tempsplit[0] );
            }
            if (CancelKey != null)
            {
                foreach (string sItem in CancelKey)
                {
                    string _outVal = "";
                    if (tempDic.TryGetValue(sItem, out _outVal))
                    {
                        chkFlow.Items.Remove(_outVal+"."+sItem);
                    }
                  
                }
            }

        }

//#define TOUCH_IC		        1		//	1		0x01 - SYNA_DS4; 0x02 = SYNA_DS5; 0x03 = SYNA_DS5_10; S37XX
//#define PROTOCOL		        2		//	1		0x01 - I2C; 0X02 - SPI
//#define I2C_ADDR		        3		//	2		Byte0 - Hi; Byte1 - Lo (8bit I2C Address);when protocol is SPI, I2C_ADDR reused as SPI mode.
//#define I2C_SPEED		        4		//	2		0d100 -> 100K; 0d400 -> 400K
//#define TEST_SELECT		        10		//	?{12}	Byte0 - Number of Test Cases {11}, Byte1 ~ {Byte11} - Test Bin //Eg..binNum[11]={0,26,27,30,23,13,3,7,10,5,12};
//#define D2_TX_NUMBER		        50		//	1	TX active Number
//#define D2_RX_NUMBER		        51		//	1	RX active Number
//#define D0_TX_NUMBER		        52		//	1	TX active Number
//#define D0_RX_NUMBER		        53		//	1	RX active Number
//#define RX_ASSIGNMENT	            54		//	?	Byte0 - No_Of_Rx_Electrodes, Byte1 - No_Of_Rx_Assigned, Byte 2 ~ Byten (determined by byte 1)
//#define TX_ASSIGNMENT	            55		//	?	Byte0 - No_Of_Tx_Electrodes, Byte1 - No_Of_Tx_Assigned, Byte 2 ~ Byten (determined by byte 1)
     public int TOUCH_IC = 1;
     public int PROTOCOL = 2;
     public int I2C_ADDR = 3;

     public int I2C_SPEED = 4;
     public int TEST_SELECT = 10;
     public int D2_TX_NUMBER = 50;
     public int D2_RX_NUMBER = 51;
     public int D0_TX_NUMBER = 52;
     public int D0_RX_NUMBER = 53;
     public int RX_ASSIGNMENT = 54;
     public int TX_ASSIGNMENT = 55;
     public int EnableTestLog = 70;
     public int END_OF_FILE_NEW = 60686;

     public int NET_WORK_SETTING = 78;
     public int BAR_CODE_SETTING = 76;
        public void CreateFile()
        {
          
            Dictionary<int, object> _Val = new Dictionary<int, object>();
            
            _Val.Add(TOUCH_IC, chbTouch.SelectedIndex);
            _Val.Add(PROTOCOL, chbProtocol.SelectedIndex);
            _Val.Add(I2C_ADDR, (int)numericUpDown1.Value);
            _Val.Add(I2C_SPEED, int.Parse(txtI2CSpeed.SelectedItem.ToString()));

            _Val.Add(TEST_SELECT, GetTestSelect());
            int drx = (int)int2DRx_Number.Value;
            int dtx = (int)int2DTx_Number.Value;
            int rx = (int)intRx_Number.Value;
            int tx = (int)intTx_Number.Value;

            _Val.Add(D2_TX_NUMBER, dtx);//16
            _Val.Add(D2_RX_NUMBER, drx);//36
            _Val.Add(D0_TX_NUMBER, 0);//0
            _Val.Add(D0_RX_NUMBER, 0);//0
            _Val.Add(RX_ASSIGNMENT, GetTxRxAssigments((byte)drx,(byte)drx));//36
            _Val.Add(TX_ASSIGNMENT, GetTxRxAssigments((byte)dtx, (byte)dtx));//16

            for(int i=0;i<checkedListBox2.Items.Count;i++)
            {
                if(checkedListBox2.Items[i].ToString() ==  "Enable Test Log")
                {
                    _Val.Add(EnableTestLog, checkedListBox2.GetItemChecked(i)  == true ? 1 : 0);//0
                }

                if (checkedListBox2.Items[i].ToString() == "Enable Networtk")
                {
                    byte[] getNetwork = new byte[20];
                    getNetwork[0] = (byte)(checkedListBox2.GetItemChecked(i) == true ? 1 : 0);
                    getNetwork[1] = (byte)(int.Parse(ENetWork[6]));
                    byte[] _bys = BitConverter.GetBytes((ushort)int.Parse(ENetWork[0]));
                    getNetwork[2] = _bys[1];
                    getNetwork[3] = _bys[0];

                     _bys = Getstrings();

                     int f = 4;
                     for (int m = 0; m < _bys.Length;m++ )
                     {
                         getNetwork[f] = _bys[m];
                         f++;
                     }

                      _Val.Add(NET_WORK_SETTING, getNetwork);//0
                }

               // System.Runtime.Remoting.Contexts.Context.
            }
            byte[] tempbys = new byte[4];
            tempbys[0] = (byte)(radioButton2.Checked == true ? 1 : 0);
            tempbys[1] = (byte)0;
            tempbys[2] = (byte)10;
            tempbys[3] = (byte)ecodeid;


            _Val.Add(BAR_CODE_SETTING, tempbys);//0
          
            List<byte> _arrlists = new List<byte>();
            foreach (int skey in _Val.Keys)
            {   byte[] CreateBy;
                byte[] _by;
                if ((skey == TEST_SELECT) || (skey == RX_ASSIGNMENT) || (skey == TX_ASSIGNMENT) || (skey == NET_WORK_SETTING) || (skey == BAR_CODE_SETTING))
                {
                    _by = (byte[])_Val[skey];

                }
                else if ((skey == I2C_ADDR) || (skey == I2C_SPEED))//2bytes
                {

                    _by = BitConverter.GetBytes((ushort)(int)_Val[skey]);
                    Array.Reverse(_by); // 反转
                }
                else
                {
                    _by = BitConverter.GetBytes((byte)(int)_Val[skey]);
                }
                SetInAndOutCFGwithBCC((ushort)skey, _by, out  CreateBy);
                for(int i=0;i<CreateBy.Length;i++)
                {
                    _arrlists.Add(CreateBy[i]);
                }
            }
            List<string> tempFlowName = new List<string>();
            string[] tempsplit;
            for (int i = 0; i < chkFlow.Items.Count; i++)
            {
                if (chkFlow.GetItemChecked(i))
                {
                    tempsplit = chkFlow.Items[i].ToString().Split('.'); ;
                    tempFlowName.Add(tempsplit[1].ToUpper());
                }
            }
            
            if(_FileAI !=null)
            {
                foreach(string sky in _FileAI._testItem.Keys)
                {

                    if (tempFlowName.Contains(sky.ToUpper()))
                    {
                        byte[] CreateBys = new byte[2];
                        foreach (string skey in (List<string>)_FileAI._testItem[sky])
                        {
                            GetKeysP(skey, out CreateBys);
                            for (int i = 0; i < CreateBys.Length; i++)
                            {
                                _arrlists.Add(CreateBys[i]);
                            }
                        }
                    }
                }
            }

            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(txtOutput.Text);
            di.Create();

            //Add end of file
            byte[] endofFileout;
            byte[] endoffile = {0};
            SetInAndOutCFGwithBCC((ushort)END_OF_FILE_NEW, endoffile, out  endofFileout);
            for (int i = 0; i < endofFileout.Length; i++)
            {
                _arrlists.Add(endofFileout[i]);
            }


            byte[] CreateBytes = _arrlists.ToArray();

            WriteFile(CreateBytes);//写二进制文件

            if (File.Exists(this.txtInput.Text))
            {
                FileInfo _inf = new FileInfo(this.txtInput.Text);

                string pathfile = _inf.Directory.ToString() + @"\"+txtFWFile.Text.Trim() + ".bin";

                CopyFile(pathfile, txtOutput.Text + @"\" + "fw.bin");//复制文件
            }


            System.Diagnostics.Process.Start("explorer", txtOutput.Text + @"\");

          
        }

        public byte[] Getstrings()
        {
            byte[] tempby = new byte[16];
            string[] tempstl;
            int n = 0;
            for(int i=1;i<5;i++)
            {
                tempstl = ENetWork[i].Split('.');
                tempby[n] = (byte)int.Parse(tempstl[3]);
                n++;
                tempby[n] = (byte)int.Parse(tempstl[2]);
                n++;
                tempby[n] = (byte)int.Parse(tempstl[1]);
                n++;
                tempby[n] = (byte)int.Parse(tempstl[0]);
                n++;
            }
            return tempby;
        }



        public void GetKeys(string skey,  out byte[] CreateBys)
        {
            string[] tempstrl = skey.Split('_');
            string[] tempstrsksy ;
            List<byte> tempby = new List<byte>();
            List<string> templs;
            byte[] readBy;

            byte[] _tempby;
            List<byte> _listby = new List<byte>();

           foreach(string skeys in  _FileAI.ReTestItem.Keys)
           {
               tempstrsksy = skeys.Split('~');
               if (tempstrl[0].ToUpper() == tempstrsksy[tempstrsksy.Length - 3].ToUpper()
                   && tempstrl[1].ToUpper() == tempstrsksy[tempstrsksy.Length - 2].ToUpper()
                    && tempstrl[2].ToUpper() == tempstrsksy[tempstrsksy.Length - 1].ToUpper())
               {
                   templs = _FileAI.ReTestItem[skeys];
                   for(int i =0;i< templs.Count;i++)
                   {
                       string[] stempstrl = templs[i].Split(',');
                       for(int j=0;j<stempstrl.Length;j++)
                       {
                           if(stempstrl[j].Trim() != "")
                           {
                              readBy =BitConverter.GetBytes(int.Parse(stempstrl[j].Trim()));
                              tempby.Add(readBy[3]);
                              tempby.Add(readBy[2]);
                              tempby.Add(readBy[1]);
                              tempby.Add(readBy[0]);
                           }
                       }
                   }

                   SetInAndOutCFGwithBCC(ushort.Parse(tempstrl[3]), tempby.ToArray(), out  _tempby);
                   for(int i=0;i<_tempby.Length;i++)
                   {
                       _listby.Add(_tempby[i]);
                   }
               }
              
           }
           CreateBys = _listby.ToArray();
        }

        public void GetKeysP(string skey, out byte[] CreateBys)
        {
            string[] tempstrl = skey.Split('_');
            string[] tempstrsksy;
            List<byte> tempby = new List<byte>();
            List<string> templs;
            byte[] readBy;

            byte[] _tempby;
            List<byte> _listby = new List<byte>();

            foreach (string skeys in _FileAI.ReTestItem.Keys)
            {
                string tempskeys = skeys.Replace("_", "~");
                tempstrsksy = tempskeys.Split('~');
                bool _isf = true;
                int n = 0;
                for (int i = 0; i < tempstrl.Length-1; i++)
                {
                    n = (tempstrsksy.Length - tempstrl.Length)+i+1;
                    if (tempstrl[i].ToUpper() != tempstrsksy[n].ToUpper())
                    {
                        _isf = false;
                        break;
                    }
                }
                if (_isf)
                {
                    templs = _FileAI.ReTestItem[skeys];
                    for (int i = 0; i < templs.Count; i++)
                    {
                        string[] stempstrl = templs[i].Split(',');
                        for (int j = 0; j < stempstrl.Length; j++)
                        {
                            if (stempstrl[j].Trim() != "")
                            {
                                readBy = BitConverter.GetBytes(int.Parse(stempstrl[j].Trim()));
                                tempby.Add(readBy[3]);
                                tempby.Add(readBy[2]);
                                tempby.Add(readBy[1]);
                                tempby.Add(readBy[0]);
                            }
                        }
                    }

                    SetInAndOutCFGwithBCC(ushort.Parse(tempstrl[tempstrl.Length-1]), tempby.ToArray(), out  _tempby);
                    for (int i = 0; i < _tempby.Length; i++)
                    {
                        _listby.Add(_tempby[i]);
                    }
                }

            }
            CreateBys = _listby.ToArray();
        }

        public byte[] GetTestSelect()
        {
            int count = 0;
            List<byte> _list = new List<byte>();
            for (int i = 0; i < chkFlow.Items.Count; i++)
            {
                if (chkFlow.GetItemChecked(i))
                {
                    string itemText = chkFlow.Items[i].ToString();
                    string[] itemTextSplit = itemText.Split('.');
                    _list.Add((byte)Convert.ToInt32(itemTextSplit[0]));
                    count++;
                }
            }

            _list.Insert(0, (byte)count);

            return _list.ToArray();

        }

        public byte[] GetTxRxAssigments(byte supportCount, byte assignedCount)
        {
            int count = assignedCount;
            List<byte> _list = new List<byte>();
            _list.Add(supportCount);
            _list.Add(assignedCount);
            for (byte i = 0; i < assignedCount; i++)
            {
                _list.Add(i);
            }
            return _list.ToArray();
        }

      




        public void WriteFile(byte[] FileText)
        {
            BinaryWriter bw;
        
         
            string s = "I am happy";
            // 创建文件
            try
            {
                bw = new BinaryWriter(new FileStream(this.txtOutput.Text + @"\TEST.CFG",
                FileMode.Create));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot create file.");
                return;
            }
            // 写入文件
            try
            {
                for (int i = 0; i < FileText.Length; i++)
                {
                    bw.Write(FileText[i]);
                }
                   
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot write to file.");
                return;
            }

            bw.Close();
        }

      

        public  string ToHexString(byte[] bytes) // 0xae00cf => "AE00CF "
        {
            string hexString = string.Empty;
            if (bytes != null)
            {
                StringBuilder strB = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    strB.Append(bytes[i].ToString("X2"));
                }
                hexString = strB.ToString();
            }
            return hexString;
        }

        public void CopyFile(string Old ,string NewFile)
        {
            File.Copy(Old, NewFile, true);
        }

        public void InputData(object Key )
        {

        }

        public void SetListItem(string Keys)
        {
            string tempR = "";
           if( testFlow != null)
           {
               if (testFlow.ContainsKey(Keys))
               {
                    tempR = testFlow[Keys].Split(',')[8];//取ic/bol
               }
           }
           if (tempR != "")
           {
               if (testlistItem != null)
               {
                   tempR = tempR.Replace("cb|IC_MODE|", "");
                   for (int i = 0; i < testlistItem.Count; i++)
                   {
                       if (testlistItem[i].Contains(tempR.Trim()))
                       {
                           ReadFlow(i + 1, testlistItem);
                       }
                   }
               }
           }
          
        }
        public void ReadFlow(int Index,List<string> tempList)
        {
            if (Index < tempList.Count)
            {
                if (!tempList[Index].Contains("SubPageKey"))
                {
                    string[] RValue = tempList[Index].Split(',');

                    if (IsFlow(RValue[22].Trim()))
                    {
                        chkFlow.Items.Add((chkFlow.Items.Count + 1).ToString() + "." + RValue[22], true);
                    }

                    ReadFlow(Index + 1, tempList);
                }
            }
        }

        public bool IsFlow(string skey)
        {
            List<string> _list = new List<string>();
           
            for(int i=0;i< chkFlow.Items.Count;i++)
            {
                chkFlow.Items[i].ToString().Split('.');
                _list.Add(chkFlow.Items[i].ToString().Split('.')[1]);
            }
            if(_list.Contains(skey))
            {
                return false;
            }else
            {
                 return true;
            }
          
        }

        public void LoadSettings(string _file)
        {
            _FileAI = new FileAI();
            testFlow = new Dictionary<object, string>();
            testAllFlow = new Dictionary<object, string>();
            if (System.IO.File.Exists(_file) == false)
            {
                return;
            }
            FileStream fs = new FileStream(_file, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadToEnd();//直接读取一行
            sr.Close();
            fs.Close();

            string tempsplit = "\r\n";
            string[] tempList = line.Split(tempsplit.ToCharArray());

            string srl = "";
            for (int i=0;i<tempList.Length;i++)
            {
                srl = tempList[i];
                if (srl.Trim() != "")
                {
                   if (srl.Contains("* Device_ID"))
                   {
                       string[] tempstr = srl.Split('=');
                       if(tempstr.Length>1)
                       {
                           chbTouch.SelectedItem = tempstr[1].Trim();
                       }
                   }
                   if (srl.Contains("* Is_SPI"))
                   {
                       string[] tempstr = srl.Split('=');
                       if (tempstr.Length > 1)
                       {
                           chbProtocol.SelectedItem = tempstr[1].Trim() == "F" ? "I2C" : "SPI";
                       }
                   }
                   if (srl.Contains("* New_I2C_Address"))
                   {
                       string[] tempstr = srl.Split('=');
                       if (tempstr.Length > 1)
                       {
                           numericUpDown1.Value= tempstr[1].Trim() == "" ? 0 : int.Parse(tempstr[1].Trim());
                       }
                   }

                    
                   if (srl.Contains("* Tx_Number"))
                   {
                       string[] tempstr = srl.Split('=');
                       if (tempstr.Length > 1)
                       {
                           int2DTx_Number.Value =int.Parse( tempstr[1]);
                       }
                   }
                   if (srl.Contains("* Rx_Number"))
                   {
                       string[] tempstr = srl.Split('=');
                       if (tempstr.Length > 1)
                       {
                           int2DRx_Number.Value = int.Parse(tempstr[1]);
                       }
                   }

                   if (srl.Contains("* Firmware"))
                   {
                       string[] tempstr = srl.Split('=');
                       if (tempstr.Length > 1)
                       {
                           txtFWFile.Text = tempstr[1];
                       }
                   }

                   if (srl.Contains("TestItemFlow_Start"))
                   {
                       ReadStart(i + 1, tempList);
                   }

                   if (srl.Contains("CollectAndLimitCheck_Start"))
                   {
                       testlistItem = new List<string>();
                       ReadLinitChechk(i + 1, tempList);

                   }
                }
            }
            //
            _FileAI.initTestItems();
            //文件解析
            _FileAI.GetAlist(tempList);

        }

      
        Dictionary<string ,string > tempflows;

      
        public void InitchkFlow()
        {
            tempflows = new Dictionary<string, string>();
       
            chkFlow.Items.Clear();


            tempflows.Add("1.Check IC Type", "Check IC Type");
            tempflows.Add("2.CheckChannel", "CheckChannel");
            tempflows.Add("3.Program flash", " Program flash");
            tempflows.Add("4.Read ID", "Read ID");
            tempflows.Add("5.FW Version Test", "FW Version Test");
            tempflows.Add("6.Reset Test", "Check Reset Pin");
            tempflows.Add("7.INT Test", "Check INT Pin");
            tempflows.Add("8.NoiseTest", "Collect Noise & RAW Data");
            tempflows.Add("9.RawDataTest", "Collect Noise & RAW Data");
            tempflows.Add("10.ShortTest", "Collect Short Data");
            tempflows.Add("11.OpenTest", "Collect Open Data");
            tempflows.Add("12.NormalIdleTest", "Collect Normal Idle Data");
            tempflows.Add("13.LPWUGIdleTest", "Collect LPWUG Idle Data");
            tempflows.Add("14.LPWUGActiveTest", "Collect LPWUG Active Data");

            foreach (string skey in testAllFlow.Keys)
            {
                foreach (string sklist in tempflows.Keys)
                {
                    if (tempflows[sklist] == skey)
                    {
                        chkFlow.Items.Add(sklist,true);
                    }
                }
            }
         
        }

        public void ReadLinitChechk(int _Index, string[] _tempstr)
        {
            if (_tempstr[_Index].Contains("CollectAndLimitCheck_End"))
                return;
            if(_tempstr[_Index].Trim() != "")
            {
                testlistItem.Add(_tempstr[_Index].Trim());
            }
            ReadLinitChechk(_Index + 1, _tempstr);
        }

        public void ReadStart(int _Index,string[] _tempstr)
        {
            if (!_tempstr[_Index].Contains("TestItemFlow_End"))
            {
                string tempstrl = _tempstr[_Index];
                if (tempstrl.Trim() != "")
                {
                    string tempR = _tempstr[_Index];
                    string[] tempstr = tempR.Split('=');
                    string[] tempRead = tempstr[1].Split(',');
                    if (tempRead[1].Trim() == "T")
                    {
                        chkTestSelection.Items.Add(chkTestSelection.Items.Count.ToString() + "." + tempRead[6], tempRead[0].Trim() == "T" ? true : false);

                        testAllFlow.Add(tempRead[6], _tempstr[_Index]);
                        if (_tempstr[_Index].Contains("cb|IC_MODE|"))
                        {
                            testFlow.Add(tempRead[6], _tempstr[_Index]);
                        }

                    }
                   
                } 
                if (_Index < _tempstr.Length - 2)
                        ReadStart(_Index + 1, _tempstr);
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int sp = 777777;
            //byte[] tes = System.BitConverter.GetBytes(sp);
            //int sps = tes.Length;
            InitApp(System.IO.Directory.GetCurrentDirectory() + "\\app.ini");
            //  txtOutput.Text = PathApp;
            //
            checkedListBox2.SetItemChecked(1, true);


         
        }

        IniFile iniFile;
        //初始化配置
        public void InitApp(string file)
        {
            if (System.IO.File.Exists(file) == false)
            {
                return;
            }
            try
            {
                iniFile = new IniFile(file);

                Dictionary<string, string> tempchb = iniFile.GetSectionValues("Touch Solution");
              
                foreach(string strL in tempchb.Keys)
                {
                   chbTouch.Items.Add(tempchb[strL].ToString());
                }
                if(chbTouch.Items.Count>0)
                {
                    chbTouch.SelectedIndex = 0;
                }
                tempchb = iniFile.GetSectionValues("Protocol");
                foreach (string strL in tempchb.Keys)
                {
                    chbProtocol.Items.Add(tempchb[strL].ToString());
                }
                if (chbProtocol.Items.Count > 0)
                {
                    chbProtocol.SelectedIndex = 0;
                }
                tempchb = iniFile.GetSectionValues("I2CSpeed");
                foreach (string strL in tempchb.Keys)
                {
                    txtI2CSpeed.Items.Add(tempchb[strL].ToString());
                }
                if (txtI2CSpeed.Items.Count > 0)
                {
                    txtI2CSpeed.SelectedIndex = 0;
                }

                CancelKey = new List<string>();
                tempchb = iniFile.GetSectionValues("SelectItem");
                foreach (string strL in tempchb.Keys)
                {
                    //txtI2CSpeed.Items.Add(tempchb[strL].ToString());
                    CancelKey.Add(tempchb[strL].ToString());
                }
                UserID = iniFile.GetString("TSP", "type", "");

                ENetWork[0] = iniFile.GetString("NetWork", "Port", "");
                ENetWork[1] = iniFile.GetString("NetWork", "IPv4IPAddress", "");
                ENetWork[2] = iniFile.GetString("NetWork", "IPv4NetworkMask", "");
                ENetWork[3] = iniFile.GetString("NetWork", "IPv4DefaultGateway", "");
                ENetWork[4] = iniFile.GetString("NetWork", "TP-TESTERServer", "");
                ENetWork[5] = iniFile.GetString("NetWork", "LOGFileSubfolder", "");
                ENetWork[6] = iniFile.GetString("NetWork", "EDHCP", "");

            }
            catch (Exception le)
            {
                MessageBox.Show(le.Message.ToString());
            }
            //Unsigned
           
        }

        public void SetInAndOutCFGwithBCC(ushort CFG_ID, byte[] CFG_DATA, out byte[] CFGwithBCC)
        {
            //
            int Y;
            int X = CFG_DATA.Length;
            byte[] CFG_DATA_ADD = null;


            int d = (X + 2) % 4;//(int)Math.Floor((double)((X + 2) / 4));
            if (d == 0)
            {
                Y = 0;
                CFG_DATA_ADD = null;
            }
            else
            {
                Y = 4 - d;
                CFG_DATA_ADD = new byte[Y];
                for (int m = 0; m < Y; m++)
                {
                    CFG_DATA_ADD[m] = 0;
                }
                 
            }
            ushort CFG_LENGTH =(ushort)( X + 2 + Y) ;
            byte[] CFG_ID_HI = BitConverter.GetBytes(CFG_ID);
            byte[] CFG_LENGTH_HI = BitConverter.GetBytes(CFG_LENGTH);

            byte[] appendedarray = new byte[X +Y+ 5];

            for (int i = 0; i < appendedarray.Length;i++ )
            {
                appendedarray[i] = 0;
            }

            appendedarray[0] = CFG_ID_HI[1];
            appendedarray[1] = CFG_ID_HI[0];
            appendedarray[2] = CFG_LENGTH_HI[1];
            appendedarray[3] = CFG_LENGTH_HI[0];
            appendedarray[4] =(byte)Y;

            for(int m = 0;m<CFG_DATA.Length;m++)
            {
                appendedarray[m + 5] = CFG_DATA[m];
            }
            
            //appendedarray={CFG_ID_HI,CFG_ID_LOW,CFG_LENGTH_HI,CFG_LENGTH_LOW,CFG_DATA}
            byte CFG_BCC =0;

            for (int i = 0; i < appendedarray.Length; i++)
            {
                 CFG_BCC=(byte)(CFG_BCC ^ appendedarray[i]);
            }
            CFGwithBCC = new byte[appendedarray.Length+1];
            for(int n =0;n<appendedarray.Length ;n++)
            {
                CFGwithBCC[n] = appendedarray[n];
            }
            CFGwithBCC[CFGwithBCC.Length-1] = CFG_BCC;
        }
        public byte[] Getsp(ushort Vals)
        {
            string GetSP = Vals.ToString("X2");
            byte[] data = BitConverter.GetBytes(Vals);
            return data;

        }

        private void chkFlow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox2.Items.Count; i++)
            {
                if (checkedListBox2.Items[i].ToString() == "Enable Networtk")
                {
                    if (checkedListBox2.GetItemChecked(i) == true)
                    {
                        ShowNetWork _ShowNetWork = new ShowNetWork();
                        _ShowNetWork.LoadSetting(this);
                        _ShowNetWork.ShowDialog();
                    }
                }
            }
        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            iniFile.WriteValue("NetWork", "Port", ENetWork[0] );
            iniFile.WriteValue("NetWork", "IPv4IPAddress", ENetWork[1]);
            iniFile.WriteValue("NetWork", "IPv4NetworkMask", ENetWork[2]);
            iniFile.WriteValue("NetWork", "IPv4DefaultGateway", ENetWork[3]);
            iniFile.WriteValue("NetWork", "TP-TESTERServer", ENetWork[4]);
            iniFile.WriteValue("NetWork", "LOGFileSubfolder", ENetWork[5]);
            iniFile.WriteValue("NetWork", "EDHCP", ENetWork[6]);//
        }

        private void panel1_Click(object sender, EventArgs e)
        {
         
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                ShowCode _ShowCode = new ShowCode();
                _ShowCode.ShowDialog();

                this.ecodeid = _ShowCode.sget();
            }
        
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }  
}
