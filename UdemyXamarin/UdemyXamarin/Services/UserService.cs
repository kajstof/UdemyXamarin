using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UdemyXamarin.Models;

namespace UdemyXamarin.Services
{
    class UserService
    {
        private List<User> _users = new List<User>
        {
            new User { UserId = 1, Description = "My name is Jenny Dalby", Name = "Jenny Dalby" },
            new User { UserId = 2, Description = "My name is Jonv", Name = "Jonv" },
            new User { UserId = 3, Description = "My name is RachelMartin", Name = "RachelMartin" },
            new User { UserId = 4, Description = "My name is Nivan Jay", Name = "Nivan Jay" },
            new User { UserId = 5, Description = "My name is SanazZ", Name = "SanazZ" },
            new User { UserId = 6, Description = "My name is NextLab", Name = "NextLab" },
            new User { UserId = 7, Description = "My name is Alex B", Name = "AlexB" },
            new User { UserId = 8, Description = "My name is Tara Chang", Name = "Tara Chang" },
            new User { UserId = 9, Description = "My name is TomK", Name = "Tom K" }
        };

        public User GetUser(int userId)
        {
            return _users.SingleOrDefault(u => u.UserId == userId);
        }
    }
}
