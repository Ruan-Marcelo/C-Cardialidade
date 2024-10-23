using ProjetoReUniCardialidadeVetorELista.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoReUniCardialidadeVetorELista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCasa_Click(object sender, EventArgs e)
        {
            //Comodos
            Comodos o_Banheiro = new Comodos();
            o_Banheiro.nomeComo = "Banheiro";
            o_Banheiro.Tamanho = 23.5f;

            Comodos o_Quarto1 = new Comodos();
            o_Quarto1.nomeComo = "Quarto dos filhos";
            o_Quarto1.Tamanho = 20.0f;

            Comodos o_Quarto2 = new Comodos();
            o_Quarto2.nomeComo = "Quarto dos Pais";
            o_Quarto2.Tamanho = 20.0f;

            //Moradores
            Moradores o_filhoNovo = new Moradores();
            o_filhoNovo.nome = "Elder";
            o_filhoNovo.Idade = 12;

            Moradores o_filhoVelho = new Moradores();
            o_filhoVelho.nome = "Lucas boiola da silva";
            o_filhoVelho.Idade = 24;

            Moradores o_Pai = new Moradores();
            o_Pai.nome = "Agnaldo";
            o_Pai.Idade = 69;

            Moradores o_Mae = new Moradores();
            o_Mae.nome = "Lana Hoads";
            o_Mae.Idade = 17;

            //Carro
            Carro o_Jeep = new Carro();
            o_Jeep.Modelo = "Jeep Renegade";

            Carro o_Celta = new Carro();
            o_Celta.Modelo = "Celta 1.6";

            Carro o_Civic = new Carro();
            o_Civic.Modelo = "Civic turbo 2.5 Preto";


            //Casa
            Casa o_casa = new Casa();
            o_casa.cep = "6969-69";
            o_casa.qtdePessoas = 4;
            o_casa.QtdComodos = 3;

            o_casa.Comodos[0] = o_Banheiro;
            o_casa.Comodos[1] = o_Quarto1;
            o_casa.Comodos[2] = o_Quarto2;

            o_casa.Moradores[0] = o_filhoNovo;
            o_casa.Moradores[1] = o_filhoVelho;
            o_casa.Moradores[2] = o_Pai;
            o_casa.Moradores[3] = o_Mae;


            o_casa.Carro.Add(o_Civic);
            o_casa.Carro.Add(o_Jeep);
            o_casa.Carro.Add(o_Celta);

            o_casa.ImprimirDados();




        }
    }
}
