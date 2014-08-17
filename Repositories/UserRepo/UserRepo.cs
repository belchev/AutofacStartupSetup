using AutofacStartupSetup.Models;
using AutofacStartupSetup.Utils.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutofacStartupSetup.Repositories.UserRepo
{
    public class UserRepo : Repository<User>, IUserRepo
    {
        public UserRepo(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        public List<User> GetAll()
        {
            return this.unitOfWork.DbContext.Set<User>().ToList();
        }
    }
}