using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitchen_Companion
{
    public partial class frm_HomePage : Form
    {
        public string tdn { get; set; }
        public frm_HomePage()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        public void LoadForm()
        {
            if (tdn == "" || tdn == null)
                accountToolStripMenuItem.Text = "Login";
            else
                accountToolStripMenuItem.Text = "Logout";
        }
        private void yourRecipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllForm();
            if (tdn == "" || tdn == null)
                MessageBox.Show("You must login fisrt!");
            else if (Application.OpenForms["frm_YourRecipe"] == null)
            {
                frm_YourRecipe NV = new frm_YourRecipe();
                NV.tdn = tdn;
                NV.MdiParent = this;
                NV.Show();
            }
            else Application.OpenForms["frm_YourRecipe"].Activate();
        }

        private void tipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllForm();
            if (Application.OpenForms["frm_Tips"] == null)
            {
                frm_Tips NV = new frm_Tips();
                NV.tdn = tdn;
                NV.MdiParent = this;
                NV.Show();
            }
            else Application.OpenForms["frm_Tips"].Activate();
        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllForm();
            if (tdn == "" || tdn == null)
                MessageBox.Show("You must login fisrt!");
            else if (Application.OpenForms["frm_GroupChat"] == null)
            {
                frm_GroupChat NV = new frm_GroupChat();
                NV.tdn = tdn;
                NV.MdiParent = this;
                NV.Show();
            }
            else Application.OpenForms["frm_GroupChat"].Activate();
        }

        private void spendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllForm();
            if (tdn == "" || tdn == null)
                MessageBox.Show("You must login fisrt!");
            else if (Application.OpenForms["frm_SPENDING"] == null)
            {
                frm_SPENDING NV = new frm_SPENDING();
                NV.tdn = tdn;
                NV.MdiParent = this;
                NV.Show();
            }
            else Application.OpenForms["frm_SPENDING"].Activate();
        }

        private void personalInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllForm();
            if (tdn == "" || tdn == null)
                MessageBox.Show("You must login fisrt!");
            else if (Application.OpenForms["frm_Personal_Information"] == null)
            {
                frm_Personal_Information NV = new frm_Personal_Information();
                NV.tdn = tdn;
                NV.MdiParent = this;
                NV.Show();
            }
            else Application.OpenForms["frm_Personal_Information"].Activate();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllForm();
            if (Application.OpenForms["frm_Search"] == null)
            {
                frm_Search NV = new frm_Search();
                NV.MdiParent = this;
                NV.Show();
            }
            else Application.OpenForms["frm_Search"].Activate();
        }

        private void yourRecipeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseAllForm();
            if (tdn == "" || tdn == null)
                MessageBox.Show("You must login fisrt!");
            else if (Application.OpenForms["frm_YourRecipe"] == null)
            {
                frm_YourRecipe NV = new frm_YourRecipe();
                NV.tdn = tdn;
                NV.MdiParent = this;
                NV.Show();
            }
            else Application.OpenForms["frm_YourRecipe"].Activate();
        }

        private void tipsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseAllForm();
            if (Application.OpenForms["frm_Tips"] == null)
            {
                frm_Tips NV = new frm_Tips();
                NV.tdn = tdn;
                NV.MdiParent = this;
                NV.Show();
            }
            else Application.OpenForms["frm_Tips"].Activate();
        }

        private void groupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseAllForm();
            if (tdn == "" || tdn == null)
                MessageBox.Show("You must login fisrt!");
            else if (Application.OpenForms["frm_GroupChat"] == null)
            {
                frm_GroupChat NV = new frm_GroupChat();
                NV.tdn = tdn;
                NV.MdiParent = this;
                NV.Show();
            }
            else Application.OpenForms["frm_GroupChat"].Activate();
        }

        private void spendingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseAllForm();
            if (tdn == "" || tdn == null)
                MessageBox.Show("You must login fisrt!");
            else if (Application.OpenForms["frm_SPENDING"] == null)
            {
                frm_SPENDING NV = new frm_SPENDING();
                NV.tdn = tdn;
                NV.MdiParent = this;
                NV.Show();
            }
            else Application.OpenForms["frm_SPENDING"].Activate();
        }

        private void personalInformationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseAllForm();
            if (tdn == "" || tdn == null)
                MessageBox.Show("You must login fisrt!");
            else if (Application.OpenForms["frm_Personal_Information"] == null)
            {
                frm_Personal_Information NV = new frm_Personal_Information();
                NV.tdn = tdn;
                NV.MdiParent = this;
                NV.Show();
            }
            else Application.OpenForms["frm_Personal_Information"].Activate();
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseAllForm();
            if (Application.OpenForms["frm_Search"] == null)
            {
                frm_Search NV = new frm_Search();
                NV.MdiParent = this;
                NV.Show();
            }
            else Application.OpenForms["frm_Search"].Activate();
        }
        private void CloseForm(string formName)
        {
            Form activeForm = this.ActiveMdiChild;
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }
        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllForm();
            if (tdn == "" || tdn == null)
            {
                if (Application.OpenForms["frmLogin"] == null)
                {
                    frm_Login NV = new frm_Login();
                    NV.MdiParent = this;
                    NV.Show();
                }
                else Application.OpenForms["frmLogin"].Activate();
            }
            else
            {
                tdn = "";
                MessageBox.Show("Logout success");
                LoadForm();
            }
        }
        private void CloseAllForm()
        {
            CloseForm("frmLogin");
            CloseForm("frmRegister");
            CloseForm("frm_YourRecipe");
            CloseForm("frm_Tips");
            CloseForm("frm_GroupChat");
            CloseForm("frm_SPENDING");
            CloseForm("frm_Personal_Information");
            CloseForm("frm_Search");
            CloseForm("frm_CreateGroup");
            CloseForm("frm_AddRecipe");
            CloseForm("frm_EditRecipe");
            CloseForm("frm_Detail");
        }
        private void frm_HomePage_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
}
