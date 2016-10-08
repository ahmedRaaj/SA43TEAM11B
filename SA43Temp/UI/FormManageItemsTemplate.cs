using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.UI
{
    public partial class FormManageItemsTemplate : Form
    {
    
        public FormManageItemsTemplate()
        {
            InitializeComponent();
            this.dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgv.MultiSelect = false;
            this.SuspendLayout();
            this.Size = new System.Drawing.Size(SystemInformation.WorkingArea.Width, SystemInformation.WorkingArea.Height);
            this.MinimumSize = new System.Drawing.Size(SystemInformation.WorkingArea.Width, SystemInformation.WorkingArea.Height);
            this.ResumeLayout(false);
            this.PerformLayout();


        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
