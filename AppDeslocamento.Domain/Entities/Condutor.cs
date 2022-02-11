using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDeslocamento.Domain.Entities
{
    public  class Condutor : BaseEntity
    {
        public Condutor(string nome, string emai)
        {
            Nome = nome;
            Email = emai;
        }

        public Condutor()
        {

        }

        public string Nome { get; set; }
        public string Email { get; set;}

        private readonly List<Deslocamento> _deslocamentos = new();
        public IReadOnlyCollection<Deslocamento> Deslocamentos =>
            _deslocamentos.AsReadOnly();
    }
}
