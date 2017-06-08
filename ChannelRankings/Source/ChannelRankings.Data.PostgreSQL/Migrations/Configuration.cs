namespace ChannelRankings.Data.PostgreSQL.Migrations
{
    using ChannelRankings.Data.PostgreSQL.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ChannelRankings.Data.PostgreSQL.LegacyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ChannelRankings.Data.PostgreSQL.LegacyContext context)
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

            context.Countries.AddOrUpdate(c => c.Name, 
                new Country { Name = "Russia" },
                new Country { Name = "Ukraine" },
                new Country { Name = "Belarus" },
                new Country { Name = "Moldova" },
                new Country { Name = "Kazahstan" },
                new Country { Name = "Uzbekistan" },
                new Country { Name = "Georgia" },
                new Country { Name = "Azerbaijan" },
                new Country { Name = "Lithuania" },
                new Country { Name = "Latvia" },
                new Country { Name = "Kirghizia" },
                new Country { Name = "Tajikistan" },
                new Country { Name = "Armenia" },
                new Country { Name = "Estoniaa" },
                new Country { Name = "Turkmenia" });

            context.Directors.AddOrUpdate(d => d.Name,
                new Director { Name = "Artyom Vasilevich" },
                new Director { Name = "Dima Chruschov" },
                new Director { Name = "Ermolay Valeev" },
                new Director { Name = "Nikolay Valuev" },
                new Director { Name = "Vitali Klichko" },
                new Director { Name = "Maksim Kuzmanaev" },
                new Director { Name = "Pyotr Rushchov" },
                new Director { Name = "Rasputin Ruslanovich" },
                new Director { Name = "Vadik Kachenko" },
                new Director { Name = "Vadim Olaev" },
                new Director { Name = "Volya Babuev" },
                new Director { Name = "Yegor Gadjev" },
                new Director { Name = "Evgeni Krivenko" },
                new Director { Name = "Volodya Luenko" },
                new Director { Name = "Kazimir Talev" }
                );

            string[] countries = {
                "Russia" ,
                "Ukraine" ,
                "Belarus",
                "Moldova",
                "Kazahstan",
                "Uzbekistan",
                "Georgia",
                "Azerbaijan",
                "Lithuania",
                "Latvia",
                "Kirghizia",
                "Tajikistan",
                "Armenia",
                "Estoniaa",
                "Turkmenia" };

            string[] directorNames =   {
                "Artyom Vasilevich",
                "Dima Chruschov",
                "Ermolay Valeev",
                "Nikolay Valuev",
                "Vitali Klichko",
                "Maksim Kuzmanaev",
                "Pyotr Rushchov",
                "Rasputin Ruslanovich",
                "Vadik Kachenko",
                "Vadim Olaev",
                "Taras Stasev",
                "Volya Babuev",
                "Volya Babuev" ,
                "Yegor Gadjev",
                "Evgeni Krivenko",
                "Volodya Luenko",
                "Kazimir Talev"  };

           

        }
    }
}
