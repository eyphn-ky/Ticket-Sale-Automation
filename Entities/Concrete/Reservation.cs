using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Reservation : IEntity
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public int SaloonId { get; set; }
        public int SeatId { get; set; }
        public int MovieId { get; set; }
        public int SessionId { get; set; }
        public int CustomerId { get; set; }


    }
}
