using CP1.Models;
using System;

namespace CP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema De Logística para Transportadora\n");

            MotoristaCarreta motorista = new MotoristaCarreta("Alexandre", "REG001", "ABC-1234", "E");
            EntregadorMoto entregador = new EntregadorMoto("Enzo", "REG002", "XYZ-9876", true);

            FuncionarioTransporte[] frota = new FuncionarioTransporte[]
            {
                motorista,
                entregador
            };

            foreach (FuncionarioTransporte funcionario in frota)
            {
                funcionario.MostrarDetalhes();
            }

            Console.ReadLine();
        }
    }
}