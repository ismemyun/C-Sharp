namespace Week08_Wed
{
    partial class Lab8Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(92, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "LAB 8";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(34, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(151, 29);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Your Name:";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // txtName
            // 
            this.txtName.AllowDrop = true;
            this.txtName.Location = new System.Drawing.Point(191, 41);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(155, 29);
            this.txtName.TabIndex = 2;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(57, 85);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(128, 29);
            this.lblAge.TabIndex = 1;
            this.lblAge.Text = "Your Age:";
            this.lblAge.Click += new System.EventHandler(this.lblName_Click);
            // 
            // gbInfo
            // 
            this.gbInfo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gbInfo.Controls.Add(this.txtAge);
            this.gbInfo.Controls.Add(this.lblName);
            this.gbInfo.Controls.Add(this.txtName);
            this.gbInfo.Controls.Add(this.lblAge);
            this.gbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInfo.ForeColor = System.Drawing.Color.Black;
            this.gbInfo.Location = new System.Drawing.Point(125, 85);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(366, 137);
            this.gbInfo.TabIndex = 3;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "Info";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(366, 302);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(125, 47);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(120, 302);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 29);
            this.lblOutput.TabIndex = 3;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(192, 85);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(154, 31);
            this.txtAge.TabIndex = 3;
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // Lab8Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.lblTitle);
            this.Name = "Lab8Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab8";
            this.Load += new System.EventHandler(this.Lab8Form_Load);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblOutput;
    }
}

