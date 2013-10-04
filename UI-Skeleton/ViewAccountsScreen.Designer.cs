namespace UI_Skeleton
{
    partial class ViewAccountsScreen
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
            this.dgAccounts = new System.Windows.Forms.DataGridView();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAmountOwing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEmail = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnEmail = new System.Windows.Forms.Button();
            this.lblEmailPromt = new System.Windows.Forms.Label();
            this.btnMarkAll = new System.Windows.Forms.Button();
            this.btnUnmarkAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAccounts
            // 
            this.dgAccounts.AllowUserToAddRows = false;
            this.dgAccounts.AllowUserToDeleteRows = false;
            this.dgAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgAccounts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(199)))), ((int)(((byte)(216)))));
            this.dgAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cName,
            this.cAmountOwing,
            this.cEmail});
            this.dgAccounts.Location = new System.Drawing.Point(3, 39);
            this.dgAccounts.Name = "dgAccounts";
            this.dgAccounts.Size = new System.Drawing.Size(433, 227);
            this.dgAccounts.TabIndex = 1;
            // 
            // cName
            // 
            this.cName.HeaderText = "Name";
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            // 
            // cAmountOwing
            // 
            this.cAmountOwing.HeaderText = "Amount Owing";
            this.cAmountOwing.Name = "cAmountOwing";
            this.cAmountOwing.ReadOnly = true;
            // 
            // cEmail
            // 
            this.cEmail.HeaderText = "Email?";
            this.cEmail.Name = "cEmail";
            // 
            // btnEmail
            // 
            this.btnEmail.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEmail.Location = new System.Drawing.Point(246, 272);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(75, 23);
            this.btnEmail.TabIndex = 2;
            this.btnEmail.Text = "Email";
            this.btnEmail.UseVisualStyleBackColor = true;
            // 
            // lblEmailPromt
            // 
            this.lblEmailPromt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmailPromt.Location = new System.Drawing.Point(4, 4);
            this.lblEmailPromt.Name = "lblEmailPromt";
            this.lblEmailPromt.Size = new System.Drawing.Size(432, 32);
            this.lblEmailPromt.TabIndex = 3;
            this.lblEmailPromt.Text = "If you would like to email accounts to staff, check the email fields of the accou" +
    "nts you would like to send and then click Email";
            // 
            // btnMarkAll
            // 
            this.btnMarkAll.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMarkAll.Location = new System.Drawing.Point(84, 272);
            this.btnMarkAll.Name = "btnMarkAll";
            this.btnMarkAll.Size = new System.Drawing.Size(75, 23);
            this.btnMarkAll.TabIndex = 4;
            this.btnMarkAll.Text = "Mark All";
            this.btnMarkAll.UseVisualStyleBackColor = true;
            this.btnMarkAll.Click += new System.EventHandler(this.btnMarkAll_Click);
            // 
            // btnUnmarkAll
            // 
            this.btnUnmarkAll.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnUnmarkAll.Location = new System.Drawing.Point(165, 272);
            this.btnUnmarkAll.Name = "btnUnmarkAll";
            this.btnUnmarkAll.Size = new System.Drawing.Size(75, 23);
            this.btnUnmarkAll.TabIndex = 5;
            this.btnUnmarkAll.Text = "Unmark All";
            this.btnUnmarkAll.UseVisualStyleBackColor = true;
            this.btnUnmarkAll.Click += new System.EventHandler(this.btnUnmarkAll_Click);
            // 
            // ViewAccountsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUnmarkAll);
            this.Controls.Add(this.btnMarkAll);
            this.Controls.Add(this.lblEmailPromt);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.dgAccounts);
            this.Name = "ViewAccountsScreen";
            this.Size = new System.Drawing.Size(439, 306);
            ((System.ComponentModel.ISupportInitialize)(this.dgAccounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAccounts;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Label lblEmailPromt;
        private System.Windows.Forms.Button btnMarkAll;
        private System.Windows.Forms.Button btnUnmarkAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAmountOwing;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cEmail;

    }
}
