using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Saloon : IEntity
    {
        public int Id { get; set; }
        public int SeatInSaloon { get; set; }
        public string Number { get; set; }

    }
}
