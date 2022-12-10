using System;
using System.Windows.Forms;

namespace StringTool
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            this.Text = "字符串转换工具 - OKeyDesk";
        }

        public static string CreateName(string s)
        {
            string strReturn = string.Empty;
            if (s == null || s.Trim() == "")
            {
                return strReturn;
            }

            foreach (char chrTemp in s)
            {
                if (Char.IsLetter(chrTemp) || Char.IsNumber(chrTemp))
                {
                    strReturn += chrTemp.ToString();
                    if (strReturn.Length == 30)
                    {
                        break;
                    }
                }
            }
            return strReturn;
        }

        private void txtSource_TextChanged(object sender, EventArgs e)
        {
            this.Text = "字符串转换工具 - OKeyDesk";

            string sAnsi = "";
            string sUnicode = "";
            for (int i = 0; i < txtSource.Text.Length; i++)
            {
                if(txtSource.Text[i] == '\\')
                {
                    sAnsi += "'\\\\',";
                    sUnicode += "L'\\\\',";
                }
                else
                {
                    sAnsi += "'" + txtSource.Text[i] + "',";
                    sUnicode += "L'" + txtSource.Text[i] + "',";
                }
            }

            if (txtSource.Text.Length != 0)
            {
                sAnsi += "0";
                sUnicode += "0";
            }

            txtAnsi.Text = "// ANSI: " + txtSource.Text + "\r\n" + "char " + "PCHAR_" + CreateName(txtSource.Text) + "[] = { " + sAnsi + " };\r\n";
            txtUnicode.Text = "// Unicode: " + txtSource.Text + "\r\n" + "wchar_t " + "PWCHAR_" + CreateName(txtSource.Text) + "[] = { " + sUnicode + " };\r\n";
        }

        private void btnCopyAnsi_Click(object sender, EventArgs e)
        {
            if (txtAnsi.TextLength != 0)
            {
                Clipboard.SetText(txtAnsi.Text);
                this.Text = "[+] ANSI内容已复制！";
            }
            else
            {
                this.Text = "字符串转换工具 - OKeyDesk";
            }
        }

        private void btnCopyUnicode_Click(object sender, EventArgs e)
        {
            if (txtUnicode.TextLength != 0)
            {
                Clipboard.SetText(txtUnicode.Text);
                this.Text = "[+] UNICODE内容已复制！";
            }
            else
            {
                this.Text = "字符串转换工具 - OKeyDesk";
            }
        }
    }
}
