using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace palidrome
{
    public partial class Form1 : Form
    {
        private string storedString { get; set; }
        private findString allStr;
        private findLongPandrolimeString longStr;
        private findshortPandrolimeString shortStr;
        public string[] splitstr;
        public Form1()
        {
            InitializeComponent();
            allStr = new findString();
            longStr = new findLongPandrolimeString();
            shortStr = new findshortPandrolimeString();
        }

        private void TB_Str_TextChanged(object sender, EventArgs e)
        {
            lb1.Text = "Total String Lenght :" + TB_Str.Text.Length.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //split strings into array for further process
            splitstr = newString.ExtractStr(TB_Str.Text).Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
          
            List<string> str = new List<string>();

            //This checking loop to determine whether it is a palindrome
            for (int i = 0; i < splitstr.Count(); i++)
            {
                if (splitstr[i].Equals(newString.RevertString(splitstr[i])) && splitstr[i].Length>=2)
                {
                    str.Add(splitstr[i]);
                }
            }

            if (str.Count > 0)
            {
                TB_Str2.Text = string.Join(",", str.ToList());
                splitstr = TB_Str2.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                updateTB2Length(countNUpdate());
            }
            else
            {
                MessageBox.Show("No palindrome has been found");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                TB_Str2.Text = longStr.findAll(splitstr, longStr.findAll(splitstr));
                updateTB2Length(countNUpdate());
            }
            catch (Exception)
            {
                MessageBox.Show("No input has been found");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                TB_Str2.Text = shortStr.findAll(splitstr, shortStr.findAll(splitstr));
                updateTB2Length(countNUpdate());
            }
            catch (Exception)
            {
                MessageBox.Show("No input has been found");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                TB_Str2.Text = allStr.findAll(splitstr, allStr.findAll(splitstr));
                updateTB2Length(countNUpdate());
            }
            catch (Exception)
            {
                MessageBox.Show("No input has been found");
            }
            
        }

        private int countNUpdate()
        {
            return TB_Str2.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Count();
        }

        private void updateTB2Length(int length)
        {
            lb2.Text = "Total number of palindrome pairs is " + length.ToString();
        }

        private void TB_Str_MouseHover(object sender, EventArgs e)
        {
            TT1.SetToolTip(TB_Str, "Please key in input");
        }

        private void TB_Str2_MouseHover(object sender, EventArgs e)
        {
            TT1.SetToolTip(TB_Str2, "Here is the result after processing data");
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            TT1.SetToolTip(button1, "Press this one to process data before selecting others");
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            TT1.SetToolTip(button4, "Press this one to collect all the palindrome substrings");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            TT1.SetToolTip(button2, "Press this button to collect all longest palindrome substrings.\nIf input has been updated,please press process again");
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            TT1.SetToolTip(button3, "Press this button to collect all the shortest palindrome substrings.\nIf input has been updated,please press process again");
        }
    }

    public static class newString
    {
        public static string ExtractStr(string str)
        {
            StringBuilder strb = new StringBuilder();
            string returnstr = string.Empty;
            //Check the input whether it is a complete english sentence or beyond understanding string
            int count = str.Count(f => f == ' ');
            //This is the process of complete english sentence
            if (count > 0)
            {
                string[] splitstr = str.Split(' ');
                returnstr = string.Join(",", splitstr);
            }
            //This is process of beyond understanding string
            else
            {
                //start with 2nd index
                for (int i = 1; i < str.Length; i++)
                {
                    for (int j = 0; j < str.Length; j++)
                    {
                        if (j < str.Length - 1)
                        {
                            if (j + i + 1 <= str.Length)
                            {
                                strb.Append(str.Substring(j, i + 1) + ",");
                            }
                        }
                    }
                }
                returnstr = strb.ToString();
            }

            
            return returnstr;
        }

        public static string RevertString(string str)
        {
            char[] strArray = str.ToCharArray();
            Array.Reverse(strArray);
            return new string(strArray);
        }
    }

    public class findString
    {
        public virtual int findAll(string[] splitstr)
        {
            int minLength = 2;
            return minLength;
        }

        public virtual string findAll(string[] splitstr, int length)
        {
            List<string> retStr = new List<string>();

            for (int i = 0; i < splitstr.Count(); i++)
            {
                if (splitstr[i].Length >= length)
                {
                    retStr.Add(splitstr[i]);
                }
            }
            
            return string.Join(",", retStr.Distinct().ToList());
        }
    }

    public class findLongPandrolimeString: findString
    {
        public override int findAll(string[] splitstr)
        {
            int maxLength = splitstr[0].Length;
            for (int i = 0; i < splitstr.Count(); i++)
            {
                if (splitstr[i].Length > maxLength)
                {
                    maxLength = splitstr[i].Length;
                }
            }
            return maxLength;
        }

        public override string findAll(string[] splitstr, int length)
        {
            List<string> retStr = new List<string>();
         
            for (int i = 0; i < splitstr.Count(); i++)
            {
                if (splitstr[i].Length == length)
                {
                    retStr.Add(splitstr[i]);
                }
            }
            
            return string.Join(",", retStr.Distinct().ToList());
        }
    }

    public class findshortPandrolimeString: findString
    {
        public override int findAll(string[] splitstr)
        {
            int minLength = splitstr[0].Length;
            for (int i = 0; i < splitstr.Count(); i++)
            {
                if (splitstr[i].Length < minLength)
                {
                    minLength = splitstr[i].Length;
                }
            }
            return minLength;
        }

        public override string findAll(string[] splitstr, int length)
        {
            List<string> retStr = new List<string>();
          
            for (int i = 0; i < splitstr.Count(); i++)
            {
                if (splitstr[i].Length == length)
                {
                    retStr.Add(splitstr[i]);
                }
            }
            
            return string.Join(",", retStr.Distinct().ToList());
        }
    }
}
