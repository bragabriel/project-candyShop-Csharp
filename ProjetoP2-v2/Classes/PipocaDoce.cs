using System.Collections.Generic;

namespace ProjetoP2 {
    class PipocaDoce : Produto{
        public override string CarrinhoDeCompras()
        {
            string frase = "Produto: " + nome + "   Preço: R$" + preco + "   Quantidade: " + qtd + " itens" + "   Total: " + qtd * preco;
            return frase;
        }
    }
}
