using System;
namespace Choosr.Models
{
    public class GamePlay
    {
        public int UserId { get; set; }

        public string SessionId { get; set; }

        public string JoinCode { get; set; }

        public string Title { get; set; }

        public string Genre { get; set; }

        public int SwipeAction { get; set; }
    }
}
