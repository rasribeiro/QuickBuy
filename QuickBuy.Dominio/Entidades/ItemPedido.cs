﻿namespace QuickBuy.Dominio.Entidades
{
    class ItemPedido : Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int MyProperty { get; set; }

        public override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
    