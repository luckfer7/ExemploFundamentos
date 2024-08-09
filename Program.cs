using ExemploFundamentos.Models;

// Pessoa pessoa1 = new Pessoa();

// pessoa1.Name = "Lucas";
// pessoa1.Age = 26;
// pessoa1.Height = 1.91M;
// pessoa1.ToShow();

// Pessoa pessoaDois = new Pessoa();

// pessoaDois.Name = "Vanessa";
// pessoaDois.Age = 29;
// pessoaDois.Height = 1.63M;
// pessoaDois.ToShow();


// DateTime dataAtual = DateTime.Now;
// Console.WriteLine(dataAtual);

// DateTime dataSomada = DateTime.Now.AddDays(15);
// Console.WriteLine(dataSomada);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));

//TIPOS DE OPERADORES NO C#

// int a = 10;
// int b = 20;

// int c = a + b;
//c = c + 20;
// c += 20;


// int d = Convert.ToInt32(null);
// int e = int.Parse();

// Console.WriteLine(e);
// Console.WriteLine(d);

// int inteiro = 5;
// string f = inteiro.ToString();

// Console.WriteLine(f);

// double g = 5 / (6 + 3);
// Console.WriteLine(g);


// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;
// int restante = quantidadeEmEstoque - quantidadeCompra;

// Console.WriteLine($"quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"quantidade sendo comprada: {quantidadeCompra}");
// Console.WriteLine($"Épossível realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda inválida");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Tem estoque");
// }
// else
// {
//     Console.WriteLine("Não tem estoque");
// }

// Console.WriteLine($"Quantidade restante em estoque: {restante}");

// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal");
// }

//ou podemos fazer um switch case

// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;

//     default:
//         Console.WriteLine("não é uma vogal");
//         break;
// }

        //OPERADORES OR, AND E NOT.

// bool ehMaiorDeIdade = true;
// bool temAutorizacaoLegal = false;

// if (ehMaiorDeIdade || temAutorizacaoLegal)
// {
//     Console.WriteLine("Pode entrar");
// }
// else
// {
//     Console.WriteLine("Não pode entrar");
// }


// int idadePermitida = 18;
// int clienteIdade = int.Parse(Console.ReadLine());

// if (clienteIdade >= idadePermitida)
//  {
//     Console.WriteLine("Aprovado");
//  }
//  else 
//  {
//     Console.WriteLine("Reprovado");
//  }

// bool possuiPresencaMinima = true;
// double media = 5.5;

// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado");
// }
// else 
// {
//     Console.WriteLine("Reprovado");
// }

// bool temCaderno = true;
// bool temCaneta = true;

// if (temCaderno && !temCaneta)
// {
//     Console.WriteLine("Faça anotações");
// } 
// else
// {
//     Console.WriteLine("Não faça anotações");
// }

// bool temCafe = true;

// if (!temCafe)
// {
//     Console.WriteLine("Comprar café");
// }
// else 
// {
//     Console.WriteLine("Não comprar café");
// }


bool naoEstuda = true;
bool naoTrabalha = true;

if (!naoEstuda && !naoTrabalha)
{
    Console.WriteLine("Vagabundo");
}
else if (naoEstuda && !naoTrabalha)
{
    Console.WriteLine("Trabalha, mas não estuda");
}
else {
    Console.WriteLine("Morreu por dentro");
    //pq estuda e trabalha
}