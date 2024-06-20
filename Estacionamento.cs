using System;
using System.Collections.Generic;
using System.Linq;

public class Estacionamento
{
    private decimal precoInicial;
    private decimal precoPorHora;
    private List<string> veiculos;

    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        this.precoInicial = precoInicial;
        this.precoPorHora = precoPorHora;
        this.veiculos = new List<string>();
    }

    public void AdicionarVeiculo()
    {
        // Pedir para o usuário digitar uma placa e adicionar na lista "veiculos"
        Console.WriteLine("Digite a placa do veículo para estacionar:");
        string placa = Console.ReadLine();
        veiculos.Add(placa);
        Console.WriteLine($"Veículo com placa {placa} adicionado com sucesso.");
    }

    public void RemoverVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para remover:");
        // Pedir para o usuário digitar a placa e armazenar na variável placa
        string placa = Console.ReadLine();

        // Verifica se o veículo existe
        if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
        {
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
            // Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado
            int horas = int.Parse(Console.ReadLine());
            
            // Realizar o cálculo: "precoInicial + precoPorHora * horas"
            decimal valorTotal = precoInicial + precoPorHora * horas;

            // Remover a placa digitada da lista de veículos
            veiculos.Remove(placa);

            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
        }
        else
        {
            Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
        }
    }

    public void ListarVeiculos()
    {
        // Verifica se há veículos no estacionamento
        if (veiculos.Any())
        {
            Console.WriteLine("Os veículos estacionados são:");
            // Laço de repetição para exibir os veículos estacionados
   
