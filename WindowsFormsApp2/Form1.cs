using System;
using System.Collections;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        ArrayList letrasJaDigitadas = new ArrayList();
        private String palavraSecreta;
        int contadorTentativas = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pnJogo.Visible = true;
            btnStart.Visible = false;
        }

        private void btnConfirmaPalavra_Click(object sender, EventArgs e)
        {

            gbAdvinhaLetra.Visible = true;
            gbForcaDesenho.Visible = true;
            gbTentativas.Visible = true;
            gbPalavraSecreta.Visible = false;

            iniciaGame();


        }

        private void btnConfirmaLetra_Click(object sender, EventArgs e)
        {
            ArrayList indicesEncontrados;
            string letraDigitada = txtDigitaLetra.Text.ToLower();

            if (validaCaractere(letraDigitada))
            {
                MessageBox.Show("Digite apenas um caractere");
            }
            else if (letrasJaDigitadas.Contains(letraDigitada))
            {
                MessageBox.Show("Letra já digita, verifica por favor");
            }
            else
            {
                indicesEncontrados = verificaExistenciaLetra(letraDigitada[0]);

                if (indicesEncontrados.Count != 0)
                {
                    preencheLetrasEncontradas(indicesEncontrados, letraDigitada[0]);

                }
                else
                {
                    letrasJaDigitadas.Add(letraDigitada);
                    errouLetra();
                }
            }

            txtDigitaLetra.Text = "";

        }

        private void iniciaGame()
        {
            palavraSecreta = txtPalavraSecreta.Text;
            int tamanhoPalavraSecreta = palavraSecreta.Length;

            lblTentativas.Text = contadorTentativas.ToString();

            for (int i = 0; i < tamanhoPalavraSecreta; i++)
            {
                labelTeste.Text += "_";
            }

        }

        private ArrayList verificaExistenciaLetra(char letraDigitada)
        {
            ArrayList indices = new ArrayList();
            int b = 0;

            foreach (char c in palavraSecreta)
            {

                if (c == letraDigitada)
                {
                    indices.Add(b);
                }

                b++;
            }

            return indices;
        }

        private void errouLetra()
        {
            contadorTentativas -= 1;
            lblLetrasDigitadas.Text = "";

            switch (contadorTentativas)
            {
                case 4:
                    pbForca.Image = Properties.Resources.cabeca;
                    break;

                case 3:
                    pbForca.Image = Properties.Resources.cabeca_corpo;
                    break;

                case 2:
                    pbForca.Image = Properties.Resources.cabeca_corpo_2_braco;
                    break;

                case 1:
                    pbForca.Image = Properties.Resources.cabeca_corpo_2_braco_perna;
                    break;

                case 0:
                    pbForca.Image = Properties.Resources.cabeca_corpo_2_braco_2_perna;
                    MessageBox.Show("Você perdeu, sinto muito IRMÃO");
                    this.Close();

                    break;
            }

            lblTentativas.Text = contadorTentativas.ToString();

            foreach (string letra in letrasJaDigitadas)
            {
                lblLetrasDigitadas.Text += letra + " - ";
            }

        }

        private void preencheLetrasEncontradas(ArrayList indicesEncontrados, char letraDigitada)
        {
            char[] palavra = labelTeste.Text.ToCharArray();

            foreach (int indice in indicesEncontrados)
            {
                for (int contador = 0; contador <= palavraSecreta.Length; contador++)
                {
                    if (contador == indice)
                    {
                        palavra[indice] = letraDigitada;
                    }
                }
            }

            labelTeste.Text = new string(palavra);

            if (labelTeste.Text == palavraSecreta)
            {
                MessageBox.Show("VOCÊ GANHOU");
                this.Close();
            }
        }

        private Boolean validaCaractere(string letraDigitada)
        {
            if (letraDigitada.Length > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
