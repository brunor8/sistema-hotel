using System.Text;
using SistemaHotel.Models;

Console.OutputEncoding = Encoding.UTF8;

//cria modelos de hospedes e cadastra na lista de hospedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hospede 1");
Pessoa p2 = new Pessoa(nome: "Hospede 2");
Pessoa p3 = new Pessoa(nome: "Hospede 3");
Pessoa p4 = new Pessoa(nome: "Hospede 4");
Pessoa p5 = new Pessoa(nome: "Hospede 5");

hospedes.Add(p1);
hospedes.Add(p2);
hospedes.Add(p3);
hospedes.Add(p4);
hospedes.Add(p5);

//cria a suite
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 5, valorDiaria: 500);

//cria nova reserva, passando suite e hospedes
Reserva reserva = new Reserva(diasReservados: 10);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

//Exibe a qtd de hospedes e valor da diaria
System.Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
System.Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");