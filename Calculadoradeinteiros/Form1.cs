namespace Calculadoradeinteiros
{
    public partial class Form1 : Form
    {
        public int resultado, numTemp;
        public string operacao;
        public Form1()
        {
            InitializeComponent();
        }

        private void DigitaNumero(int num)
        {
            numTemp = (numTemp * 10) + num;
        }

        private void DigitaOperacao(string operador)
        {
            resultado = numTemp;
            numTemp = 0;
            operacao = operador;
        }
        private void btn_8_Click(object sender, EventArgs e)
        {

            DigitaNumero(8);
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            DigitaNumero(9);
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            DigitaNumero(7);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            DigitaNumero(6);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            DigitaNumero(5);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            DigitaNumero(4);

        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            DigitaNumero(3);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            DigitaNumero(2);
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            DigitaNumero(1);
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            DigitaNumero(0);
        }

        private void bt_igual_Click(object sender, EventArgs e)
        {

        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            DigitaOperacao("+");
        }

        private void btn_subtracao_Click(object sender, EventArgs e)
        {
            DigitaOperacao("-");
        }

        private void bnt_multiplicacao_Click(object sender, EventArgs e)
        {
            DigitaOperacao("x");
        }

        private void bnt_divisao_Click(object sender, EventArgs e)
        {
            DigitaOperacao("/");
        }
    }
}