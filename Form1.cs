using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileReader___dylan_hughes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void readbutton_Click(object sender, EventArgs e)
        {
            //string variable
            string filenameS = "";

            //file name validation
            if (filepathtextbox.Text == "")
            {
                MessageBox.Show("Invalid File Name.");
            }

            //setting file name
            filenameS = filepathtextbox.Text;

            //try to find file
            try
            {
                //find and read file
                StreamReader inputfile;

                inputfile = File.OpenText(filenameS);

                //loops and writes each line to list box
                while(inputfile.EndOfStream == false)
                {
                    displaylistbox.Items.Add(inputfile.ReadLine() + "\r\n");
                }

                //close file
                inputfile.Close();
            }

            //catch displays if no file is found
            catch (Exception myException)
            {

                MessageBox.Show(myException.Message);

            }
        }
    }
}
