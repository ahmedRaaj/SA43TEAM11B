using SA43Temp.Controller;
using SA43Temp.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA43Temp.UI
{
    public partial class FormPublisherCrud : Form
    {
        private PublisherController PublisherController=new PublisherController();
        private bool create;
        private CategoryDao catDao = new CategoryDao();
        private PublisherDao pubDao = new PublisherDao();
        int ID;

        public FormPublisherCrud()
        {
            InitializeComponent();
        }

        public FormPublisherCrud(PublisherController publisherContorller, bool create):this()
        {
            this.PublisherController = publisherContorller;
            this.create = create;
                       
        }

        public void UpdateFields(int pubId, string pubName, string pubWeb, string pubdetails)
        {
            this.ID = pubId;
            tbPublisherName.Text = pubName;
            tbWebsite.Text = pubWeb;
            tbDetials.Text = pubdetails;           

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string Name = tbPublisherName.Text;
            string Website = tbWebsite.Text;
            string Details = tbDetials.Text;

            if (create)
            {
                if (PublisherController.SavePublisher(Name, Website, Details))
                {
                    this.Close();
                    PublisherController.Refresh();
                    MessageBox.Show("Save success");
                }
                else
                { MessageBox.Show("Save failed"); }

            }
            else
            {
                if (PublisherController.UpdatePublisher(ID, Name, Website, Details))
                {
                    this.Close();
                    PublisherController.Refresh();
                    PublisherController.Refresh();
                    MessageBox.Show("Update success");
                }
                else
                { MessageBox.Show("Update failed"); }

            }
       
        }

        private void btnCancel_Click(object sender, EventArgs e)       
        {
            this.Close();
        }
   
    }
}
