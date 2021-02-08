using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Date : IEntity
    {
        public int Id { get; set ; }
        public string Day { get; set; }
        public int MovieId { get; set; }
        public int SessionId { get; set; }
    }
}
