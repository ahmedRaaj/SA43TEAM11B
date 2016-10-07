using LibraryManagementSystem.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.UI;

namespace LibraryManagementSystem.Controller
{
   public class PublisherController
    {
        private List<Publisher> _publisherList;
        private PublisherDao pubDao;
        private FormManagePublishers formPublishers;
        private UI.FormPublisherCrud pubCrud;
        public List<Publisher> CategoryList
        {
            get
            {
                if (_publisherList == null) _publisherList = pubDao.Publishers.ToList();
                return _publisherList;
            }
        }

        public PublisherController()
        {
            pubDao = new PublisherDao();
            formPublishers = new FormManagePublishers(this);
            formPublishers.cmbSearchType.DataSource = new string[] { "ID", "PublisherName", "Details" };

        }

        public void InitialCrud(bool create)
        {
            FormPublisherCrud FromPublisher = new FormPublisherCrud(this,create);
            if (!create)
            {
                Publisher pub = formPublishers.dgv.SelectedRows[0].DataBoundItem as Publisher;
                FromPublisher.UpdateFields(pub.PublisherID, pub.PublisherName, pub.PublisherWeb, pub.PublisherDetails);
            }
            FromPublisher.Show();
        }
        public void ShowManagePublisherForm()
        {
            formPublishers.Show();
        }

        public void Filter(string searchType, string keywords)
        {
            if (keywords == null || keywords == "" || keywords == " ")
            {
                formPublishers.ShowMessage("Please input the keyword");
                return;
            }

            if (searchType.Equals("ID"))
            {
                int ID = Convert.ToInt32(keywords);
                _publisherList = _publisherList.Where( p=> p.PublisherID == ID).ToList();
            }
            else if (searchType.Equals("PublisherName"))
            {
                _publisherList = _publisherList.Where(p => p.PublisherName.Contains(keywords)).ToList();
            }


        }

        public void Refresh()
        {
            this._publisherList = null;

            formPublishers.dgv.DataSource = null;
            formPublishers.dgv.DataSource = CategoryList;
        }

        public bool SavePublisher(string name,string website,string details)
        {
            Publisher pub = new Publisher();
            pub.PublisherName = name;
            pub.PublisherWeb = website;
            pub.PublisherDetails = details;
            pubDao.Add(pub);

            if (pub != null)
            {
                return true;
            }
            else return false;
        }

        public bool UpdatePublisher(int pubId, string name, string website, string details)
        {
            Publisher pub = pubDao.ct.Publishers.Where(p => p.PublisherID == pubId).ToList().FirstOrDefault();
            if (pub != null)
            {
                pub.PublisherID = pubId;
                pub.PublisherName = name;
                pub.PublisherDetails = details;

                pubDao.ct.SaveChanges();
                return true;
            }
            else return false;
        }
        public bool DeletePublisher(int pubID)
        {
            Publisher pub = pubDao.ct.Publishers.Where(p => p.PublisherID == pubID).ToList().FirstOrDefault();
            if (pub != null)
            {
                pubDao.Remove(pub);
                return true;
            }
            else return false;
        }
    }
}
