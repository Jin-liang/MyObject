using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_TestFile
{
    public  class FileAI
    {

        public Dictionary<string, object> _testItem = new Dictionary<string, object>();

        public Dictionary<string, List<string>> ReTestItem = new Dictionary<string, List<string>>();
        public void GetAlist(string[] ReadStr)
        {
            string srl = "";
            for (int i = 0; i < ReadStr.Length; i++)
            {
                srl = ReadStr[i];
                if (srl.Trim() != "")
                {
                    if (srl.Contains(">TestLimit_START<"))
                    {
                        ReadStart(i + 1, ReadStr);
                    }
                }
            }
            // >TestLimit_END<
        }

        public void ReadStart(int _Index, string[] _tempstr)
        {
            
          
            if (!_tempstr[_Index].Contains(">TestLimit_END<"))
            { 
                string tempstrl = _tempstr[_Index];
                if (tempstrl.Trim() != "")
                {
                    if (tempstrl.Trim().Substring(0, 1) == "#")
                    {
                        List<string> templs = new List<string>();

                        ReadLine(_Index + 1, _tempstr, templs);

                        ReTestItem.Add(tempstrl.Trim(), templs);
                    }
                }
                if (_Index < _tempstr.Length - 2)
                    ReadStart(_Index + 1, _tempstr);
            }
        }

        public void ReadLine(int _Index,string[] _tempstr,List<string> tempList)
        {
            if (!_tempstr[_Index].Contains(">TestLimit_END<"))
            {
                if (_Index < _tempstr.Length)
                {
                    string tempstrl = _tempstr[_Index];
                    if (tempstrl.Trim() == "")
                    {
                        ReadLine(_Index + 1, _tempstr, tempList);
                    }
                    else if (tempstrl.Substring(0, 1) != "#")
                    {
                        tempList.Add(tempstrl.Trim());
                        ReadLine(_Index + 1, _tempstr, tempList);
                    }
                }
            }
        }
        public void initTestItems()
        {
            List<string> _sItem = new List<string>();
            //===========NOISE 测试，通道数组（个数：RX NUM * TX NUM）上限/RX（个数：RX NUM）上限/TX(个数：TX NUM)上限======
            //#define NOISE_AA_UPPER		        (110)		//
            //#define NOISE_RX_UPPER		        (111)		//
            //#define NOISE_TX_UPPER		        (112)		//
            //#define NOISE_AA_LOWER		        (113)		//
            //#define NOISE_RX_LOWER		        (114)		//
            //#define NOISE_TX_LOWER		        (115)		//
            //#define AA_REF_IIR_MAX		        (160)		//
            //#define RX_REF_IIR_MAX		        (161)		//
            //#define TX_REF_IIR_MAX		        (162)		//
            _sItem = new List<string>();
            _sItem.Add("Normal_NOISE_AA_UPPER_110");
            _sItem.Add("Normal_NOISE_RX_UPPER_111");
            _sItem.Add("Normal_NOISE_TX_UPPER_112");
            _sItem.Add("Normal_NOISE_AA_LOWER_113");
            _sItem.Add("Normal_NOISE_RX_LOWER_114");
            _sItem.Add("Normal_NOISE_TX_LOWER_115");
            _sItem.Add("AA_REF_IIR_MAX_160");
            _sItem.Add("RX_REF_IIR_MAX_161");
            _sItem.Add("TX_REF_IIR_MAX_162");
            _testItem.Add("NOISETest", _sItem);

            //===========RAWDATA 测试，通道数组（个数：RX NUM * TX NUM）上限/RX（个数：RX NUM）上限/TX(个数：TX NUM)上限======
            //#define RAWDATA_AA_UPPER		    (120)		//
            //#define RAWDATA_RX_UPPER		    (121)		//
            //#define RAWDATA_TX_UPPER		    (122)		//
            //#define RAWDATA_AA_LOWER		    (123)		//
            //#define RAWDATA_RX_LOWER		    (124)		//
            //#define RAWDATA_TX_LOWER		    (125)		//
            //#define AA_REF_RAWDATA		        (165)		//
            //#define RX_REF_RAWDATA		        (166)		//
            //#define TX_REF_RAWDATA		        (167)		//
            //#define AA_REF_RAWDATA_PER		    (170)		//
            //#define RX_REF_RAWDATA_PER		    (171)		//
            //#define TX_REF_RAWDATA_PER		    (172)		//
            _sItem = new List<string>();
            _sItem.Add("Normal_RAWDATA_AA_UPPER_120");
            _sItem.Add("Normal_RAWDATA_RX_UPPER_121");
            _sItem.Add("Normal_RAWDATA_TX_UPPER_122");
            _sItem.Add("Normal_RAWDATA_AA_LOWER_123");
            _sItem.Add("Normal_RAWDATA_RX_LOWER_124");
            _sItem.Add("Normal_RAWDATA_TX_LOWER_125");
            _sItem.Add("AA_REF_RAWDATA_165");
            _sItem.Add("RX_REF_RAWDATA_166");
            _sItem.Add("TX_REF_RAWDATA_167");
            _sItem.Add("AA_REF_RAWDATA_PER_170");
            _sItem.Add("RX_REF_RAWDATA_PER_171");
            _sItem.Add("TX_REF_RAWDATA_PER_172");
            _testItem.Add("RAWDATATest", _sItem);
           
            //===========SHORT 测试，通道数组（个数：RX NUM * TX NUM）上限/RX（个数：RX NUM）上限/TX(个数：TX NUM)上限======
            //#define SHORT_AA_UPPER		        (130)		//
            //#define SHORT_RX_UPPER		        (131)		//
            //#define SHORT_TX_UPPER		        (132)		//
            //#define SHORT_AA_LOWER		        (133)		//
            //#define SHORT_RX_LOWER		        (134)		//
            //#define SHORT_TX_LOWER		        (135)		//
            //#define AA_REF_SHORT		        (175)		//
            //#define RX_REF_SHORT		        (176)		//
            //#define TX_REF_SHORT		        (177)		//
            _sItem = new List<string>();
            _sItem.Add("SHORT_AA_UPPER_130");
            _sItem.Add("SHORT_RX_UPPER_131");
            _sItem.Add("SHORT_TX_UPPER_132");
            _sItem.Add("SHORT_AA_LOWER_133");
            _sItem.Add("SHORT_RX_LOWER_134");
            _sItem.Add("SHORT_TX_LOWER_135");
            _sItem.Add("AA_REF_SHORT_175");
            _sItem.Add("RX_REF_SHORT_176");
            _sItem.Add("TX_REF_SHORT_177");
            _testItem.Add("SHORTTest", _sItem);

            //===========OPEN 测试，通道数组（个数：RX NUM * TX NUM）上限/RX（个数：RX NUM）上限/TX(个数：TX NUM)上限======
            //#define OPEN_AA_UPPER		        (140)		//
            //#define OPEN_RX_UPPER		        (141)		//
            //#define OPEN_TX_UPPER		        (142)		//
            //#define OPEN_AA_LOWER		        (143)		//
            //#define OPEN_RX_LOWER		        (144)		//
            //#define OPEN_TX_LOWER		        (145)		//
            //#define AA_REF_OPEN		            (180)		//
            //#define RX_REF_OPEN		            (181)		//
            //#define TX_REF_OPEN	                (182)	
            _sItem = new List<string>();
            _sItem.Add("OPEN_AA_UPPER_140");
            _sItem.Add("OPEN_RX_UPPER_141");
            _sItem.Add("OPEN_TX_UPPER_142");
            _sItem.Add("OPEN_AA_LOWER_143");
            _sItem.Add("OPEN_RX_LOWER_144");
            _sItem.Add("OPEN_TX_LOWER_145");
            _sItem.Add("AA_REF_OPEN_180");
            _sItem.Add("RX_REF_OPEN_181");
            _sItem.Add("TX_REF_OPEN_182");

            _sItem.Add("MICROOPEN_AA_UPPER_150");
            _sItem.Add("MICROOPEN_RX_UPPER_151");
            _sItem.Add("MICROOPEN_TX_UPPER_152");
            _sItem.Add("MICROOPEN_AA_LOWER_153");
            _sItem.Add("MICROOPEN_RX_LOWER_154");
            _sItem.Add("MICROOPEN_TX_LOWER_155");
            _sItem.Add("AA_REF_MOPEN_190");
            _sItem.Add("RX_REF_MOPEN_191");
            _sItem.Add("TX_REF_MOPEN_192");
            _testItem.Add("OPENTest", _sItem);

            //===========MICRO OPEN 测试，通道数组（个数：RX NUM * TX NUM）上限/RX（个数：RX NUM）上限/TX(个数：TX NUM)上限======
            //#define MICROOPEN_AA_UPPER		    (150)		//
            //#define MICROOPEN_RX_UPPER		    (151)		//
            //#define MICROOPEN_TX_UPPER		    (152)		//
            //#define MICROOPEN_AA_LOWER		    (153)		//
            //#define MICROOPEN_RX_LOWER		    (154)		//
            //#define MICROOPEN_TX_LOWER
            //#define AA_REF_MOPEN		        (190)		//
            //#define RX_REF_MOPEN		        (191)		//
            //#define TX_REF_MOPEN	            (192)		//
            _sItem = new List<string>();

            _sItem.Add("MICROOPEN_AA_UPPER_150");
            _sItem.Add("MICROOPEN_RX_UPPER_151");
            _sItem.Add("MICROOPEN_TX_UPPER_152");
            _sItem.Add("MICROOPEN_AA_LOWER_153");
            _sItem.Add("MICROOPEN_RX_LOWER_154");
            _sItem.Add("MICROOPEN_TX_LOWER_155");
            _sItem.Add("AA_REF_MOPEN_190");
            _sItem.Add("RX_REF_MOPEN_191");
            _sItem.Add("TX_REF_MOPEN_192");

            _testItem.Add("MICROOPEN", _sItem);


        
            _sItem = new List<string>();

            _sItem.Add("LPA_RAWDATA_AA_UPPER_200");
            _sItem.Add("LPA_RAWDATA_RX_UPPER_201");
            _sItem.Add("LPA_RAWDATA_TX_UPPER_202");
            _sItem.Add("LPA_RAWDATA_AA_LOWER_203");
            _sItem.Add("LPA_RAWDATA_RX_LOWER_204");
            _sItem.Add("LPA_RAWDATA_TX_LOWER_205");

            ////===========LWUG IDLE RAWDATA 测试，通道数组（个数：RX NUM * TX NUM）上限/RX（个数：RX NUM）上限/TX(个数：TX NUM)上限======
            //LPWUGActive NOISE
            _sItem.Add("LPA_NOISE_AA_UPPER_210");
            _sItem.Add("LPA_NOISE_RX_UPPER_211");
            _sItem.Add("LPA_NOISE_TX_UPPER_212");
            _sItem.Add("LPA_NOISE_AA_LOWER_213");
            _sItem.Add("LPA_NOISE_RX_LOWER_214");
            _sItem.Add("LPA_NOISE_TX_LOWER_215");

            _testItem.Add("LPWUGActiveTest", _sItem);
            _sItem = new List<string>();
            ////===========LWUG IDLE RAWDATA 测试，通道数组（个数：RX NUM * TX NUM）上限/RX（个数：RX NUM）上限/TX(个数：TX NUM)上限======
            _sItem.Add("LPI_RAWDATA_AA_UPPER_220");
            _sItem.Add("LPI_RAWDATA_RX_UPPER_221");
            _sItem.Add("LPI_RAWDATA_TX_UPPER_222");
            _sItem.Add("LPI_RAWDATA_AA_LOWER_223");
            _sItem.Add("LPI_RAWDATA_RX_LOWER_224");
            _sItem.Add("LPI_RAWDATA_TX_LOWER_225");

            ////===========LWUG IDLE NOISE 测试，通道数组（个数：RX NUM * TX NUM）上限/RX（个数：RX NUM）上限/TX(个数：TX NUM)上限======
            _sItem.Add("LPI_NOISE_AA_UPPER_230");
            _sItem.Add("LPI_NOISE_RX_UPPER_231");
            _sItem.Add("LPI_NOISE_TX_UPPER_232");
            _sItem.Add("LPI_NOISE_AA_LOWER_233");
            _sItem.Add("LPI_NOISE_RX_LOWER_234");
            _sItem.Add("LPI_NOISE_TX_LOWER_235");
            _testItem.Add("LPWUGIDLETest", _sItem);

            _sItem = new List<string>();
            //===========NormalIdle~NI_Noise 测试，通道数组（个数：RX NUM * TX NUM）上限/RX（个数：RX NUM）上限/TX(个数：TX NUM)上限======
            _sItem.Add("NI_NOISE_AA_UPPER_240");
            _sItem.Add("NI_NOISE_RX_UPPER_241");
            _sItem.Add("NI_NOISE_TX_UPPER_242");
            _sItem.Add("NI_NOISE_AA_LOWER_243");
            _sItem.Add("NI_NOISE_RX_LOWER_244");
            _sItem.Add("NI_NOISE_TX_LOWER_245");

            //===========NormalIdle~NI_Rawdata 测试，通道数组（个数：RX NUM * TX NUM）上限/RX（个数：RX NUM）上限/TX(个数：TX NUM)上限======
            _sItem.Add("NI_RAWDATA_AA_UPPER_250");
            _sItem.Add("NI_RAWDATA_RX_UPPER_251");
            _sItem.Add("NI_RAWDATA_TX_UPPER_252");
            _sItem.Add("NI_RAWDATA_AA_LOWER_253");
            _sItem.Add("NI_RAWDATA_RX_LOWER_254");
            _sItem.Add("NI_RAWDATA_TX_LOWER_255");

            _testItem.Add("NORMALIDLETest", _sItem);


        }
    }
}
