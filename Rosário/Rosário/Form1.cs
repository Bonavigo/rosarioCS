namespace Rosário
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O Santo Rosário é uma prática religiosa de devoção mariana muito difundida entre os católicos.\nEle consiste no uso de uma corrente com contas ou nós e a contemplação de determinadas passagens da vida de Jesus e de sua mãe, Nossa Senhora.\nSão rezadas várias orações, principalmente a Ave-Maria, que no Rosário completo é rezada cento e cinquenta vezes, contemplando os quinze mistérios.\nVocê também pode seguir os dias dos mistérios e rezar cinco mistérios e cinquenta Ave-Marias.", "O que é o Rosário?");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O ideal para rezar o Rosário é ter um terço, mas caso não tenha um, é possível rezar usando os dedos.\nTendo-o, inicia-se fazendo o sinal da cruz, depois, segurando a cruz do terço, é rezado o Credo (as orações estarão em outra seção), e depois, na primeira cota, é rezado um Pai-Nosso, depois, nas três cotas que a sucedem, é rezado uma Ave-Maria, e enfim, na última cota antes da medalha, é rezado um Glória ao Pai e um Ó Meu Jesus.", "Como rezar?");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mistérios Gozosos - segundas e quintas-feiras.\r\nMistérios Dolorosos - terças e sextas-feiras.\r\nMistérios Gloriosos - quartas-feiras, sábados e domingos.\r\n", "Dias do Terço");
        }
    }
}
