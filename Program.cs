﻿string opcaoUsuario = ObterOpcaoUsuario();

while (opcaoUsuario.ToUpper() != "X")
{
    switch (opcaoUsuario)
    {
        case "1":
            //TODO: adicionar aluno
            break;
        case "2":
            //TODO: listar alunos
            break;
        case "3":
            //TODO: calcular média geral
            break;
        default:
            throw new ArgumentOutOfRangeException();
    }

    Console.WriteLine("Informe a opção desejada:");
    Console.WriteLine("1 - Inserir novo aluno");
    Console.WriteLine("2 - Listar alunos");
    Console.WriteLine("3 - Calcular média geral");
    Console.WriteLine("X - Sair");
    Console.WriteLine();

    opcaoUsuario = Console.ReadLine();
}

static string ObterOpcaoUsuario()
{
    Console.WriteLine("Informe a opção desejada:");
    Console.WriteLine("1 - Inserir novo aluno");
    Console.WriteLine("2 - Listar alunos");
    Console.WriteLine("3 - Calcular média geral");
    Console.WriteLine("X - Sair");
    Console.WriteLine();

    String opcaoUsuario = Console.ReadLine();
    return opcaoUsuario;
}