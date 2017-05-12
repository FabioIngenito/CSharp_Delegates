using System;

namespace waDelegates
{
    //Assinatura declarativa de um método Delegate
    public delegate String assinaturaMetodo(int inteiro);

    /// <summary>
    /// Classe para exemplificar o uso do Delegate
    /// </summary>
    public class clsExemplo
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
}
