using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoReUniCardialidadeVetorELista.Classes
{
    public class Moradores
    {
        public string nome;
        private int idade;

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public void ImprimirDados()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
        }
    }
}
