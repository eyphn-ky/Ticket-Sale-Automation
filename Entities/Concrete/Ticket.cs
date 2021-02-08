using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Ticket : IEntity
    {
        public int Id { get; set; }
        public int SeatId { get; set; }
        public decimal Price { get; set; }
        public int CustomerId { get; set; }
        public int SaloonId { get; set; }
        public int MovieId { get; set; }
        public int TypeId { get; set; }

    }
}
