using System;
using System.Collections.Generic;

namespace Cadastro___Produtos.Models
{
    public partial class Produtocat
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public bool Gluten { get; set; }
    }
}
