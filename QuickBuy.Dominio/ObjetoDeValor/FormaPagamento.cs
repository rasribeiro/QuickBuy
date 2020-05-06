﻿using QuickBuy.Dominio.Entidades;
using QuickBuy.Dominio.Enumerados;

namespace QuickBuy.Dominio.ObjetoDeValor
{
    public class FormaPagamento : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool EhBoleto
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Boleto; }
        }
        public bool EhCartaoCredido
        {
            get { return Id == (int)TipoFormaPagamentoEnum.CartaoCredito; }
        }
        public bool EhDeposito
        {
            get { return Id == (int)TipoFormaPagamentoEnum.Deposito; }
        }
        public bool EhNaoFoiDefinido
        {
            get { return Id == (int)TipoFormaPagamentoEnum.NaoDefinido; }
        }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
