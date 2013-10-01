namespace UI_Skeleton
{
    partial class ViewStaffScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgStaff = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cStaffNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEmail = new System.Windows.Forms.DataGridViewLinkColumn();
            this.cBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // dgStaff
            // 
            this.dgStaff.AllowUserToAddRows = false;
            this.dgStaff.AllowUserToDeleteRows = false;
            this.dgStaff.AllowUserToOrderColumns = true;
            this.dgStaff.AllowUserToResizeRows = false;
            this.dgStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStaff.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cStaffNum,
            this.cFirstName,
            this.cSurname,
            this.cEmail,
            this.cBalance});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgStaff.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgStaff.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgStaff.Location = new System.Drawing.Point(3, 29);
            this.dgStaff.MultiSelect = false;
            this.dgStaff.Name = "dgStaff";
            this.dgStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgStaff.Size = new System.Drawing.Size(595, 398);
            this.dgStaff.TabIndex = 8;
            this.dgStaff.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgStaff_CellDoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(466, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(132, 20);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.Text = "Search...";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.Location = new System.Drawing.Point(3, 433);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cStaffNum
            // 
            this.cStaffNum.HeaderText = "Staff Number";
            this.cStaffNum.Name = "cStaffNum";
            this.cStaffNum.ReadOnly = true;
            // 
            // cFirstName
            // 
            this.cFirstName.HeaderText = "First Name";
            this.cFirstName.Name = "cFirstName";
            // 
            // cSurname
            // 
            this.cSurname.HeaderText = "Surname";
            this.cSurname.Name = "cSurname";
            // 
            // cEmail
            // 
            this.cEmail.HeaderText = "Email";
            this.cEmail.Name = "cEmail";
            this.cEmail.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cEmail.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cBalance
            // 
            this.cBalance.HeaderText = "Balance";
            this.cBalance.Name = "cBalance";
            // 
            // ViewStaffScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgStaff);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAdd);
            this.Name = "ViewStaffScreen";
            this.Size = new System.Drawing.Size(601, 459);
            ((System.ComponentModel.ISupportInitialize)(this.dgStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgStaff;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStaffNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSurname;
        private System.Windows.Forms.DataGridViewLinkColumn cEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBalance;
    }
}
