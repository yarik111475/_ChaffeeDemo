using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using _ChaffeeDemo.Models;

namespace _ChaffeeDemo.Repositories {
    public interface IUserRepository {
        IEnumerable<UserModel> GetUsers();
    }
}
