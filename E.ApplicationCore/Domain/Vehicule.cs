using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.ApplicationCore.Domain
{
    public class Vehicule
    {

        [StringLength(25)]
        public String Couleur { get; set; }

        public int Kilometrage { get; set;}

        public double PrixJour { get; set; }

        public int VehivculeId { get; set; }

        public IList<Locataire> locataires { get; set; }
    }
}
