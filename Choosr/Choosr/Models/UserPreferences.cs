using System;
namespace Choosr.Models
{
    public class UserPreferences
    {
        public int UserId { get; set; }

        public int Action { get; set; }

        public int Romance { get; set; }

        public int Comedy { get; set; }
    }
}
