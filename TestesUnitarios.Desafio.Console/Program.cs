using TestesUnitarios.Desafio.Console.Services;


string Entrada(){
    Console.Write("Digite o texto de entrada: ");
    string texto = Console.ReadLine();
    return texto;
}


void Continuar(){
    Console.Write("Continuar? ");
    Console.ReadLine();
    Main();
}

void Main(){

    ValidacoesString validacoesString = new ValidacoesString();

    Console.Clear();

    Console.WriteLine("Ola. Para começar, escolha uma das opções: ");

    List<string> opcoes = new List<string>(){
        "1 - Quantidade de caracteres em uma string",
        "2 - Contem caractere?",
        "3 - Texto termina com caractere?",
        "4 - Sair"
    };

    foreach(string opcao in opcoes){
        Console.WriteLine(opcao);
    }

    Console.Write("Qual a sua opção? ");
    int numero = int.Parse(Console.ReadLine());

    switch(numero){
        case 1:
            string entrada1 = Entrada();
            Console.WriteLine($"O texto {entrada1} tem {validacoesString.RetornarQuantidadeCaracteres(entrada1)} caracteres");
            Continuar();
            break;
        case 2:
            string entrada2 = Entrada();
            Console.Write("Agora digite o texto que pode estar contido: ");
            string texto = Console.ReadLine();
            if(validacoesString.ContemCaractere(entrada2, texto))
            {
                Console.WriteLine($"O texto '{texto}' está contido em '{entrada2}'");
            }
            else
            {
                Console.WriteLine($"O texto '{texto}' não está contido em '{entrada2}'");
            }
            Continuar();
            break;
        case 3:
            string entrada3 = Entrada();
            Console.Write("Agora digite o texto que o texto pode terminar: ");
            string textoAterminar = Console.ReadLine();
            if(validacoesString.TextoTerminaCom(entrada3, textoAterminar)){
                Console.WriteLine($"O texto '{entrada3}' termina com '{textoAterminar}'");
            }
            else{
                Console.WriteLine($"O texto '{entrada3}' não termina com '{textoAterminar}'");
            }
            break;
        case 4:
            break;
        
    }
}

Main();



