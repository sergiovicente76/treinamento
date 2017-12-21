using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02.Model
{
    public abstract class Conta
    {
        public int Agencia { get; set; }

        public int Numero { get; set; }

        public decimal Saldo { get; set; }

        protected List<Item> _extrato = new List<Item>();

        public virtual void Depositar(decimal valor)
        {
            Saldo += valor;

            _extrato.Add(new Item()
            {
                Data = DateTime.Now,
                Valor = valor ,
                Tipo = TipoItem.Deposito,
                Saldo = this.Saldo
            });
        }

        public virtual void Sacar(decimal valor)
        {
            Saldo -= valor;

            _extrato.Add(new Item()
            {
                Data = DateTime.Now,
                Valor = valor * -1,
                Tipo = TipoItem.Saque,
                Saldo = this.Saldo
            });
        }

        public abstract void Movimentar();

        public Item[] ObterExtrato()
        {
            return _extrato.ToArray();
        }






    }
}
