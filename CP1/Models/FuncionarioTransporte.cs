using System;

namespace CP1.Models
{
    public abstract class FuncionarioTransporte
    {
        public string Nome { get; private set; }
        public string Registro { get; private set; }

        public FuncionarioTransporte(string nome, string registro)
        {
            Nome = nome;
            Registro = registro;
        }

        public virtual void MostrarDetalhes()
        {
            Console.WriteLine($"Nome: {Nome} | Registro: {Registro}");
        }
    }
}