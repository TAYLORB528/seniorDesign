using System;
namespace Choosr.Models
{
    public class User
    {
        public string UserId { get; set; }

        public bool isAuthenticated { get; set; }

        public string Name { get; set; }

        public string AccessToken { get; set; }
    }
}
