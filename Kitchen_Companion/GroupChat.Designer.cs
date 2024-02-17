namespace Kitchen_Companion
{
    partial class frm_GroupChat
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
            this.lbGroups = new System.Windows.Forms.ListBox();
            this.btn_CreateGroup = new System.Windows.Forms.Button();
            this.lbChat = new System.Windows.Forms.ListBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.txt_Nhap = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbGroups
            // 
            this.lbGroups.FormattingEnabled = true;
            this.lbGroups.ItemHeight = 16;
            this.lbGroups.Location = new System.Drawing.Point(53, 40);
            this.lbGroups.Name = "lbGroups";
            this.lbGroups.Size = new System.Drawing.Size(120, 340);
            this.lbGroups.TabIndex = 9;
            // 
            // btn_CreateGroup
            // 
            this.btn_CreateGroup.Location = new System.Drawing.Point(53, 388);
            this.btn_CreateGroup.Name = "btn_CreateGroup";
            this.btn_CreateGroup.Size = new System.Drawing.Size(120, 23);
            this.btn_CreateGroup.TabIndex = 8;
            this.btn_CreateGroup.Text = "CreateGroup";
            this.btn_CreateGroup.UseVisualStyleBackColor = true;
            // 
            // lbChat
            // 
            this.lbChat.FormattingEnabled = true;
            this.lbChat.ItemHeight = 16;
            this.lbChat.Location = new System.Drawing.Point(178, 40);
            this.lbChat.Name = "lbChat";
            this.lbChat.Size = new System.Drawing.Size(570, 340);
            this.lbChat.TabIndex = 7;
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(636, 388);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 6;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            // 
            // txt_Nhap
            // 
            this.txt_Nhap.Location = new System.Drawing.Point(199, 388);
            this.txt_Nhap.Name = "txt_Nhap";
            this.txt_Nhap.Size = new System.Drawing.Size(407, 22);
            this.txt_Nhap.TabIndex = 5;
            // 
            // frm_GroupChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbGroups);
            this.Controls.Add(this.btn_CreateGroup);
            this.Controls.Add(this.lbChat);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.txt_Nhap);
            this.Name = "frm_GroupChat";
            this.Text = "GroupChat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbGroups;
        private System.Windows.Forms.Button btn_CreateGroup;
        private System.Windows.Forms.ListBox lbChat;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox txt_Nhap;
    }
}