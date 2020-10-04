using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using OrionInnovation.Domain;

namespace OrionInnovation.Persistence
{
    public static class DbInitializer
    {        
        public static void Initialize(OrionInnovationSqlDbContext context)
        {
            context.Database.Migrate();
            context.Database.EnsureCreated();
        }

        public static void SeedText(OrionInnovationSqlDbContext context) {
            if (context.Set<Text>().Any())
            {
                return; // Db has been seeded;
            }

            var textList = new Text[]
            {
                Text.Create("Sample text from Nikola Bojkovic!", new DateTime(2020, 10, 1)),
                Text.Create("More text for testing", new DateTime(2020, 10, 5)),
            };

            context.Set<Text>().AddRange(textList);
            context.SaveChanges();
        }
    }
}