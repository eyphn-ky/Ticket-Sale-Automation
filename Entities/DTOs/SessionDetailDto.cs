using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class SessionDetailDto :IDto
    {
        public int SessionId { get; set; }
        public int MovieId { get; set; }
        public string Day { get; set; }
        public string MovieName { get; set; }
        public string SessionName { get; set; }

    }
}
