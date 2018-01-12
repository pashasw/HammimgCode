using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HammingCode
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = MessageTextBox.Text;
            CodeMessageTextBox.Text = Coding.CodeWord(message);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = CipherTextBox.Text;
            CorrectCipherTextBox.Text = Coding.CorrectionCode(message);
        }
    }
    public class Coding
    {
        public static string InsertBit(string code)
        {
            int index = code.Length;
            double degree = 0;
            string newcode = code;
            for (int i = 0; Math.Pow(2, i) < index; i++)
            {
                degree = Math.Pow(2, i);
                newcode = newcode.Insert((int)degree - 1, "0");
                index = index + 1;
            }
            return newcode;
        }
        public static int[,] CreateMatrix(int line, int column)
        {
            int[,] matrix = new int[line, column];
            string output = "";
            for (int i = 0; i < column; i++)
            {
                output = Convert.ToString(i+1, 2);
                char[] arr = output.ToCharArray();
                Array.Reverse(arr);
                int j = 0;
                for (; j < arr.Count(); j++)
                {
                    matrix[j, i] = Convert.ToInt32(arr[j] - '0');
                }
                for (; j < line; j++)
                {
                    matrix[j, i] = 0;
                }
            }
            return matrix;
        
        }
        public static string XOR(string R, string key)
        {
            string answer = "";
            for (int i = 0; i < R.Length; i++)
            {
                if ((R[i] == '1' && key[i] == '1') || (R[i] == '0' && key[i] == '0'))
                    answer += '0';
                if ((R[i] == '0' && key[i] == '1') || (R[i] == '1' && key[i] == '0'))
                    answer += '1';
            }
            return answer;
        }

        public static string CodeWord(string code)
        {
            string temp = "";
            string newcode = "";
            string insertstring = "";
            string cipher = newcode;
            newcode = InsertBit(code);
            int[,] matrix = CreateMatrix(newcode.Length - code.Length, newcode.Length);
            int sum = 0;
            for (int i = 0; i < newcode.Length - code.Length; i++)
            {
                for (int j = 0; j < newcode.Length; j++)
                {
                    sum += ((Convert.ToInt32(newcode[j] - '0') ) * matrix[i,j]);
                }
                temp += sum % 2;
                sum = 0;
            }
            int pow =0;
            for (int i = 0; i < newcode.Length; i++)
            {
                if (i+1 == Math.Pow(2, pow))
                { insertstring += temp[pow]; pow++; }
                else insertstring += "0";
            }
            cipher = XOR(newcode,insertstring);
                return cipher;
        }
        public static int Conv(string a)
        {
            int len = a.Length;
            int nomber = 0;
            int[] b = new int[len];
            for (int i = 0; i < len; i++)
            {
                if (a[i] == '1')
                    b[i] = 1;
                else b[i] = 0;
            }
            for (int i = 0; i < len; i++)
            {
                nomber += b[i] * Convert.ToInt32(Math.Pow(2, len - i - 1));
            }
            return nomber;
        }
        public static string CorrectionCode(string cipher)
        {
            int powtu = 0;
            while (Math.Pow(2, powtu) <= cipher.Length)
                powtu++;
            int[,] matrix = CreateMatrix(powtu, cipher.Length);
            int sum = 0;
            string temp = "";
            for (int i = 0; i < powtu; i++)
            {
                for (int j = 0; j < cipher.Length; j++)
                {
                    sum += ((Convert.ToInt32(cipher[j] - '0')) * matrix[i, j]);
                }
                temp += sum % 2;
                sum = 0;
            }
            char[] arr = temp.ToCharArray();
            Array.Reverse(arr);
            string s = "";
            for (int i = 0; i < arr.Count(); i++)
            {
                s += arr[i];
            }
            int error = Conv(s);
            char[] newcipher = cipher.ToCharArray();
            if (newcipher[error - 1] == '0')
                newcipher[error - 1] = '1';
            else newcipher[error - 1] = '0';
            string answer = "";
            for (int i = 0; i < newcipher.Count(); i++)
            {
                answer += newcipher[i];
            }
            return answer;
        }
 
    }
}
