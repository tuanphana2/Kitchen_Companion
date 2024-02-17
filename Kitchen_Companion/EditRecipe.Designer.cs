namespace Kitchen_Companion
{
    partial class frm_EditRecipe
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
            this.btn_Close = new System.Windows.Forms.Button();
            this.rtb_Materials = new System.Windows.Forms.RichTextBox();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.rtb_CP = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_NOD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(628, 595);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 27);
            this.btn_Close.TabIndex = 45;
            this.btn_Close.Text = "CLOSE";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // rtb_Materials
            // 
            this.rtb_Materials.Location = new System.Drawing.Point(117, 160);
            this.rtb_Materials.Name = "rtb_Materials";
            this.rtb_Materials.Size = new System.Drawing.Size(586, 191);
            this.rtb_Materials.TabIndex = 44;
            this.rtb_Materials.Text = "";
            // 
            // btn_Edit
            // 
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(378, 595);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(75, 27);
            this.btn_Edit.TabIndex = 43;
            this.btn_Edit.Text = "SAVE";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // rtb_CP
            // 
            this.rtb_CP.Location = new System.Drawing.Point(86, 386);
            this.rtb_CP.Name = "rtb_CP";
            this.rtb_CP.Size = new System.Drawing.Size(631, 203);
            this.rtb_CP.TabIndex = 42;
            this.rtb_CP.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(83, 365);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 18);
            this.label12.TabIndex = 41;
            this.label12.Text = "Cooking process";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 18);
            this.label3.TabIndex = 40;
            this.label3.Text = "Enter name and weight of materials";
            // 
            // txt_NOD
            // 
            this.txt_NOD.Location = new System.Drawing.Point(200, 94);
            this.txt_NOD.Name = "txt_NOD";
            this.txt_NOD.Size = new System.Drawing.Size(367, 22);
            this.txt_NOD.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 18);
            this.label2.TabIndex = 38;
            this.label2.Text = "Enter the name of dish";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(284, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 38);
            this.label1.TabIndex = 37;
            this.label1.Text = "EDIT RECIPES";
            // 
            // frm_EditRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 647);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.rtb_Materials);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.rtb_CP);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_NOD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_EditRecipe";
            this.Text = "EditRecipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.RichTextBox rtb_Materials;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.RichTextBox rtb_CP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_NOD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}