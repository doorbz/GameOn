using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOn.ModelClasses;

namespace GameOn.DataLayer.Managers
{
    public class UserManager : DbManager<GameOnContext>
    {
        public List<User> GetList()
        {
            List<User> list = null;
            Connect(datebase => { list = datebase.Users.ToList(); });
            return list;
        }
    }
}
