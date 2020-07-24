using POO2.Commons;
using System;
using System.Collections.Generic;
using System.Text;


namespace POO2.General
{
    public class Automovel : Veiculo
    {
        private IConsoleTools _consoleTools = new ConsoleTools();

        public Automovel(string tipo) : base(tipo)
        {

        }
        public override void Mover()
        {
            _consoleTools.Escrever("Acelerando automóvel.");
        }

        public override void Parar()
        {
            _consoleTools.Escrever("Estou parando automóvel.");
        }

    }
}
