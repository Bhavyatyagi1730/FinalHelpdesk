using Model;
using Service.Implementation;
using Service.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.CLass
{
    public class Login : ILogin
    {
        HelpDeskDBEntities db1 = new HelpDeskDBEntities();
        public Userrole GetinfoByUserCredentials(string email, string password, string roleType)
        {
            Userrole user = new Userrole();
            User roledata = db1.Users.Where(m => m.Email == email && m.Password == password && m.Roletype==roleType).FirstOrDefault();
            if (roledata != null)
            {
                user.Email = roledata.Email;
                user.Password = roledata.Password;
                user.Roletype = roledata.Roletype;
            }
           
            return user;
        }
    }
}
