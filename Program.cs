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


DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

DateTime dataSomada = DateTime.Now.AddDays(15);
Console.WriteLine(dataSomada);
Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));