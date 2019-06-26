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
            this.titleLable = new System.Windows.Forms.Label();
            this.nameLable = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ageLable = new System.Windows.Forms.Label();
            this.infoGrpBox = new System.Windows.Forms.GroupBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.sumbitButton = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.infoGrpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.titleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLable.Location = new System.Drawing.Point(12, 8);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(92, 31);
            this.titleLable.TabIndex = 0;
            this.titleLable.Text = "LAB 8";
            // 
            // nameLable
            // 
            this.nameLable.AutoSize = true;
            this.nameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLable.Location = new System.Drawing.Point(34, 38);
            this.nameLable.Name = "nameLable";
            this.nameLable.Size = new System.Drawing.Size(151, 29);
            this.nameLable.TabIndex = 1;
            this.nameLable.Text = "Your Name:";
            this.nameLable.Click += new System.EventHandler(this.lblName_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.AllowDrop = true;
            this.nameTextBox.Location = new System.Drawing.Point(191, 38);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(155, 27);
            this.nameTextBox.TabIndex = 2;
            // 
            // ageLable
            // 
            this.ageLable.AutoSize = true;
            this.ageLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLable.Location = new System.Drawing.Point(57, 78);
            this.ageLable.Name = "ageLable";
            this.ageLable.Size = new System.Drawing.Size(128, 29);
            this.ageLable.TabIndex = 1;
            this.ageLable.Text = "Your Age:";
            this.ageLable.Click += new System.EventHandler(this.lblName_Click);
            // 
            // infoGrpBox
            // 
            this.infoGrpBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.infoGrpBox.Controls.Add(this.ageTextBox);
            this.infoGrpBox.Controls.Add(this.nameLable);
            this.infoGrpBox.Controls.Add(this.nameTextBox);
            this.infoGrpBox.Controls.Add(this.ageLable);
            this.infoGrpBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoGrpBox.ForeColor = System.Drawing.Color.Black;
            this.infoGrpBox.Location = new System.Drawing.Point(125, 78);
            this.infoGrpBox.Name = "infoGrpBox";
            this.infoGrpBox.Size = new System.Drawing.Size(366, 126);
            this.infoGrpBox.TabIndex = 3;
            this.infoGrpBox.TabStop = false;
            this.infoGrpBox.Text = "Info";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(192, 78);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(154, 31);
            this.ageTextBox.TabIndex = 3;
            this.ageTextBox.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // sumbitButton
            // 
            this.sumbitButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumbitButton.Location = new System.Drawing.Point(366, 279);
            this.sumbitButton.Name = "sumbitButton";
            this.sumbitButton.Size = new System.Drawing.Size(125, 43);
            this.sumbitButton.TabIndex = 4;
            this.sumbitButton.Text = "Submit";
            this.sumbitButton.UseVisualStyleBackColor = true;
            this.sumbitButton.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(120, 279);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 29);
            this.lblOutput.TabIndex = 3;
            // 
            // Lab8Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(624, 407);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.sumbitButton);
            this.Controls.Add(this.infoGrpBox);
            this.Controls.Add(this.titleLable);
            this.Name = "Lab8Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab8";
            this.Load += new System.EventHandler(this.Lab8Form_Load);
            this.infoGrpBox.ResumeLayout(false);
            this.infoGrpBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.Label nameLable;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label ageLable;
        private System.Windows.Forms.GroupBox infoGrpBox;
        private System.Windows.Forms.Button sumbitButton;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label lblOutput;
    }
}

