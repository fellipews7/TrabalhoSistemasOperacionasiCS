using System.Diagnostics;

String opcao;


Console.WriteLine("Digite a opção desejada: ");

Console.WriteLine("1 - Informações do sistema");
Console.WriteLine("2 - Ajuda sobre o sistema");
Console.WriteLine("3 - Iniciar o navegador");
Console.WriteLine("4 - Criar um diretório");
Console.WriteLine("5 - Criar arquivo");

opcao = Console.ReadLine();

if (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4" && opcao != "5")
{
    Console.WriteLine("Valor digitado incorreto.");
    return;
}

if (opcao == "1")
{
    Versao();
}
else if (opcao == "2")
{
    Help();   
}
else if (opcao == "3")
{
    IniciarChrome();
}
else if (opcao == "4")
{
    CriarDiretorio();
}
else if (opcao == "5")
{
    CriarArquivo();
}


static void Versao ()
{
    Console.WriteLine("Versão do programa: 1.0.0 \b Programa criado para aula de Sistemas operacionais.");
}

static void Help ()
{
    Console.WriteLine("O sistema tem como objetivo suprir as necessidades do professor Leanderson \b" +
        "O professor lançou o desafio de fazer um programa simples em qualquer linguagem. A linguagem escolhida foi C#. \b" +
        "O programa fará algumas ações simples como Iniciar o navegador, criar um diretório, etc.");
}

static void IniciarChrome ()
{
    Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe");
}

static void CriarDiretorio()
{
    String diretorio;
    String nomePasta;

    Console.WriteLine("Digite o caminho do diretório onde a pasta será criada:");
    diretorio = Console.ReadLine();

    if (!Directory.Exists(diretorio))
    {
        Console.WriteLine("Diretório informado não existe!");
        return;
    }

    Console.WriteLine("Digite o nome da pasta que você deseja criar: ");
    nomePasta = Console.ReadLine();

    Directory.CreateDirectory(Path.Combine(diretorio, nomePasta));

    Console.WriteLine("Seu diretório foi criado com sucesso!");
}

static void CriarArquivo ()
{
    String diretorio;
    String nomeArquivo;

    Console.WriteLine("Digite o caminho do diretório onde a pasta será criada:");
    diretorio = Console.ReadLine();

    if (!Directory.Exists(diretorio))
    {
        Console.WriteLine("Diretório informado não existe!");
        return;
    }

    Console.WriteLine("Digite o nome do Arquivo que você deseja criar: ");
    nomeArquivo = Console.ReadLine();

    File.Create(Path.Combine(diretorio, nomeArquivo)).Close();

    Console.WriteLine("Seu arquivo foi criado com sucesso!");
}

Console.WriteLine(opcao);