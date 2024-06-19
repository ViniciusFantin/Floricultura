using System.Collections.Generic;
using Floricultura.Models;

namespace Floricultura.Data
{
    public static class FlorData
    {
        
        // Lista de flores inicial com dois exemplos de flores.
        private static List<Flor> flores = new List<Flor>
        {
            new Flor { Id = 1, Nome = "Rosa", QuantidadeEstoque = 71, ValorEmReais = 5.50m },
            new Flor { Id = 2, Nome = "Tulipa", QuantidadeEstoque = 52, ValorEmReais = 7.75m },
        };

        private static int nextId = 3; // Variável para controlar o próximo ID disponível

        public static List<Flor> GetFlores() // Método para obter a lista de flores
        {
            return flores;
        }

        public static void AddFlor(Flor flor) 
        {
            flor.Id = nextId++; // Atribui o próximo ID e incrementa
            flores.Add(flor);
        }

        public static void UpdateFlor(Flor flor)    // Método para atualizar uma flor existente
        {
            var existingFlor = flores.Find(f => f.Id == flor.Id);
            if (existingFlor != null)
            {
                existingFlor.Nome = flor.Nome;
                existingFlor.QuantidadeEstoque = flor.QuantidadeEstoque;
                existingFlor.ValorEmReais = flor.ValorEmReais;
            }
        }

        public static void DeleteFlor(int id) // Método para deletar uma flor da lista
        {
            var flor = flores.Find(f => f.Id == id);
            if (flor != null)
            {
                flores.Remove(flor);
            }
        }
    }
}