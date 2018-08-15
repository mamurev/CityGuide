using System.Collections.Generic;

namespace CityGuide.API.Models
{
    public class User
    {
        public User()
        {
            Cities = new List<City>();
        }
        public int Id { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string UserName { get; set; }

        public List<City> Cities { get; set; }
    }
}
