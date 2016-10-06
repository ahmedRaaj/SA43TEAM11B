using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.UI;
using LibraryManagementSystem.Dao;
namespace LibraryManagementSystem.Controller
{
   public class MemberContoller
    {
       public FormManageMembers FormManageMember { get; set; }
       private MemberDao memDao = new MemberDao();

        private List<Member> _memberList;


        public MemberContoller()
        {
            FormManageMember = new FormManageMembers(this);
         
            FormManageMember.cmbSearchType.DataSource = new string[] { "ID", "MemberName", "Details" };
        }

        public List<Member> Members
        {
            get
            {
                if (_memberList == null) _memberList = memDao.Members.ToList();
                return _memberList;
            }
        }

        public void ShowManageMeberForm()
        {
            FormManageMember.Show();
        }
        public void Reset()
        {
            _memberList = null;
        }

        public void Filter(string searchType, string keywords)
        {
            if (keywords == null || keywords == "" || keywords == " ")
            {
                FormManageMember.ShowMessage("Please input the keyword");
                return;
            }

            if (searchType.Equals("ID"))
            {
                int ID = Convert.ToInt32(keywords);
                _memberList = _memberList.Where(m => m.MemberID == ID).ToList();
            }
            else if (searchType.Equals("MemberName"))
            {
                _memberList = _memberList.Where(m => m.MemberName.Contains(keywords)).ToList();
            }


        }

        public bool SaveMember(string memberName, string city, string address, string phone, string eMail)
        {
            Member member = new Member();
            member.MemberName = memberName;
            member.City = city;
            member.Address = address;
            member.Phone = phone;
            member.Email = eMail;

            member.MembershipStatus = "Member";
            member.CreationDate = DateTime.Now.Date;

            memDao.Add(member);

            if (member != null)
            {
                return true;
            }
            else return false;
        }

        public bool UpdateMember(int memberID, string memberName, string city, string address, string phone, string eMail, string membershipStatus)
        {
            Member member = memDao.ct.Members.Where(mem => mem.MemberID == memberID).ToList().FirstOrDefault();
            if (member != null)
            {
                member.MemberID = memberID;
                member.MemberName = memberName;
                member.City = city;
                member.Address = address;
                member.Phone = phone;
                member.Email = eMail;
                member.MembershipStatus = membershipStatus;

                memDao.ct.SaveChanges();
                return true;
            }
            else return false;
        }

        public bool DaleteMember(int memberID)
        {
            Member member = memDao.ct.Members.Where(mem => mem.MemberID == memberID).ToList().FirstOrDefault();
            if (member != null)
            {
                memDao.Remove(member);
                return true;
            }
            else return false;
        }

    }
}
