using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoP2 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            labelSPA.Visible = false;
            textSPA.Visible = false;
        }

        float total = 0;

        List<Produto> lista = new List<Produto>();

        private void btLimpar_Click(object sender, EventArgs e) {
            
            if (lbDados.Items.Count == 0) {
                MessageBox.Show("O carrinho já está limpo!", "ListBox",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lbDados.Items.Clear();
                textSPA.Text = "0";
                total = 0;
            }
        }

        private void btRemover_Click(object sender, EventArgs e) {
            if (lbDados.SelectedIndex != -1) {
                int indiceSelecionado = lbDados.SelectedIndex;
                int posAnterior = indiceSelecionado - 1;
                int? posPosterior = indiceSelecionado + 1;
                float totalArmazenado = 0;
                if (textSPA.Text != "") {
                    totalArmazenado = float.Parse(textSPA.Text);
                }

                string result = lbDados.Text;

                string[] subs = result.Split(' ');

                foreach (var sub in subs) {
                    textSPA.Text = sub;
                }

                float teste = float.Parse(textSPA.Text);

                totalArmazenado -= teste;

                textSPA.Text = totalArmazenado.ToString();

                lbDados.Items.RemoveAt(indiceSelecionado);

                total = float.Parse(textSPA.Text);

                if (posAnterior == -1 && posPosterior == null) {
                    total = 0;
                    textSPA.Text = "0";
                    lbDados.Items.Clear();
                    lbDados.Focus();
                }
                lbDados.SelectedIndex = posAnterior;
            } else {
                MessageBox.Show("Nenhum item foi selecionado!", "ListBox",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btFinalizar_Click(object sender, EventArgs e) {
            if (lbDados.Items.Count == 0)
            {
                total = 0;
            }

            labelSPA.Visible = true;
            textSPA.Visible = true;
            textSPA.Text = total.ToString();


            string message = "Deseja finalizar o pedido?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                
            }


        }

        private void btAdicionarPipoca_Click_1(object sender, EventArgs e) {
            string nome = textoPipoca.Text;
            float preco = float.Parse(precoPipoca.Text);
            string quantidade = qtdPipoca.Text;

            if (quantidade == "")
            {
                MessageBox.Show("Informe a quantidade de itens!", "ListBox",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                int qtd = int.Parse(qtdPipoca.Text);

                if (qtd < 0)
                {
                    MessageBox.Show("A quantidade de itens não pode ser negativa!", "ListBox",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }          
                else
                {
                    Produto pipoca = new PipocaDoce();

                    pipoca.nome = nome;
                    pipoca.preco = preco;
                    pipoca.qtd = qtd;

                    lista.Add(pipoca);

                    total += qtd * preco;

                    //Carrinho de Compras
                    lbDados.Items.Add(pipoca.CarrinhoDeCompras());
                }
            }
        }

        private void btAdicionarPirulito_Click(object sender, EventArgs e) {
            string nome = textoPirulito.Text;
            float preco = float.Parse(precoPirulito.Text);
            string quantidade = qtdPirulito.Text;

            if (quantidade == "") {
                MessageBox.Show("Informe a quantidade de itens!", "ListBox",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            } else {
                int qtd = int.Parse(qtdPirulito.Text);

                if (qtd < 0) {
                    MessageBox.Show("A quantidade de itens não pode ser negativa!", "ListBox",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                } else {
                    Produto pirulito = new Pirulito();

                    pirulito.nome = nome;
                    pirulito.preco = preco;
                    pirulito.qtd = qtd;

                    lista.Add(pirulito);

                    total += qtd * preco;

                    //Carrinho de Compras
                    lbDados.Items.Add(pirulito.CarrinhoDeCompras());
                }
            }
        }

        private void btAdicionarCombo_Click(object sender, EventArgs e) {

            string nome = textoCombo.Text;
            float preco = float.Parse(precoCombo.Text);
            string quantidade = qtdCombo.Text;

            if (quantidade == "") {
                MessageBox.Show("Informe a quantidade de itens!", "ListBox",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            } else {
                int qtd = int.Parse(qtdCombo.Text);

                if (qtd < 0) {
                    MessageBox.Show("A quantidade de itens não pode ser negativa!", "ListBox",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                } else {
                    Produto combo = new Combo();

                    combo.nome = nome;
                    combo.preco = preco;
                    combo.qtd = qtd;

                    lista.Add(combo);

                    total += qtd * preco;

                    //Carrinho de Compras
                    lbDados.Items.Add(combo.CarrinhoDeCompras());
                }
            }
        }

        private void btAdicionarKopenhagen_Click(object sender, EventArgs e) {

            string nome = textoKopenhagen.Text;
            float preco = float.Parse(precoKopenhagen.Text);
            string quantidade = qtdKopenhagen.Text;

            if (quantidade == "") {
                MessageBox.Show("Informe a quantidade de itens!", "ListBox",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            } else {
                int qtd = int.Parse(qtdKopenhagen.Text);

                if (qtd < 0) {
                    MessageBox.Show("A quantidade de itens não pode ser negativa!", "ListBox",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                } else {
                    Produto kopenhagen = new ChocolateKo();

                    kopenhagen.nome = nome;
                    kopenhagen.preco = preco;
                    kopenhagen.qtd = qtd;

                    lista.Add(kopenhagen);

                    total += qtd * preco;

                    //Carrinho de Compras
                    lbDados.Items.Add(kopenhagen.CarrinhoDeCompras());
                }
            }
        }

        private void btAdicionarAlpino_Click(object sender, EventArgs e) {

            string nome = textoAlpino.Text;
            float preco = float.Parse(precoAlpino.Text);
            string quantidade = qtdAlpino.Text;

            if (quantidade == "") {
                MessageBox.Show("Informe a quantidade de itens!", "ListBox",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            } else {
                int qtd = int.Parse(qtdAlpino.Text);

                if (qtd < 0) {
                    MessageBox.Show("A quantidade de itens não pode ser negativa!", "ListBox",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                } else {
                    Produto alpimo = new ChocolateAlpino();

                    alpimo.nome = nome;
                    alpimo.preco = preco;
                    alpimo.qtd = qtd;

                    lista.Add(alpimo);

                    total += qtd * preco;

                    //Carrinho de Compras
                    lbDados.Items.Add(alpimo.CarrinhoDeCompras());
                }
            }
        }

        private void btAdicionarBala_Click(object sender, EventArgs e) {

            string nome = textoBala.Text;
            float preco = float.Parse(precoBala.Text);
            string quantidade = qtdBala.Text;

            if (quantidade == "")
            {
                MessageBox.Show("Informe a quantidade de itens!", "ListBox",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                int qtd = int.Parse(qtdBala.Text);

                if (qtd < 0)
                {
                    MessageBox.Show("A quantidade de itens não pode ser negativa!", "ListBox",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    Produto bala = new Bala();

                    bala.nome = nome;
                    bala.preco = preco;
                    bala.qtd = qtd;

                    lista.Add(bala);

                    total += qtd * preco;

                    //Carrinho de Compras
                    lbDados.Items.Add(bala.CarrinhoDeCompras());
                }
            }
        }
    }
}