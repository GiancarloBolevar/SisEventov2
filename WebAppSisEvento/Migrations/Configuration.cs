namespace WebAppSisEvento.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAppSisEvento.Models.WebAppSisEventoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WebAppSisEvento.Models.WebAppSisEventoContext context)
        {
 
        }
    }
}
