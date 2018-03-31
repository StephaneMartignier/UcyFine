using System;
using System.Linq;
using System.Collections.Generic;
using UcyFine.Models;

namespace UcyFine.Data
{
    public static class DbInitializer
    {
        public static void Initialize(UcyFineContext context)
        {
            context.Database.EnsureCreated();

            if (context.Players.Any())
            {
                return; // DB has been seeded
            }

            // Use Array instead of List<T> to optimize performance
            var players = new Player[]
            {
                new Player{ FirstName = "Stéphane", LastName = "Martignier" },
                new Player{ FirstName = "Robin", LastName = "Walhter" },
                new Player{ FirstName = "Bastien", LastName = "Wolfer" }
            };

            foreach (Player p in players)
            {
                context.Players.Add(p);
            }
            context.SaveChanges();

            var fines = new Fine[]
            {
                new Fine{ Type = "Excuse en retard", Amount = 5.00m },
                new Fine{ Type = "Non excusé", Amount = 10.00m },
            };

            foreach (Fine f in fines)
            {
                context.Players.Add(f);
            }
            context.SaveChanges();
        }
    }
}
