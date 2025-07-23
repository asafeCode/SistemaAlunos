namespace SistemaAlunos.UseCases;

public class EstatisticasMenu
{
     public static void Mostrar()
    {
        string entradaSistema = "";
        do
        {
            Console.Write(Exceptions.ProgramMessages.EST_MENU_INIT_MESSAGE());
    
            entradaSistema = Console.ReadLine();

            switch (entradaSistema)
            {
                case "0":
                    break;
                
                case "1":
                    MostrarEstatisticasUseCase.ListaAlunosAprovados();
                    break;
                
                case "2":
                   MostrarEstatisticasUseCase.ListaAlunosReprovados();
                    break;
                
                default:
                    Console.WriteLine(Exceptions.ErrorMessages.INVALID_OPERATION());
                    break;
            }
        }while(entradaSistema != "0");
    }
    
}