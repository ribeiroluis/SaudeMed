/***********************************************************************
 * Module:  Venda.cs
 * Author:  LuisHenrique
 * Purpose: Definition of the Class Venda
 ***********************************************************************/

using System;

public class Venda
{
   public void Listar()
   {
      // TODO: implement
   }
   
   public void Inseir()
   {
      // TODO: implement
   }
   
   public void Atualizar()
   {
      // TODO: implement
   }
   
   public void Excluir()
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

   private int IdVenda;
   private int IdFuncionario;
   private int IdCliente;
   private float SubTotalVenda;
   private float ValorDesconto;
   private float ValorVenda;
   private float DescontoMaximo;
   private DateTime DataVenda;

}