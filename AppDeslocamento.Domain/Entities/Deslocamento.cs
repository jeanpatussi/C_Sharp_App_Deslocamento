using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDeslocamento.Domain.Entities
{
    public class Deslocamento : BaseEntity
    {
        public Deslocamento(long clienteId, long condutorId, long veiculoId, DateTime dataHoraInicio, long kmInicio)
        {
            ClienteId = clienteId;
            CondutorId = condutorId;
            VeiculoId = veiculoId;
            DataHoraInicio = dataHoraInicio;
            KmInicio = kmInicio;
            Observacao = "";
            KmFim = 0;
        }
        public Deslocamento()
        {

        }

        public void FinalizarDeslocamento(DateTime dataHoraFim, long kmFim, string observacao)
        {
            DataHoraFim = dataHoraFim;
            KmFim = kmFim;
            Observacao = observacao;
        }

        public long ClienteId { get; set; }
        public long CondutorId { get; set; }
        public long VeiculoId { get; set; }

        public DateTime DataHoraInicio { get; set; }
        public DateTime? DataHoraFim { get; set; }
        public long KmInicio { get; set; }
        public long KmFim { get; set; }
        public string Observacao { get; set; }


        public Cliente Cliente { get; set; }
        public Condutor Condutor { get; set; }
        public Veiculo Veiculo { get; set; }


    }
}
