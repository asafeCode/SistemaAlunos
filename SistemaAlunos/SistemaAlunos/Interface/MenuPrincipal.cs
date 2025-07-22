namespace SistemaAlunos.UseCases;

public static class MenuPrincipal
{
    public static void Exibir()
    {
        string entradaSistema = "";

        do
        {
            Console.Write("\nBEM VINDO AO SISTEMA DE CADASTRO DE ALUNOS \n \n" +
                          " 0 - SAIR DO SISTEMA;\n " +
                          "1 - CADASTRAR ALUNO;\n " +
                          "2 - LISTAR ALUNOS;\n " +
                          "3 - MOSTRAR ESTATISTÍCAS;\n \n" +
                          "DIGITE A OPERAÇÂO DESEJADA: ");
    
            entradaSistema = Console.ReadLine();

            switch (entradaSistema)
            {
                case "0":
                    break;
                case "1":
                    CadastrarAluno.Cadastrar();
                    break;
                case "2":
                    ListarAlunos.Listar();
                    break;
                case "3":
                    break;
                default:
                    
                    break;
            }
    
    
        }while(entradaSistema != "0");
    }
}