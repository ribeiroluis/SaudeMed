/***********************************************************************
 * Module:  ItensProduto.cs
 * Author:  LuisHenrique
 * Purpose: Definition of the Class ItensProduto
 ***********************************************************************/

using System;
namespace SaudeMed
{

    public class ItensProduto : Protudo
    {
        public new void Atualizar()
        {
            // TODO: implement
        }

        public new void Excluir()
        {
            // TODO: implement
        }

        public new void Inseir()
        {
            // TODO: implement
        }

        public new void Listar()
        {
            // TODO: implement
        }

        public System.Collections.ArrayList itensdeVenda;

        /// <pdGenerated>default getter</pdGenerated>
        public System.Collections.ArrayList GetItensdeVenda()
        {
            if (itensdeVenda == null)
                itensdeVenda = new System.Collections.ArrayList();
            return itensdeVenda;
        }

        /// <pdGenerated>default setter</pdGenerated>
        public void SetItensdeVenda(System.Collections.ArrayList newItensdeVenda)
        {
            RemoveAllItensdeVenda();
            foreach (ItensdeVenda oItensdeVenda in newItensdeVenda)
                AddItensdeVenda(oItensdeVenda);
        }

        /// <pdGenerated>default Add</pdGenerated>
        public void AddItensdeVenda(ItensdeVenda newItensdeVenda)
        {
            if (newItensdeVenda == null)
                return;
            if (this.itensdeVenda == null)
                this.itensdeVenda = new System.Collections.ArrayList();
            if (!this.itensdeVenda.Contains(newItensdeVenda))
                this.itensdeVenda.Add(newItensdeVenda);
        }

        /// <pdGenerated>default Remove</pdGenerated>
        public void RemoveItensdeVenda(ItensdeVenda oldItensdeVenda)
        {
            if (oldItensdeVenda == null)
                return;
            if (this.itensdeVenda != null)
                if (this.itensdeVenda.Contains(oldItensdeVenda))
                    this.itensdeVenda.Remove(oldItensdeVenda);
        }

        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllItensdeVenda()
        {
            if (itensdeVenda != null)
                itensdeVenda.Clear();
        }

        private int IdItemProduto;
        private int Quantidade;
        private DateTime Validade;
        private int Lote;

    }
}