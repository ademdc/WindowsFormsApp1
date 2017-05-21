using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";

            s = textBox1.Text + dateTimePicker1.Text;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Title = "Save an Image File";

            saveFileDialog1.ShowDialog();



            if (saveFileDialog1.FileName != "")

                System.IO.File.WriteAllText(saveFileDialog1.FileName, s);
        }
    }
}
