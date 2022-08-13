using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoP2 {
    abstract class Produto {

        public string nome { get; set; }
        public float preco { get; set; }
        public int qtd { get; set; }

        public abstract string CarrinhoDeCompras();

    }
}
