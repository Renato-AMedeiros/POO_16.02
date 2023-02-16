using System;
using System.Collections.Generic;
using System.Text;

namespace POO_16._02
{
    class Pessoa
    {

        public double peso, altura;




        public double calculo ()
        {
            return (peso / (altura * altura));

        }

        public string situacao (double IMC)
        {
            string retorno;
            
            if ( IMC < 18)
            {
                retorno = " Abaixo do Peso ";
            }
            else if ( IMC < 25)
            {
                retorno = " Peso normal ";
            }

            else if (IMC < 30)
            {
                retorno = " acima do peso ";
            }
            else if (IMC < 35)
            {
                retorno = " obesidade I ";
            }
            else if (IMC < 40)
            {
                retorno = " obesidade LL ";
            }
            else  
            {
                retorno = " obesidade III ";
            }

            return retorno;

        }

        public void mensagem()
        {
            double ObterCalculo = calculo();
            string ObterSituaçao = situacao( ObterCalculo );

            Console.WriteLine("Seu IMC é de: " + ObterCalculo );
            Console.WriteLine("Sua situação é de: " + ObterSituaçao);

        }
        

    }
}