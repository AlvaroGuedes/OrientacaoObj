using System;

namespace teste
{
    class Program
    {
        static void Main (string[] args)
        {
            Pessoa obj = new Pessoa ();
            obj.idade = 35;
            obj.nome = "Carlinhos";
            obj.mensagem();
            
        }
    }
}