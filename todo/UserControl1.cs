using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace todo
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string var;
            var = textBox1.Text;
            StreamWriter sw = File.AppendText("todo.txt");
            sw.WriteLine(var);
            sw.Close();
            listBox1.Items.Add(var);
            MessageBox.Show("Added to list");
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("todo.txt");
            foreach (string line in lines)
                  listBox1.Items.Add(line);
            
        }
    }
}
