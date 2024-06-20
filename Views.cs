using System;
using Floricultura.Models;
using Floricultura.Controllers;

namespace Floricultura.Views
{
    public class FlorView
    {
        private FlorController controller = new FlorController();

        public void DisplayFlores() //Método para exibir a Lista
        {
            var flores = controller.Index();
            Console.WriteLine("Lista de Flores:");
            foreach (var flor in flores)
            {
                Console.WriteLine($"ID: {flor.Id}, Nome: {flor.Nome}, Quantidade em Estoque: {flor.QuantidadeEstoque}, Valor: R${flor.ValorEmReais:F2}");
            }
        }

        public void AddFlor() //Método de adição de uma flor
        {
            var novaFlor = new Flor();
            Console.Write("Nome da Flor: ");
            novaFlor.Nome = Console.ReadLine();
            Console.Write("Quantidade em Estoque: ");
            novaFlor.QuantidadeEstoque = int.Parse(Console.ReadLine());
            Console.Write("Valor em Reais: ");
            novaFlor.ValorEmReais = decimal.Parse(Console.ReadLine());
            controller.Create(novaFlor);
        }

        public void EditFlor() //Método de edit de cada flor 
        {
            Console.Write("ID da Flor a Editar: ");
            var id = int.Parse(Console.ReadLine());
            var flor = new Flor { Id = id };
            Console.Write("Novo Nome da Flor: ");
            flor.Nome = Console.ReadLine();
            Console.Write("Nova Quantidade em Estoque: ");
            flor.QuantidadeEstoque = int.Parse(Console.ReadLine());
            Console.Write("Novo Valor em Reais: ");
            flor.ValorEmReais = decimal.Parse(Console.ReadLine());
            controller.Edit(flor);
        }

        public void DeleteFlor()
        {
            Console.Write("ID da Flor a Deletar: ");
            var id = int.Parse(Console.ReadLine());
            controller.Delete(id);
        }

        public void Menu() //Método para exibir o menu para o usuário e lidar com a navegaçaõ do mesmo
        {
            while (true)
            {
                Console.WriteLine("\n******* Menu *******");
                Console.WriteLine("|------------------|");
                Console.WriteLine("|1. Listar Flores  |");
                Console.WriteLine("|------------------|");
                Console.WriteLine("|2. Adicionar Flor |");
                Console.WriteLine("|------------------|");
                Console.WriteLine("|3. Editar Flor    |");
                Console.WriteLine("|------------------|");
                Console.WriteLine("|4. Deletar Flor   |");
                Console.WriteLine("|------------------|");
                Console.WriteLine("|5. Sair           |");
                Console.WriteLine("|------------------|");
                Console.Write("Escolha uma opção: ");


                var escolha = Console.ReadLine();
                switch (escolha)
                {
                    case "1":
                        DisplayFlores();
                        break;
                    case "2":
                        AddFlor();
                        break;
                    case "3":
                        EditFlor();
                        break;
                    case "4":
                        DeleteFlor();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
    }
}