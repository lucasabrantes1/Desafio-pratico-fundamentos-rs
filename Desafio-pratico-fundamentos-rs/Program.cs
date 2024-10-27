using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
using System.Globalization;

class Program
{
    static void Main()
    {
        /*                                        Return
        1. Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas personalizada 
        com o nome dele é exibida:  
        **`Olá, Welisson! Seja muito bem-vindo!`**
        */

        //Console.WriteLine("Olá, seja bem vindo, Digite o seu nome a baixo!; \n");
        //var name = Console.ReadLine();
        //Console.WriteLine("\n");
        //Console.WriteLine($"Olá, {name}! Seja muito bem-vindo!");



        /*
         2. Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário e ao 
         * final exiba o nome completo.*/

        //Console.WriteLine("Olá, seja bem vindo, Digite o seu Primeiro nome a baixo!; \n");
        //var firstName = Console.ReadLine();
        //Console.WriteLine("\n");
        //Console.WriteLine("Agora por favor, digite o seu sobre nome a baixo!; \n");
        //var lastName = Console.ReadLine();
        //Console.WriteLine($"Olá, {firstName} {lastName}! Seja muito bem-vindo!");

        /*
         3. Crie um programa com 2 valores do tipo **`double`** já declarados ****que retorne:
        - A soma entre esses dois números;
        - A subtração entre os dois números;
        - A multiplicação entre os dois números;
        - A divisão entre os dois números (vale uma verificação se o segundo número é 0!);
        - A média entre os dois números.
         */

        //Console.WriteLine("Olá, seja bem vindo, Digite o primeiro número aleatório; \n");
        //double firRadonNumber = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("\n");

        //Console.WriteLine("Agora por favor, digite o segundo número aleatório \n");
        //double secondRandomNumber = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("\n");

        //double sum = firRadonNumber + secondRandomNumber;
        //Console.WriteLine($"A soma entre esses dois números é: {sum} \n");

        //double subtraction = firRadonNumber + secondRandomNumber;
        //Console.WriteLine($"A subtração entre esses dois números é: {subtraction} \n");

        //double multiply = firRadonNumber + secondRandomNumber;
        //Console.WriteLine($"A multiplicaçãos entre esses dois números é: {multiply} \n");


        //if ( firRadonNumber == 0)
        //{
        //    Console.WriteLine($"Não é possível realizar a divisão entre o primeiro numero, pois é zero \n");
        //}
        //else if ( secondRandomNumber == 0)
        //{
        //    Console.WriteLine($"Não é possível realizar a divisão entre o segundo, pois é zero \n");
        //} 
        //else
        //{
        //    double division = firRadonNumber / secondRandomNumber;
        //    Console.WriteLine($"A divisão entre esses dois números é: {division} \n");
        //}


        //double avg = (firRadonNumber + secondRandomNumber) / 2.0 ;
        //Console.WriteLine($"A média entre esses dois números é: {avg} \n");



        /*
        4. Crie um programa em que o usuário digita uma ou mais palavras e 
        é exibido a quantidade de caracteres que a palavra inserida tem.
        */


        //Console.WriteLine("Olá, seja bem vindo, Digite digita uma ou mais palavras a baixo!; \n");
        //var words = Console.ReadLine();
        //Console.WriteLine("\n");
        //var wordsWithoutSpace = words.Trim();
        //var charactersQuantity = wordsWithoutSpace.Length;
        //Console.WriteLine($"A palavra digita tem caracteres {charactersQuantity} sem espaços");


        /*
        5.Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se 
         a placa é válida, seguindo o padrão brasileiro válido até 2018:
        -A placa deve ter 7 caracteres alfanuméricos;
        -Os três primeiros caracteres são letras(maiúsculas ou minúsculas);
        -Os quatro últimos caracteres são números;

        Ao final, o programa deve exibir*** Verdadeiro***se a placa for válida e ***Falso * **caso contrário.
        */

        //Console.WriteLine("Olá, seja bem vindo, Digite digita a placa a baixo! sem - ; \n");
        //var licensePlate = Console.ReadLine();

        //if (licensePlate.Length  != 7)
        //{
        //    Console.WriteLine("A placa precisa ter 7 caracteres");
        //    Console.WriteLine("***Falso***");
        //    return;
        //}

        //if (licensePlate.Contains("-"))
        //{
        //    Console.WriteLine("A placa não pode conter caracteres especiais.");
        //    Console.WriteLine("***Falso***");
        //    return;
        //}


        //var firstThreeCharacters = licensePlate.Substring(0, 3);
        //if (!firstThreeCharacters.All(char.IsLetter))
        //{
        //    Console.WriteLine("Os três primeiros caracteres devem ser letras.");
        //    Console.WriteLine("***Falso***");
        //    return;
        //}


        //var lastFourCharacters = licensePlate.Substring(3, 4);
        //if (!lastFourCharacters.All(char.IsDigit))
        //{
        //    Console.WriteLine("Os quatro últimos caracteres devem ser números.");
        //    Console.WriteLine("***Falso***");
        //    return;
        //}

        //Console.WriteLine("***Verdadeiro*** - Placa válida.");



        /* 6.Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
         -Formato completo(dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
         -Apenas a data no formato "01/03/2024".
         - Apenas a hora no formato de 24 horas.
         - A data com o mês por extenso.
        */

        DateTime dataAtual = DateTime.Now;

        Console.WriteLine("Escolha o formato de exibição da data:");
        Console.WriteLine("1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)");
        Console.WriteLine("2 - Apenas a data no formato \"dd/MM/yyyy\"");
        Console.WriteLine("3 - Apenas a hora no formato de 24 horas");
        Console.WriteLine("4 - A data com o mês por extenso");

        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Console.WriteLine("Formato completo: " + dataAtual.ToString("dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss", new CultureInfo("pt-BR")));
                break;

            case "2":
                Console.WriteLine("Apenas a data: " + dataAtual.ToString("dd/MM/yyyy"));
                break;

            case "3":
                Console.WriteLine("Apenas a hora: " + dataAtual.ToString("HH:mm"));
                break;

            case "4":
                Console.WriteLine("Data com mês por extenso: " + dataAtual.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR")));
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;

        }
    }

}