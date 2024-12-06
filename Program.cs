using System.Globalization;
using ExemploExplorando.Models;


Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

Console.WriteLine(estados["MG"]);

// foreach (var item in estados) {
//   Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine("----------------------------");

// estados.Remove("BA");
// estados["SP"] = "São Paulo - VALOR ALTERADO";

// foreach (var item in estados) {
//   Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// String chave = "BA2";
// Console.WriteLine($"Verificando o elemento: {chave}");

// if (estados.ContainsKey(chave)) {
//   Console.WriteLine($"Valor existente: {chave}");
// } else {
//   Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }

// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);


// foreach (int item in pilha) {
//   Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {pilha.Pop()}");
// pilha.Push(20);
// foreach (int item in pilha) {
//   Console.WriteLine(item);
// }

// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila) {
//   Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);
// foreach (int item in fila) {
//   Console.WriteLine(item);
// }

// new ExemploExcecao().Metodo1();



// try {
//   string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//   foreach (string linha in linhas) {
//     Console.WriteLine(linha);
//   }
// } catch (FileNotFoundException ex) {
//   Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// } catch (DirectoryNotFoundException ex) {
//   Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
// } catch (Exception ex) {
//   Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// } finally {
//   Console.WriteLine("Chegou até aqui");
// }


// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// Pessoa p1 = new Pessoa(nome: "Caio", sobrenome: "Zanqueta");
// Pessoa p2 = new Pessoa(nome: "Ana", sobrenome: "Carolina");

// Curso cursoDeIngles = new Curso();

// cursoDeIngles.Nome = "Inglês";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();


// decimal valorMonetario = 1582.40M;
// // Console.WriteLine($"{valorMonetario:C}");
// // Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
// Console.WriteLine(valorMonetario.ToString("C2"));


// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("P"));


// long numero = 11977771412;
// Console.WriteLine(numero.ToString("## #####-####"));


// DateTime data = DateTime.Now;
// Console.WriteLine(data.ToShortDateString());
// Console.WriteLine(data.ToShortTimeString());


// string dataString = "2024-10-07 02:30";
// DateTime data = DateTime.Parse(dataString);
// Console.WriteLine(data);


// string dataString = "2024-10-07 02:30";
// bool sucesso = DateTime.TryParseExact(dataString,
//                                       "yyyy-MM-dd HH:mm",
//                                       CultureInfo.InvariantCulture,
//                                       DateTimeStyles.None,
//                                       out DateTime data);
// if (sucesso) {
//   Console.WriteLine($"Conversão com sucesso! Data: {data}");
// } else {
//   Console.WriteLine($"{dataString} não é uma data válida");
// }


