# CSharp_Delegates
Exemplo de uso de Delegates  

Um DELEGATE é um tipo de referência que pode ser utilizado para encapsular métodos, mesmo os anônimos; desde que os mesmos tenham parâmetros de entrada e tipos de retorno semelhantes. 

Um DELEGATE pode ser instanciado com um método, estático ou não, ou também com uma expressão lambda; funciona como uma espécie de assinatura, o exemplo abaixo foi retirado do MSDN e adaptado para melhor compreensão;

using System;

namespace Delegates
{
  class Program
  {
    //Assinatura declarativa de um método delegate
    public delegate String assinaturaMetodo(int inteiro);
            
    //Classe para exemplificar o uso do Delegate
    public class classeExemplo
    {

      public String meuMetodo(int inteiro)
      {
        if (inteiro > 0) return ("positivo");
        if (inteiro < 0) return ("negativo");
        return ("zero");
      }

      public static String meuMetodoEstatico(int inteiro)
      {
        if (inteiro > 0) return ("+");
        if (inteiro < 0) return ("-");
        return ("");
      }
    }


    //Método Principal
    static void Main(string[] args)
    {
      //Instanciando um objeto da classeExemplo()
      classeExemplo ED = new classeExemplo();

      //Aqui estou instanciando um método com base na assinaturaMetodo
      assinaturaMetodo MD1 = new assinaturaMetodo(ED.meuMetodo);

      //Quando usamos um método Estático devemos assinar pelo nome da 
      //Classe "classeExemplo.meuMetodoEstatico"
      assinaturaMetodo MD2 = new assinaturaMetodo(classeExemplo.meuMetodoEstatico);

      //Usando expressão lambda que resulta o cubo de um valor numérico
      assinaturaMetodo MD3 = i => (i * i * i).ToString();

      Console.WriteLine("Exemplo Delegate");
      Console.WriteLine("================");
      Console.Write("Informe um número inteiro: ");
      try
      {
        int numero = Convert.ToInt32(Console.ReadLine());                
        //Usando um método comum
        Console.WriteLine("{0} é um número {1}."    , numero, MD1(numero));

        //Usando um método estático
        Console.WriteLine("{0} usa o sinal \\"{1}\\".", numero, MD2(numero));
                
        //Usando expressão lambda
        Console.WriteLine("O cubo de {0} é {1}."    , numero, MD3(numero)); 
                
        Console.ReadKey();
      }
      catch (Exception e)
      {
        //Caso ocorra algum erro é apresentada a respectiva mensagem.
        Console.WriteLine("Erro:" + e.Message);
        Console.ReadKey();                
      }           
    }
  }
}


Referências
http://msdn.microsoft.com/pt-br/library/900fyy8e.aspx
http://msdn.microsoft.com/pt-br/library/system.delegate.aspx
