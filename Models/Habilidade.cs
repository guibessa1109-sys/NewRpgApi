using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using RpgApi.Models.Enuns;
using RPGAPI.Models;
using Microsoft.EntityFrameworkCore;
using RPGAPI.Models;

namespace RPGAPI.Models
{
    public class Habilidade
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int Dano { get; set; }
        public List<PersonagemHabilidade> PersonagemHabilidades { get; set; } = [];
    }
}