using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace StringParser
{
    public partial class Form1 : Form
    {
        enum ParseCmd
        {
            ParseStart = 0,
            ParseEnd   = 1,
            ParseString = 3,
        };
        private List<string> cmd = new List<string>();
        private string cmdString;
        private string inString;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void parseString(string str)
        {
            bool pend = false;
            int pos = 0;
            int length = str.Length;
            string tmp = "";
            string cmd = "";
            ParseCmd pCmd = ParseCmd.ParseString;





            while(pos < length)
            {
                char c = str[pos++];
                switch (c)
                {
                    case '[':
                        pCmd = ParseCmd.ParseStart;
                        continue;
                        break;
                    case ']':
                        pCmd = ParseCmd.ParseEnd;
                        continue;
                        break;
                    default:
                        switch (pCmd)
                        {
                            case ParseCmd.ParseStart:
                                cmd += c;
                                break;
                            case ParseCmd.ParseEnd:
                                tmp += ParseCmd(cmd);
                                break;
                            case ParseCmd.ParseString:
                                tmp += c;
                                break;
                        }
                        break;
                }
            }

        }
        private string ParseCmd(string cmd)
        {
            string ostr = "";
            switch (cmd[0])
            {
                case 'N':
                    break;
                    
            }
            return ostr;
        }
    }
}
