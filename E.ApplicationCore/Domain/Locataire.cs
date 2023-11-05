using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.ApplicationCore.Domain
{
    public class Locataire
    {

        [Required(ErrorMessage = "message d'erreur ")]
        public string Adresse { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateAdhesion { get; set; }

        public int Id { get; set; }
        
        public int PointsBonus { get; set; }

        public String Telephone { get; set;}


        public Agent agents  { get; set; }

        public IList<Vehicule> vehicule { get; set; }

        public int LocataireKey { get; set; }

    }
}
