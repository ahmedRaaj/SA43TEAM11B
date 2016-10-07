using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA43Temp.Dao
{
    public class MemberDao : AbstaractDao<Member>
    {
        public override DbSet getDataSet()
        {
            return ct.Members;
        }

        public DbSet<Member> Members { get { return ct.Members; } }
    }
}
