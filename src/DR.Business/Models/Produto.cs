﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DR.Business.Models
{
    public class Produto : Entity
    {
        public Guid ForncedorId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Aivo { get; set; }

        public Fornecedor Fornecedor { get; set; }
    }
}