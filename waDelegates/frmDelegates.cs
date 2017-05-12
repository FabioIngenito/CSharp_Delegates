using System;
using System.Windows.Forms;

namespace waDelegates
{
    public partial class frmDelegates : Form
    {
        public frmDelegates()
        {
            InitializeComponent();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(nudNumero.Value);

            //Instanciando um objeto da clsExemplo()
            clsExemplo ED = new clsExemplo();

            //Aqui estou instanciando um método com base na assinaturaMetodo
            assinaturaMetodo MD1 = new assinaturaMetodo(ED.meuMetodo);

            //Quando usamos um método Estático devemos assinar pelo nome da 
            //Classe "clsExemplo.meuMetodoEstatico"
            assinaturaMetodo MD2 = new assinaturaMetodo(clsExemplo.meuMetodoEstatico);

            //Usando expressão lambda que resulta o cubo de um valor numérico
            assinaturaMetodo MD3 = i => (i * i * i).ToString();

            //Usando um método comum
            lblResposta1.Text = String.Format("{0} é um número {1}.", numero, MD1(numero));

            //Usando um método estático
            lblResposta2.Text = String.Format("{0} usa o sinal \"{1}\".", numero, MD2(numero));

            //Usando expressão lambda
            lblResposta3.Text = String.Format("O cubo de {0} é {1}.", numero, MD3(numero));
        }
    }
}