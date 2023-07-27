using System;

class Pessoa 
{
    public string nome;
    public int idade;

    //metodos
    public void mensagem()
    {

     //instanciar objeto 
     Console.WriteLine($"Olá {nome} voce tem {idade} anos");
    }
}