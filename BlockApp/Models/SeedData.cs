using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BlockApp.Data;
using System;
using System.Linq;

namespace BlockApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new EthereumDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<EthereumDbContext>>()))
            {
                // Look for any movies.
                if (context.EthereumTransaction.Any())
                {
                    return;   // DB has been seeded
                }

                context.EthereumTransaction.AddRange(
                    new EthereumTransaction
                    {
                        BlockHash = "123",
                        BlockNumber = 123,
                        Gas = "123",
                        Hash = "123",
                        From = DateTime.Now.AddDays(-1),
                        To = DateTime.Now.AddDays(-1).AddHours(1),
                        Value = "hiya"
                    },

                    new EthereumTransaction
                    {
                        BlockHash = "123",
                        BlockNumber = 1234,
                        Gas = "1234",
                        Hash = "11223",
                        From = DateTime.Now.AddDays(-1),
                        To = DateTime.Now.AddDays(-1).AddHours(1),
                        Value = "hiyahello"
                    },

                    new EthereumTransaction
                    {
                        BlockHash = "12345",
                        BlockNumber = 12345,
                        Gas = "12345",
                        Hash = "12345",
                        From = DateTime.Now.AddDays(-1),
                        To = DateTime.Now.AddDays(-1).AddHours(1),
                        Value = "bye"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}