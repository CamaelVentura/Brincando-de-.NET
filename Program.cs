using System;

namespace DigitalInovationOne
{
    class Program
    {
    static void Main(string[] args)
    {
        Aluno[] alunos = new Aluno[5];
        var idAluno = 0;
        string opUsuario = ObterUsuario();

        while (opUsuario.ToUpper() != "X")
        {
            switch (opUsuario)
            {
            case "1":
                Aluno aluno = new Aluno();
                Console.WriteLine("Digite o nome do aluno: ");
                aluno.Nome = Console.ReadLine();
                Console.WriteLine("Digite a nota do aluno: ");
                if(decimal.TryParse(Console.ReadLine(), out decimal nota))
                    aluno.Nota = nota;
                else
                    throw new ArgumentException("O Valor da nota deve ser decimal");

                alunos[idAluno] = aluno;
                idAluno++;
                break;
            case "2":
                foreach (var cadaAluno in alunos)
                {
                    if(!string.IsNullOrEmpty(cadaAluno.Nome))
                        Console.WriteLine("Aluno: {0} - Nota: {1}", cadaAluno.Nome, cadaAluno.Nota);
                }
                Console.ReadKey();
                break;
            case "3":
                decimal notaTotal = 0;
                int numAlunos = 0;
                for (int i = 0; i < alunos.Length; i++)
                {
                    if(!string.IsNullOrEmpty(alunos[i].Nome)){
                        notaTotal += alunos[i].Nota;
                        numAlunos++;
                    }
                        
                }
                decimal media = 0;
                if(numAlunos > 0)
                    media = notaTotal / numAlunos;
                else
                    throw new DivideByZeroException();

                Conceito conceitoGeral;
                if(media >= 8){
                    conceitoGeral = Conceito.A;
                }else if(media >= 6){
                    conceitoGeral = Conceito.B;
                }else if(media >= 4){
                    conceitoGeral = Conceito.C;
                }else if(media >= 2){
                    conceitoGeral = Conceito.D;
                }else {
                    conceitoGeral = Conceito.E;
                }
                Console.WriteLine("Média geral: {0} - Conceito: {1}", media, conceitoGeral);
                Console.ReadKey();    

                break;
            default:
                throw new ArgumentOutOfRangeException();
            }
            opUsuario = ObterUsuario();
        }

    }

    private static string ObterUsuario()
    {
      string opUsuario;
      Console.Clear();
      Console.WriteLine("Informe a opção desejada:");
      Console.WriteLine("1- Inserir novo aluno");
      Console.WriteLine("2- Listar alunos");
      Console.WriteLine("3- Calcular média geral");
      Console.WriteLine("X - Sair");
      Console.WriteLine();

      opUsuario = Console.ReadLine();
      return opUsuario;
    }
  }
}
