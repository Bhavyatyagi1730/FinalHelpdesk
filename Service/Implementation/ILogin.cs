using Service.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Implementation
{
    public interface ILogin
    {
        Userrole GetinfoByUserCredentials(string email, string password, string roleType);
    }
}
