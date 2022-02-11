using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDeslocamento.Domain.Entities
{
    public class Veiculo : BaseEntity
    {
        public Veiculo(string placa, string descricao)
        {
            Placa = placa;
            Descricao = descricao;
        }
        public Veiculo()
        {

        }
        public string Placa { get; set; }
        public string Descricao { get; set; }

        private readonly List<Deslocamento> _deslocamentos = new();
        public IReadOnlyCollection<Deslocamento> Deslocamentos =>
            _deslocamentos.AsReadOnly();
    }
}
