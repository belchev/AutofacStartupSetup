using AutofacStartupSetup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutofacStartupSetup.Repositories.UserRepo
{
    public interface IUserRepo : IRepository<User>
    {
        List<User> GetAll();
    }
}