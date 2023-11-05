using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace E.ApplicationCore.Domain
{
    public class Reservation
    {
        public DateTime DateReservation { get; set; }
        public int DureeJours { get; set;}

        public int LocataireFK { get; set; }
        
        public int locatairekey { get; set; }

        public int vehiculekey { get; set; }

    }
}
