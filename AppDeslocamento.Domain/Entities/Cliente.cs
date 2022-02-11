﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDeslocamento.Domain.Entities
{
    public class Cliente : BaseEntity
    {
        public Cliente  (string nome, string cpf )
        {
           Cpf = cpf;
           Nome = nome;
        }

        public Cliente(){

        }
        public string Cpf { get; set; }
        public string Nome { get; set; }

        private readonly List<Deslocamento> _deslocamentos = new();
        public IReadOnlyCollection<Deslocamento> Deslocamentos =>
            _deslocamentos.AsReadOnly();

    }

}
