using System;
using System.Windows.Forms;

namespace streamCipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string textNormal;
        int codeInt = 10;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            textNormal = textBox1.Text;
            obrabotka(codeInt, textNormal);
        }
        public void code_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                char[] Code;
                Code = txtKey.Text.ToCharArray();
                codeInt = Convert.ToInt32(Code);
            }
        }

        public void obrabotka(int code, string text)
        {
            string Crypt = "";
            for (int i = 0; i < text.Length; i++)
            {
                int charVal = Convert.ToInt32(text[i]);
                charVal ^= code;
                Crypt += char.ConvertFromUtf32(charVal);
            }
            textBox2.Text = Crypt;
        }
    }
}