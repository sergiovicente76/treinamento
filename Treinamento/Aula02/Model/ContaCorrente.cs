using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02.Model
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;


        }

        private void TributarImposto(decimal valor)
        {
            var imposto = (valor * CPMF);

            this.Saldo -= imposto;

            _extrato.Add(new Item()
            {
                Data = DateTime.Now,
                Saldo = this.Saldo,
                Valor = imposto * -1
            });
        }

        private const decimal CPMF = 0.001m;

        public override void Sacar(decimal valor)
        {
            base.Sacar(valor);

            TributarImposto(valor);



        }

        public override void Depositar(decimal valor)
        {
            base.Depositar(valor);

            TributarImposto(valor);
        }


        public override void Movimentar()
        {
            throw new NotImplementedException();
        }
    }
}
