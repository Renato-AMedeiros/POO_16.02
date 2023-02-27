using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoPOO_23_02
{
    public class Pessoa
    {
        public string nome, cidade, email;
        public int idade;
        public double peso, altura, contato;
        public void Mensagem() {
             Console.WriteLine("Meu nome é " + nome + ", moro em " + cidade + ", tenho " + idade + " anos, meu peso é " + peso + "Kg, minha altura é "
                + altura + ", meu email é " + email + " e meu contato é " + contato );
      
        }

    }
}
