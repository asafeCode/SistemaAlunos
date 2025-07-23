namespace SistemaAlunos.Exceptions;

public class ProgramMessages
{
    public static string EST_MENU_INIT_MESSAGE()
    {
        return "\nESCOLHA A ESTATÍSTICA DESEJADA: \n \n" +
               " 0 - VOLTAR;\n " +
               "1 - ALUNOS APROVADOS;\n " +
               "2 - ALUNOS REPROVADOS;\n \n " +
               "DIGITE A OPERAÇÂO DESEJADA: ";
    }
    
    public static string MENU_PRINCIPAL_INIT_MESSAGE()
    {
        return "\nBEM VINDO AO SISTEMA DE CADASTRO DE ALUNOS \n \n" +
               " 0 - SAIR DO SISTEMA;\n " +
               "1 - CADASTRAR ALUNO;\n " +
               "2 - LISTAR ALUNOS;\n " +
               "3 - MOSTRAR ESTATISTÍCAS;\n \n" +
               "DIGITE A OPERAÇÂO DESEJADA: ";
    }
    
    public static string SHUT_DOWN_MESSAGE()
    {
        return  "ENCERRANDO O SISTEMA... Obrigado pela preferência!";
    }
}