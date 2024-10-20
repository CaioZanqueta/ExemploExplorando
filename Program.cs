using System.Globalization;
using ExemploExplorando.Models;

new ExemploExcecao().Metodo1();



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


