using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using VueController.Models;

namespace VueController.Services
{
    public class ClasseService
    {
        public IEnumerable<PersonneClasseModel> Personnes;

        public ClasseService()
        {
            string text = File.ReadAllText("students.json");

            Personnes = JsonConvert.DeserializeObject<IEnumerable<PersonneClasseModel>>(text);
        }
    }
}
