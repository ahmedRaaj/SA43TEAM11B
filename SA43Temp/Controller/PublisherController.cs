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
        }
    }
}
