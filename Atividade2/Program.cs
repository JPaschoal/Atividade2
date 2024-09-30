using Atividade2;
using AutoMapper;
using System.Text.Json;

//Crie um arquivo que contém uma classe, que em seu construtor possua todos campos dela preenchidos.
//Converta essa classe para um JSON, armazenado em uma string e printe-o
//#region  1 - Serialização de classes em JSON #endregion
//Converta a string de JSON anterior a classe que foi criada anteriormente#region
//2 - Deserialização de JSON em classes#endregion
//Entenda o conceito de DTO, crie um DTO referente a classe anteriormente criada.
//Caso //utilize um Mapper(AutoMapper) para passar os valores da classe para o dto.
//Nesse DTO ao menos uma das propriedades deve possuir um nome diferente e um tipo diferente, que utilizando o mapper ,será mapeado e convertido para o tipo correto.
//#region  3 - DTO e Mapper
//#endregion
//Faça uma chamada REST utilizando o HttpClient, crie uma classe para o Objeto de retorno da API, serialize o Json recebido na classe. Printe o resultado
//#region  4 - Chamada REST - HttpClient#endregion
//Faça uma chamada REST utilizando o RestClient, crie uma classe para o Objeto de retorno da API, serialize o Json recebido na classe. Printe o resultado
//#region  5 - Chamada REST - RestClient#endregion//Declare uma propriedade de tipo DateTime, utilizando o momento atual como valor de inicialização,
//converta ela para uma nova string e printe ela nesse formato:  DIA@ANO@MES#HORA#MINUTOS (Números com os separadoes @ e #)#region 6 - Conversão de Data#endregion
//Declare uma nova propriedade de tipo DateTime, utilizando o momento atual + 45 dias como valor de inicialização, calcule a diferença em segundos entre ambos
//#region 7 - Calculos Data#endregion//Usando essa mesma solução, crie uma nova biblioteca de classes, verifique o arquivo .csproj da biblioteca de classes que foi gerado após a criação.
//dentro dessa biblioteca de classes importe(using) alguma das classes anteriormente criadas e a utilize.
//verifique novamente o arquivo .csproj, Printe oque aconteceu#region 8 - Biblioteca de classes#endregion
//ref atividade 3  - https://stackoverflow.com/questions/6734659/can-automapper-be-used-in-a-console-application
// INSTALAR PACOTE NUGET https://media.discordapp.net/attachments/691997846039166998/1283475259802259577/image.png//https://media.discordapp.net/attachments/691997846039166998/1283475321802461287/image.png//ref
// atividade 4  - https://viacep.com.br/ pode utilizar essa api publica como exemplo
//1

Carro carro = new Carro("Fusca", "Volkswagen", 1973, "Azul");

string carroJson = JsonSerializer.Serialize(carro);

Console.WriteLine(carroJson);

Carro carro2 = JsonSerializer.Deserialize<Carro>(carroJson);

Console.WriteLine($"{carro2.Modelo} - {carro2.Marca}");

//2

var config = new MapperConfiguration(cfg => cfg.AddProfile<MapperCarro>());
var mapper = new Mapper(config);

CarroDTO carroDTO = mapper.Map<CarroDTO>(carro);

Console.WriteLine($"{carroDTO.Modelo} - {carroDTO.Marca} - {carroDTO.AnoFabricaçao} - {carroDTO.Cor}");

//3

HttpClient client = new HttpClient();
HttpResponseMessage response = await client.GetAsync("https://viacep.com.br/ws/12902020/json/");

if (response.IsSuccessStatusCode)
{
    string responseStr = await response.Content.ReadAsStringAsync();
    Console.WriteLine(responseStr);
    
    Endereco endereco = JsonSerializer.Deserialize<Endereco>(responseStr);
    Console.WriteLine($"{endereco.Logradouro} - {endereco.Localidade}");
}

DateTime data = DateTime.Now;
string dataStr = $"{data.Day}@{data.Year}@{data.Month}#{data.Hour}#{data.Minute}";
Console.WriteLine(dataStr);

