namespace SistemaAlunos.UseCases;

public static class MenuPrincipal
{
    public static void Exibir()
    {
        string entradaSistema = "";

        do
        {
            Console.Write(Exceptions.ProgramMessages.MENU_PRINCIPAL_INIT_MESSAGE());
    
            entradaSistema = Console.ReadLine();

            switch (entradaSistema)
            {
                case "0":
                    Console.WriteLine(Exceptions.ProgramMessages.SHUT_DOWN_MESSAGE());
                    break;
                case "1":
                    CadastrarAlunoUseCase.Cadastrar();
                    break;
                case "2":
                    MostrarEstatisticasUseCase.ListarOsAlunos();
                    break;
                case "3":
                    EstatisticasMenu.Mostrar();
                    break;
                default:
                    Console.WriteLine(Exceptions.ErrorMessages.INVALID_OPERATION());
                    break;
            }
    
    
        }while(entradaSistema != "0");
    }
}