using ExemploFundamentos.Common.Models;

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


// bool naoEstuda = true;
// bool naoTrabalha = true;

// if (!naoEstuda && !naoTrabalha)
// {
//     Console.WriteLine("Vagabundo");
// }
// else if (naoEstuda && !naoTrabalha)
// {
//     Console.WriteLine("Trabalha, mas não estuda");
// }
// else {
//     Console.WriteLine("Morreu por dentro");
//     //pq estuda e trabalha
// }


//OPERADORES ARITMÉTICOS

//Calculadora calc = new Calculadora();

// calc.Somar(5, 7);
// calc.Subtrair(12, 63);
// calc.Multiplicar(32, 19);
// calc.Dividir(9, 3);
// calc.Potencia(10, 5);
// calc.Seno(56);
// calc.Coseno(56);
// calc.Tangente(56);
// calc.RaizQuadrada(49);

// int coposAhcomprar = int.Parse(Console.ReadLine());
// int coposQueTenho = int.Parse(Console.ReadLine());

// Console.WriteLine($"Eu terei {coposAhcomprar + coposQueTenho} copos");

       //ESTRUTURAS DE REPETIÇÃO

// int numero = 7;

// for(int contador = 0; contador <= 10; contador++)
// {
//         Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }

// int treze = 13;
// for (int contador2 = 0; contador2 <= 10; contador2++)
// {
//         Console.WriteLine($"{treze} x {contador2} = {treze * contador2}");
// }

// int precoDoCarro = 10000;
// for ( int carroComprado = 0; carroComprado <= 20; carroComprado++)
// {
//         Console.WriteLine($"Total vendido: {precoDoCarro * carroComprado}");
// }


// int numero = 7;
// int contador = 0;
// while (contador <= 10) {
//         Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//         contador++;

//         if (contador == 8)
//         {
//                 break;
//                 //parou o código no 8
//         }
// }


// int soma = 0, numero = 0;

// do
// {
//         Console.WriteLine("Digite um número (0 para parar)");
//         numero = Convert.ToInt32(Console.ReadLine());

//         soma += numero;
// } while (numero != 0);

// Console.WriteLine($"Total da soma dos números dgitados é: {soma}");

// int pipa = 0;
// int somar = 0;

// do
// {
//         Console.WriteLine("Digite a quantidade de pipas que deseja comprar(0 para parar)");
//         pipa = Convert.ToInt32(Console.ReadLine());

//         somar += pipa;
// } while (pipa != 0);

// Console.WriteLine($"O total de pipas que vc comprou é: {somar}");


// string opcao;

// while (true)
// {
//         Console.Clear();
//         Console.WriteLine("Digite uma opção: ");
//         Console.WriteLine("1 - Cadastrar cliente");
//         Console.WriteLine("2 - buscar clientes");
//         Console.WriteLine("3 - Apagar cliente");
//         Console.WriteLine("4 - Encerrar");

//         opcao = Console.ReadLine();

//         switch(opcao)
//         {
//                 case "1":
//                         Console.WriteLine("Cadastro do cliente: ");
//                         break;
//                 case "2":
//                         Console.WriteLine("Busca de clientes: ");
//                         break;
//                 case "3":
//                 Console.WriteLine("Apagar cliente");
//                 break;

//                 case "4":
//                         Console.WriteLine("Encerrar");
//                         Environment.Exit(0);
//                         break;

//                 default: 
//                         Console.WriteLine("Opção inválida");
//                         break;

//         }
// }
