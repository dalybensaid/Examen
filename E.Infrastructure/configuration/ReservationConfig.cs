using E.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace E.Infrastructure.configuration
{
    public class ReservationConfig : IEntityTypeConfiguration<Reservation>

       
    {
        private object modelBuilder;

        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasKey(p => new
            {
                p.locatairekey,
                p.vehiculekey,
                p.DateReservation
            });


            

            modelBuilder.Entity<Locataire>().HasMany(f => f.Reservation)
              .WithOne(testc => t.Locataire).HasForeignKey(t => t.locatairekey);




            modelBuilder.Entity<Locataire>()
           .HasDiscriminator<int>("typelocataire")
           .HasValue<Locataire>(0)
           .HasValue<Personne>(1)
           .HasValue<Entreprise>(2);
        }




    }


}
}
