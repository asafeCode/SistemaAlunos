namespace SistemaAlunos.Exceptions;

public class ErrorMessages: Exception
{
    public static string INVALID_GRADE()
    {
        return "NOTA INVALIDA. Por favor insira um valor entre 0 e 10";
    }
    
    public static string INVALID_NAME()
    {
        return "NOME INVALIDO. Por favor insira um nome que não seja vazio";
    }

    public static string INVALID_OPERATION()
    {
        return "OPERACAO INVALIDA. Por favor insira uma operação válida";
    }
}