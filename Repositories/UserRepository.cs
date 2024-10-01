using BodegaVinos.Models;

namespace BodegaVinos.Repositories
{
    public class UserRepository
    {
        public List<User> Users = new List<User>
        {
            new User { Id = 1, Username = "user1", Password = "password123" },
            new User { Id = 2, Username = "user2", Password = "password234" },
            new User { Id = 3, Username = "user3", Password = "password345" },
            new User { Id = 4, Username = "user4", Password = "password456" },
            new User { Id = 5, Username = "user5", Password = "password567" },
            new User { Id = 6, Username = "user6", Password = "password678" },
            new User { Id = 7, Username = "user7", Password = "password789" },
            new User { Id = 8, Username = "user8", Password = "password890" },
            new User { Id = 9, Username = "user9", Password = "password901" },
            new User { Id = 10, Username = "user10", Password = "password012" }
        };
    }
}
