namespace Kitchen_Companion
{
    partial class frm_CreateGroup
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteGroup = new System.Windows.Forms.Button();
            this.btnEditGroup = new System.Windows.Forms.Button();
            this.lbCreatedGroups = new System.Windows.Forms.ListBox();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.btn_Create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 406);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Group Name";
            // 
            // btnDeleteGroup
            // 
            this.btnDeleteGroup.Location = new System.Drawing.Point(647, 399);
            this.btnDeleteGroup.Name = "btnDeleteGroup";
            this.btnDeleteGroup.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteGroup.TabIndex = 10;
            this.btnDeleteGroup.Text = "Delete";
            this.btnDeleteGroup.UseVisualStyleBackColor = true;
            // 
            // btnEditGroup
            // 
            this.btnEditGroup.Location = new System.Drawing.Point(543, 399);
            this.btnEditGroup.Name = "btnEditGroup";
            this.btnEditGroup.Size = new System.Drawing.Size(75, 23);
            this.btnEditGroup.TabIndex = 9;
            this.btnEditGroup.Text = "Edit";
            this.btnEditGroup.UseVisualStyleBackColor = true;
            // 
            // lbCreatedGroups
            // 
            this.lbCreatedGroups.FormattingEnabled = true;
            this.lbCreatedGroups.ItemHeight = 16;
            this.lbCreatedGroups.Location = new System.Drawing.Point(79, 28);
            this.lbCreatedGroups.Name = "lbCreatedGroups";
            this.lbCreatedGroups.Size = new System.Drawing.Size(643, 356);
            this.lbCreatedGroups.TabIndex = 8;
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(170, 400);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(162, 22);
            this.txtGroupName.TabIndex = 7;
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(359, 400);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(157, 23);
            this.btn_Create.TabIndex = 6;
            this.btn_Create.Text = "CreateGroup";
            this.btn_Create.UseVisualStyleBackColor = true;
            // 
            // frm_CreateGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteGroup);
            this.Controls.Add(this.btnEditGroup);
            this.Controls.Add(this.lbCreatedGroups);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.btn_Create);
            this.Name = "frm_CreateGroup";
            this.Text = "CreateGroup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteGroup;
        private System.Windows.Forms.Button btnEditGroup;
        private System.Windows.Forms.ListBox lbCreatedGroups;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Button btn_Create;
    }
}