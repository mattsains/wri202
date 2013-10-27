namespace Tuckshop
{
    partial class NewStaffScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtfirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStaffNum = new System.Windows.Forms.Label();
            this.txtStaffNum = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Location = new System.Drawing.Point(125, 127);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.Location = new System.Drawing.Point(44, 127);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSurname.Location = new System.Drawing.Point(91, 63);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(124, 20);
            this.txtSurname.TabIndex = 2;
            this.txtSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // lblSurname
            // 
            this.lblSurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(18, 66);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 19;
            this.lblSurname.Text = "Surname";
            // 
            // txtfirstName
            // 
            this.txtfirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtfirstName.Location = new System.Drawing.Point(91, 37);
            this.txtfirstName.Name = "txtfirstName";
            this.txtfirstName.Size = new System.Drawing.Size(124, 20);
            this.txtfirstName.TabIndex = 1;
            this.txtfirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // lblFirstName
            // 
            this.lblFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(18, 40);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 17;
            this.lblFirstName.Text = "First Name";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(91, 89);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(124, 20);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(18, 92);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 26;
            this.lblEmail.Text = "Email";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblStaffNum);
            this.panel1.Controls.Add(this.txtStaffNum);
            this.panel1.Controls.Add(this.txtSurname);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lblFirstName);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.txtfirstName);
            this.panel1.Controls.Add(this.lblSurname);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 118);
            this.panel1.TabIndex = 28;
            // 
            // lblStaffNum
            // 
            this.lblStaffNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStaffNum.AutoSize = true;
            this.lblStaffNum.Location = new System.Drawing.Point(18, 14);
            this.lblStaffNum.Name = "lblStaffNum";
            this.lblStaffNum.Size = new System.Drawing.Size(69, 13);
            this.lblStaffNum.TabIndex = 28;
            this.lblStaffNum.Text = "Staff Number";
            // 
            // txtStaffNum
            // 
            this.txtStaffNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStaffNum.Location = new System.Drawing.Point(91, 11);
            this.txtStaffNum.Name = "txtStaffNum";
            this.txtStaffNum.Size = new System.Drawing.Size(124, 20);
            this.txtStaffNum.TabIndex = 0;
            this.txtStaffNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_KeyPress);
            // 
            // NewStaffScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Name = "NewStaffScreen";
            this.Size = new System.Drawing.Size(245, 160);
            this.Load += new System.EventHandler(this.NewStaffScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtfirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStaffNum;
        private System.Windows.Forms.TextBox txtStaffNum;
    }
}
