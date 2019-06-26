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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            UserName = txtName.Text;
            UserAge = float.Parse(lblAge.Text);

            lblOutput.Text = txtName.Text + " " + txtAge.Text;


            txtName.Text = string.Empty;
            lblAge.Text = string.Empty;

            
        }


        /// <summary>
        /// This is the Event Handler form the tab8Form load event;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lab8Form_Load(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;

                
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            btnSubmit.Enabled = true;
        }
    }
}
