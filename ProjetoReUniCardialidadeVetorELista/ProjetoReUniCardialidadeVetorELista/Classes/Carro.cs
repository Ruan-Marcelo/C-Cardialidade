using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoReUniCardialidadeVetorELista.Classes
{
    public class Carro
    {
        private string modelo;

        public string Modelo 
        { 
            get { return modelo; }
            set { modelo = value; }
        }
        
        public void ImprimirDados()
        {
            Console.WriteLine($"Modelo do carro: {modelo}");
        }

    }
}
