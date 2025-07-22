namespace SistemaAlunos;

public class Aluno
{
    public string Nome { get; set; }
    public decimal Nota1 { get; set; }
    public decimal Nota2 { get; set; }
    public decimal Nota3 { get; set; }

    public decimal Media => (Nota1 + Nota2 + Nota3) / 3;
    public bool Aprovado => Media >= 6;

    public Aluno(string nome, decimal nota1, decimal nota2, decimal nota3)
    {
        Nome = nome;
        Nota1 = nota1;
        Nota2 = nota2;
        Nota3 = nota3;
    }
}