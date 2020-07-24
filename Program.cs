using POO2.Commons;
using POO2.General;
using System;
        
namespace POO2
{
    class Program
    {
        static void Main(string[] args)
        {

            Aeronave aeronave = new Aeronave("Aeronave");
            aeronave.Mover();
            aeronave.Parar();

            Automovel automovel = new Automovel("Automóvel");
            automovel.Mover();
            automovel.Parar();

            //ContaBancaria contaBancaria = new ContaBancaria();

            //contaBancaria.Depositar(200);
            //contaBancaria.Sacar(100);
            //contaBancaria.Depositar(500);

            //contaBancaria.ConsultarSaldo();

        }
    }
}
