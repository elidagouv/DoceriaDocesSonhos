﻿using DoceriaDocesSonhos.Models.Enums;
using System;

namespace DoceriaDocesSonhos.Models
{
    public class Product
    {
       
        public Guid Id { get;}
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeDisponivel { get; set; }
        public EnumTipoDeDoce TipoDeDoce { get; set; }

    }
}
