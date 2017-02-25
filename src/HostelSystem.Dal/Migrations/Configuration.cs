using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;
using HostelSystem.Domain;

namespace HostelSystem.Dal.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HostelSystem.Dal.HostelSystemDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HostelSystem.Dal.HostelSystemDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            SeedGoscie(context);
            SeedRezerwacja(context);
        }

        private static void SeedGoscie(HostelSystemDbContext context)
        {
            var g1 = new Gosc
            {
                Imie = "Micha³",
                Nazwisko = "G³owaczewski",
                Email = "michalglowaczewski@gmail.com"
            };

            var g2 = new Gosc
            {
                Imie = "Jan",
                Nazwisko = "Kowalski",
                Email = "j.kowalski@gmail.com"
            };

            var g3 = new Gosc
            {
                Imie = "Anna",
                Nazwisko = "Malinowska",
                Email = "a.malinowska@gmail.com"
            };

            var g4 = new Gosc
            {
                Imie = "Zbysiu",
                Nazwisko = "Koliszczak",
                Email = "z.koliszczak@gmail.com"
            };

            var g5 = new Gosc
            {
                Imie = "Magdalena",
                Nazwisko = "Nowacka",
                Email = "m.nowacka@gmail.com"
            };

            var g6 = new Gosc
            {
                Imie = "Krysia",
                Nazwisko = "Celiñska",
                Email = "k.celinska@gmail.com"
            };

            Gosc[] goscie = { g1, g2, g3, g4, g5, g6 };
            context.Gosc.AddOrUpdate(g => g.Email, goscie);
            context.SaveChanges();
        }

        private static void SeedRezerwacja(HostelSystemDbContext context)
        {
            var r1 = new Rezerwacja
            {
                DataUtworzenia = DateTime.UtcNow,
                KodRezerwacji = "Abc123",
                Cena = 1000,
                DataZameldowania = DateTime.UtcNow.AddHours(1),
                DataWymeldowania = DateTime.UtcNow.AddDays(1),
                Prowizja = 500
            };

            var r2 = new Rezerwacja
            {
                DataUtworzenia = DateTime.UtcNow,
                KodRezerwacji = "Def456",
                Cena = 3000,
                DataZameldowania = DateTime.UtcNow.AddDays(1),
                DataWymeldowania = DateTime.UtcNow.AddDays(4),
                Prowizja = 1000
            };

            var r3 = new Rezerwacja
            {
                DataUtworzenia = DateTime.UtcNow.AddDays(-10),
                KodRezerwacji = "Ghj789",
                Cena = 7000,
                DataZameldowania = DateTime.UtcNow.AddHours(-8),
                DataWymeldowania = DateTime.UtcNow.AddDays(-1),
                Prowizja = 4000
            };

            Rezerwacja[] rezerwacje = { r1, r2, r3 };
            context.Rezerwacja.AddOrUpdate(r => r.KodRezerwacji, rezerwacje);
            context.SaveChanges();

            context.Entry(r1).Collection(r => r.Goscie).Load();
            context.Entry(r2).Collection(r => r.Goscie).Load();
            context.Entry(r3).Collection(r => r.Goscie).Load();

            var g1 = context.Gosc.Single(g => g.Email.Equals("michalglowaczewski@gmail.com"));
            var g2 = context.Gosc.Single(g => g.Email.Equals("j.kowalski@gmail.com"));
            var g3 = context.Gosc.Single(g => g.Email.Equals("a.malinowska@gmail.com"));
            var g4 = context.Gosc.Single(g => g.Email.Equals("z.koliszczak@gmail.com"));
            var g5 = context.Gosc.Single(g => g.Email.Equals("m.nowacka@gmail.com"));
            var g6 = context.Gosc.Single(g => g.Email.Equals("k.celinska@gmail.com"));

            r1.Goscie.Add(g1);
            r1.Goscie.Add(g2);
            r2.Goscie.Add(g3);
            r2.Goscie.Add(g4);
            r2.Goscie.Add(g5);
            r3.Goscie.Add(g6);
        }
    }
}
