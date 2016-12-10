using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string hold = null;
        Button operate = null;
        string keyhold = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
        
            if (result.Text == "0")
            {
                result.Text = null;
            }
            Button value = (Button)sender;
            result.Text = result.Text + value.Text;
        }

        private void clear_Entry(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operation(object sender, EventArgs e)
        {
            hold = result.Text;
            operate = (Button)sender;
            result.Text = "0";



        }

        private void final(object sender, EventArgs e)
        {
            double val1, val2, output;
            val1 = Convert.ToDouble(hold);
            val2 = Convert.ToDouble(result.Text);
            if (operate.Text == "*")
            {
                output = val1 * val2;
            }
            else if (operate.Text == "/")
            {
                output = val1 / val2;
            }
            else if (operate.Text == "-")
            {
                output = val1 - val2;
            }
            else
            {
                output = val1 + val2;
            }
            result.Text = Convert.ToString(output);
        }



        private void clear_all(object sender, EventArgs e)
        {
            result.Text = "0";
            hold = null;
            operate = null;
        }

        private void OnTyper(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                    {
                       
                        keyhold = keyhold + e.KeyChar;
                        if(result.Text == "0")
                        {
                            result.Text = keyhold;
                        }
                        else
                        result.Text = result.Text + keyhold;
                        break;
                    }
        
                default:
                    break;
            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
          

        }

        private void OnType(object sender, KeyPressEventArgs e)
        {

        }

        private void result_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
