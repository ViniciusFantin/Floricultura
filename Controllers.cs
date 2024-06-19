using System.Collections.Generic;
using Floricultura.Models;
using Floricultura.Data;

namespace Floricultura.Controllers
{
    public class FlorController
    {
        
        //Lista todas as Plantas
        public List<Flor> Index()
        {
            return FlorData.GetFlores();
        }

        public void Create(Flor flor) //Adiciona uma Nova flor
        {
            FlorData.AddFlor(flor);
        }

        public void Edit(Flor flor) //Edita uma flor existente
        {
            FlorData.UpdateFlor(flor);
        }

        public void Delete(int id) //Deleta uma flor com o número do ID dela 
        {
            FlorData.DeleteFlor(id);
        }
    }
}