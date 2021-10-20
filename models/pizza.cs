using System;
using System.Collections.Generic;

namespace Cadastro___Produtos.Models
{
    public partial class Pizza
    {
        public string Nome { get; set; }
        public int NumeroDeFatias { get; set; }
        public double? Preço { get; set; }
        public int Borda { get; set; }
    }
}
