using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SalsSandwiches
{
    public partial class SandwhichBuilder : Form
    {
        public SandwhichBuilder()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                desLabel.Text = "Enter a valid name!";
            } else { desLabel.Text = "Welcome " + textBox1.Text + "! Choose a type of Sandwhich!";
                sandType.Visible = true;
            }
        }

        private void sandType_SelectedIndexChanged(object sender, EventArgs e)
        {
            breadBox.Visible = true;
            extrasBox.Visible = false;
            string selected = sandType.Text;
            desLabel.Text = "Welcome " + textBox1.Text + "! You chose a " + selected + "!";
            
        }

        private void breadBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            extrasBox.Visible = true;
            string selected = sandType.Text;
            string bread = breadBox.Text;
            desLabel.Text = "Welcome " + textBox1.Text + "! You chose a " + selected + " on " + bread + "!";
            askLabel.Visible = true;
            orderButton.Visible = true;
        }

        private void extrasBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = sandType.Text;
            string bread = breadBox.Text;
            string extras = Convert.ToString(extrasBox.SelectedItems);
            string item = "";
            foreach (int i in extrasBox.SelectedIndices)
            {
                item += extrasBox.Items[i] + Environment.NewLine;
            }

            desLabel.Text = "Welcome " + textBox1.Text + "! You chose a " + selected + " on " + bread + " with:\n " + item;
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            string path = @"..\Orders.txt";
            using (var tw = new StreamWriter(path, true))
            {
                tw.WriteLine(desLabel.Text);
            }
            askLabel.Visible = false;
            orderButton.Visible = false;
            desLabel.Text = "Thanks your order has been submitted!";
        }
    }
}
