using System;

using Floricultura.Views;

namespace Floricultura
{
    class Program
    {
        static void Main(string[] args)
        {
            var view = new FlorView();
            view.Menu(); // Inicia o menu da aplicação
        }
    }
}