using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = [];

Pessoa p1 = new(nome: "Hóspede 1");
Pessoa p2 = new(nome: "Hóspede 2");
Pessoa p3 = new(nome: "Hóspede 3");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");

hospedes.Add(p3);

Suite suite2 = new(tipoSuite: "Premium", capacidade: 5, valorDiaria: 50);

Reserva reserva2 = new(diasReservados: 10);
reserva2.CadastrarSuite(suite2);
reserva2.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva2.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva2.CalcularValorDiaria()}");
