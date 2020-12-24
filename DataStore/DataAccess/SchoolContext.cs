using System.Data.Entity;
using PersonDomain.Students;
using PersonDomain.Teachers;

namespace DataStore.DataAccess
{
    public class SchoolContext : DbContext
    {
        public IDbSet<IStudent> Students { get; set; }
        public IDbSet<ITeacher> Teachers { get; set; }
    }
}
