using CP1.Models;
using System;

namespace CP1.Models
{
    public class EntregadorMoto : FuncionarioTransporte
    {
        public string PlacaMoto { get; private set; }
        public bool TemBau { get; private set; }

        public EntregadorMoto(string nome, string registro, string placaMoto, bool temBau)
            : base(nome, registro)
        {
            PlacaMoto = placaMoto;
            TemBau = temBau;
        }

        public override void MostrarDetalhes()
        {
            Console.WriteLine("--- Entregador de Moto ---");
            base.MostrarDetalhes();
            Console.WriteLine($"Placa: {PlacaMoto} | Possui Baú: {(TemBau ? "Sim" : "Não")}\n");
        }
    }
}