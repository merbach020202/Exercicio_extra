using Exercicios_para_pratica;
Andares andares = new Andares();

Console.WriteLine(@$"
-----------------------
|                      |
|    Bem-vido(a) ao    |
|    menu elevador!    |
|                      |
-----------------------
");

andares.Inicializa();


string menu;

do
{
    Console.WriteLine(@$"
--------------------------------------------------------------
|                       Escolha uma opção                    |
|                              abaixo!                       |
|                                                            |
| 1 - Para uma pessoa entrar no elevador                     |
| 2 - Para uma pessoa sair do elevador                       |
| 3 - Para o elevador subir um andar                         |
| 4 - Para o elevador descer um andar                        |
|                                                            |
| 0 - Encerrar o programa                                    |
--------------------------------------------------------------
");

Console.WriteLine(@$"
Pessoas dentro do elevador: {Elevador.PessoasPresentes}
Andar em que o elevador se encontra: {Elevador.AndarAtual}º

");



    menu = Console.ReadLine();

    switch (menu)
    {
        case "1":
            andares.entrar();
            break;

        case "2":
            andares.sair();
            break;

        case "3":
            andares.subir();
            break;

        case "4":
            andares.descer();
            break;

        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@$"
Programa encerrado!");
            Console.ResetColor();
            break;
    }

} while (menu != "0");







