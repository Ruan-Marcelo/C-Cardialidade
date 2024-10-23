using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoReUniCardialidadeVetorELista.Classes
{
    public class Casa
    {
        //Atributos
        public string cep;
        public int qtdePessoas;
        private int qtdComodos;

        //Relacionamento 0..3
        private Comodos[] comodos;
        //Relacionamento 0..4
        private Moradores[] moradores;
        //Relacionamento 0..*
        private List<Carro> carro;

        //Propriedades
        public int QtdComodos
        {
            get { return qtdComodos; }
            set { qtdComodos = value; }
        }
        public List<Carro> Carro
        {
            get
            {
                if (carro == null)
                {
                    carro = new List<Carro>();
                }
                return carro;
            }
            set
            {
                if (value == null)
                {
                    carro = new List<Carro>();
                }
                carro = value;
            }


        }
        public Moradores[] Moradores
        {
            get
            {
                if (moradores == null)
                {
                    moradores = new Moradores[4];
                }
                return moradores;
            }
            set
            {
                if (moradores == null)
                {
                    moradores = new Moradores[4];
                }
                moradores = value;
            }
        }   

        public Comodos[] Comodos
        {
            get
            {
                if (comodos == null)
                {
                    comodos = new Comodos[3];
                }
                return comodos;
            }
            set
            {
                if (comodos == null)
                {
                    comodos = new Comodos[3];
                }
                comodos = value;
            }
        }

        public void ImprimirDados()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("               Casa");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"CEP: {cep}");
            Console.WriteLine($"Quantidade de moradores: {qtdePessoas}");
            Console.WriteLine($"Quantidade de comodos: {qtdComodos}");

            if(comodos != null)
            {
                foreach(Comodos comodos in comodos)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("             Comodos");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine($"Nome dos Comodos: {comodos.nomeComo}");
                    Console.WriteLine($"Tamanhos dos Comodos: {comodos.Tamanho}");
                }
            }
            if (moradores != null)
            {
                foreach (Moradores moradores in moradores)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("             Moradores");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine($"Nome: {moradores.nome}");
                    Console.WriteLine($"Idade: {moradores.Idade}");
                }
            }
            if (carro != null)
            {
                foreach (Carro carro in carro)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("             Carro");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine($"Modelo do carro: {carro.Modelo}");
                }
            }
        }
    }
}
