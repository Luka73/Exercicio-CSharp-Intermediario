﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaCSharp01.Aula05.Entidades
{
    public class ContaCorrente : ContaBancaria
    {
        private double anuidade;

        public double Anuidade { get => anuidade; set => anuidade = value; }

        public ContaCorrente() //default
        {

        }

        public ContaCorrente(double anuidade, string agencia, string numero, double saldo, Titular titular)
            : base(agencia, numero, saldo, titular)
        {
            this.anuidade = anuidade;
        }


    }
}
