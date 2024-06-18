using System.Collections.Generic;
using Floricultura.Models;

namespace Floricultura.Data
{
    public static class FlorData
    {
        private static List<Flor> flores = new List<Flor>
        {
            new Flor { Id = 1, Nome = "Rosa", QuantidadeEstoque = 100 },
            new Flor { Id = 2, Nome = "Tulipa", QuantidadeEstoque = 50 },
        };

        public static List<Flor> GetFlores()
        {
            return flores;
        }

        public static void AddFlor(Flor flor)
        {
            flores.Add(flor);
        }

        public static void UpdateFlor(Flor flor)
        {
            var existingFlor = flores.Find(f => f.Id == flor.Id);
            if (existingFlor != null)
            {
                existingFlor.Nome = flor.Nome;
                existingFlor.QuantidadeEstoque = flor.QuantidadeEstoque;
            }
        }

        public static void DeleteFlor(int id)
        {
            var flor = flores.Find(f => f.Id == id);
            if (flor != null)
            {
                flores.Remove(flor);
            }
        }
    }
}
