using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoReUniCardialidadeVetorELista.Classes
{
    public class Comodos
    {
        //Atributos
        public string nomeComo;
        private float tamanho;

        //Propriedades
        public float Tamanho
        {
            get { return tamanho; }
            set { tamanho = value; }
        }

        //Métodos

        public void ImprimirDados()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("             Comodos");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Nome dos Comodos: {nomeComo}");
            Console.WriteLine($"Tamanhos dos Comodos: {tamanho}");
        }

    }
}
