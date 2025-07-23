using System.Globalization;

namespace SistemaAlunos.UseCases;

public static class MostrarEstatisticas
{
    public static void Mostrar()
    {
        string entradaSistema = "";
        do
        {
            Console.Write("\nESCOLHA A ESTATÍSTICA DESEJADA: \n \n" +
                          " 0 - SAIR DO SISTEMA;\n " +
                          "1 - ALUNOS APROVADOS;\n " +
                          "2 - ALUNOS REPROVADOS;\n \n " +
                          "DIGITE A OPERAÇÂO DESEJADA: ");
    
            entradaSistema = Console.ReadLine();

            switch (entradaSistema)
            {
                case "0":
                    Console.WriteLine("ENCERRANDO SISTEMA...");
                    break;
                case "1":
                    foreach (var aluno in RepositorioAlunos.ListaAlunos)
                    {
                        if (aluno.Aprovado)
                            Console.WriteLine($"NOME: {aluno.Nome} || MÉDIA FINAL: {aluno.Media:F2} || STATUS: APROVADO");
                        

                    }
                    break;
                case "2":
                    foreach (var aluno in RepositorioAlunos.ListaAlunos)
                    {
                        if (aluno.Aprovado == false)
                        {
                            Console.WriteLine($"NOME: {aluno.Nome} || MÉDIA FINAL: {aluno.Media:F2} || STATUS: REPROVADO");
                        }
                    }
                    
                    break;
                default:
                    Console.WriteLine("INSIRA UMA OPERAÇÃO VÁLIDA");
                    break;
            }
    
    
        }while(entradaSistema != "0");
    }
}