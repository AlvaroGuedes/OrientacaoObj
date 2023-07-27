using System;

class Pessoa
{
    //metodos 01
    public void apresentar()
    {
        var soma = 1 + 1;
      Console.WriteLine ("o resultado é" + soma);
    }
    // metodos 02
     public void apresentar(int numero)
    {
      Console.WriteLine("O RESULTADO DA SOMA É"+ numero);  
    }
    //metodos 03
     public void apresentar(int  numeroum, int numerodois)
    {
        Console.WriteLine(numeroum + numerodois);
    }
}