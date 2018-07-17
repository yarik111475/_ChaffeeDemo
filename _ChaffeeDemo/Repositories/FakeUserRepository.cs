using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using _ChaffeeDemo.Models;

namespace _ChaffeeDemo.Repositories {
    public class FakeUserRepository : IUserRepository {
        public IEnumerable<UserModel> GetUsers() {
            List<UserModel> users = new List<UserModel> {
                new UserModel{Id=0, Firstname="First001", Lastname="Last001", Age=12 },
                new UserModel{Id=1, Firstname="First002", Lastname="Last002", Age=28 },
                new UserModel{Id=2, Firstname="First003", Lastname="Last003", Age=17 },
                new UserModel{Id=3, Firstname="First004", Lastname="Last004", Age=19 }
            };
            return users.ToArray();
        }
    }
}
