﻿using POO2.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace POO2.General
{
    public class ContaBancaria : Humano
    {
        public string Conta { get; set; }
        public string Agencia { get; set; }
        public int Saldo { get; set; }
        public IConsoleTools _consoleTools = new ConsoleTools();
        public ContaBancaria()
        {
            _consoleTools.Escrever("Digite o seu nome: ");
            Nome = _consoleTools.Ler();
        }

        public void Depositar (int valor)
        {
            Saldo += valor;
        }

        public void Sacar (int valor)
        {
            Saldo -= valor;
        }

        public void ConsultarSaldo()
        {

            _consoleTools.Escrever($"{Nome} o seu saldo é : {Saldo}");


        }
    }
}
