using Capstone.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Domain.Abstract
{
    public interface UserInterface
    {
        public void AddUser(User u);
        public User GetUser(string name);
        public void DeleteUser(string name);
        public void EditUser(string name);
    }
}
