using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week08_Wed
{
    public partial class Lab8Form : Form
    {
        public string UserName { get; set; }
        public float UserAge { get; set; }

        /// <summary>
        /// This is the constructor for the Lab8 form.
        /// </summary>
        public Lab8Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the Event Handler for the SubmitButton click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void sumbitButton_Click(object sender, EventArgs e)
        {
            UserName = nameTextBox.Text;
            UserAge = float.Parse(ageTextBox.Text);

            lblOutput.Text = nameTextBox.Text + " " + ageTextBox.Text;
            nameTextBox.Text = string.Empty;
            ageTextBox.Text = string.Empty;

            
        }


        /// <summary>
        /// This is the Event Handler form the tab8Form load event;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lab8Form_Load(object sender, EventArgs e)
        {
            sumbitButton.Enabled = false;

                
        }

        private void ageTextBox_TextChanged(object sender, EventArgs e)
        {
            sumbitButton.Enabled = true;
        }
    }
}
