using mfe_project.sdata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace mfe_project
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            create_msl_panel.Visible = false;
            uuidBox.Text = Guid.NewGuid().ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        string lastSName;
        string solutionName;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


            solutionName = nameBox.Text;

            if (nameBox.Text.Contains(Convert.ToChar("*"))) {
                // MessageBox.Show("You entered an invalid character for the solutionName value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                solutionName = solutionName.Remove(solutionName.Length - 2);
                solutionName = nameBox.Text + "_";  
            }

            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            

            if (nameBox.Text == "")
            {
                MessageBox.Show("Solution Name value cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                create_msl_panel.Visible = false;
            } else
            {
                MSLData package = new MSLData(nameBox.Text, sPath.Text, Guid.Parse(uuidBox.Text), mfeVersion.Text, author.Text, publisher.Text, "", "", websiteBox.Text, emailBox.Text);
                MessageBox.Show(package.buildData());
                create_msl_panel.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            create_msl_panel.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            uuidBox.Text = Guid.NewGuid().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

        }
    }
}
