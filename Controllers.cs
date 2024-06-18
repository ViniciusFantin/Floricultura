using System.Collections.Generic;
using Floricultura.Models;
using Floricultura.Data;

namespace Floricultura.Controllers
{
    public class FlorController
    {
        public List<Flor> Index()
        {
            return FlorData.GetFlores();
        }

        public void Create(Flor flor)
        {
            FlorData.AddFlor(flor);
        }

        public void Edit(Flor flor)
        {
            FlorData.UpdateFlor(flor);
        }

        public void Delete(int id)
        {
            FlorData.DeleteFlor(id);
        }
    }
}