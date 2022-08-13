using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoP2 {
    class Combo : Produto{ 
        public override string CarrinhoDeCompras()
        {
            string frase = "Produto: " + nome + "   Preço: R$" + preco + "   Quantidade: " + qtd + " itens" + "   Total: " + qtd * preco;
            return frase;
        }
    }
}
