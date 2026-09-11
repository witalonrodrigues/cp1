using CP1.Models;
using System;

namespace CP1.Models
{
    public class MotoristaCarreta : FuncionarioTransporte
    {
        public string PlacaVeiculo { get; private set; }
        public string CategoriaCNH { get; private set; }

        public MotoristaCarreta(string nome, string registro, string placaVeiculo, string categoriaCnh)
            : base(nome, registro)
        {
            PlacaVeiculo = placaVeiculo;
            CategoriaCNH = categoriaCnh;
        }

        public override void MostrarDetalhes()
        {
            Console.WriteLine("--- Motorista de Carreta ---");
            base.MostrarDetalhes();
            Console.WriteLine($"Placa: {PlacaVeiculo} | Categoria CNH: {CategoriaCNH}\n");
        }
    }
}