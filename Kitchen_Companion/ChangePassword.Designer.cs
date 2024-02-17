namespace Kitchen_Companion
{
    partial class frm_Change
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
            this.txt_Old = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Change = new System.Windows.Forms.Button();
            this.txt_Confirm = new System.Windows.Forms.TextBox();
            this.txt_New = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Old
            // 
            this.txt_Old.Location = new System.Drawing.Point(342, 134);
            this.txt_Old.Name = "txt_Old";
            this.txt_Old.Size = new System.Drawing.Size(187, 22);
            this.txt_Old.TabIndex = 48;
            this.txt_Old.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(221, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(376, 38);
            this.label5.TabIndex = 47;
            this.label5.Text = "CHANGE PASSWORD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "Old password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 45;
            this.label2.Text = "Confirm password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "New password";
            // 
            // btn_Change
            // 
            this.btn_Change.Location = new System.Drawing.Point(331, 371);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(102, 39);
            this.btn_Change.TabIndex = 43;
            this.btn_Change.Text = "SAVE";
            this.btn_Change.UseVisualStyleBackColor = true;
            // 
            // txt_Confirm
            // 
            this.txt_Confirm.Location = new System.Drawing.Point(342, 217);
            this.txt_Confirm.Name = "txt_Confirm";
            this.txt_Confirm.Size = new System.Drawing.Size(187, 22);
            this.txt_Confirm.TabIndex = 42;
            this.txt_Confirm.UseSystemPasswordChar = true;
            // 
            // txt_New
            // 
            this.txt_New.Location = new System.Drawing.Point(342, 176);
            this.txt_New.Name = "txt_New";
            this.txt_New.Size = new System.Drawing.Size(187, 22);
            this.txt_New.TabIndex = 41;
            this.txt_New.UseSystemPasswordChar = true;
            // 
            // frm_ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Old);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.txt_Confirm);
            this.Controls.Add(this.txt_New);
            this.Name = "frm_ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Old;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Change;
        private System.Windows.Forms.TextBox txt_Confirm;
        private System.Windows.Forms.TextBox txt_New;
    }
}