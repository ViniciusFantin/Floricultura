using System;

namespace Floricultura.Models
{
    public class Flor
    {
        public int Id { get; set; } //Identificador único da planta
        public string Nome { get; set; }
        public int QuantidadeEstoque { get; set; } //Quantia em estoque 
        public decimal ValorEmReais { get; set; }  // Valor em reais da Planta
    }
}