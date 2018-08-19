﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DesktopApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class InventoryEntities : DbContext
    {
        public InventoryEntities()
            : base("name=InventoryEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Inventory_List> Inventory_Lists { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Measurement> Measurements { get; set; }
    
        public virtual int Updateinventory(Nullable<int> itemid, string itemCode, string inventType, string itemDescription, string prefVendor, string reorderPointMin, string reorderPointMax, string quantityonHand, string quantityonOrder, string quantityonAvailable, string markupLevel, string cost)
        {
            var itemidParameter = itemid.HasValue ?
                new ObjectParameter("Itemid", itemid) :
                new ObjectParameter("Itemid", typeof(int));
    
            var itemCodeParameter = itemCode != null ?
                new ObjectParameter("ItemCode", itemCode) :
                new ObjectParameter("ItemCode", typeof(string));
    
            var inventTypeParameter = inventType != null ?
                new ObjectParameter("InventType", inventType) :
                new ObjectParameter("InventType", typeof(string));
    
            var itemDescriptionParameter = itemDescription != null ?
                new ObjectParameter("ItemDescription", itemDescription) :
                new ObjectParameter("ItemDescription", typeof(string));
    
            var prefVendorParameter = prefVendor != null ?
                new ObjectParameter("PrefVendor", prefVendor) :
                new ObjectParameter("PrefVendor", typeof(string));
    
            var reorderPointMinParameter = reorderPointMin != null ?
                new ObjectParameter("ReorderPointMin", reorderPointMin) :
                new ObjectParameter("ReorderPointMin", typeof(string));
    
            var reorderPointMaxParameter = reorderPointMax != null ?
                new ObjectParameter("ReorderPointMax", reorderPointMax) :
                new ObjectParameter("ReorderPointMax", typeof(string));
    
            var quantityonHandParameter = quantityonHand != null ?
                new ObjectParameter("QuantityonHand", quantityonHand) :
                new ObjectParameter("QuantityonHand", typeof(string));
    
            var quantityonOrderParameter = quantityonOrder != null ?
                new ObjectParameter("QuantityonOrder", quantityonOrder) :
                new ObjectParameter("QuantityonOrder", typeof(string));
    
            var quantityonAvailableParameter = quantityonAvailable != null ?
                new ObjectParameter("QuantityonAvailable", quantityonAvailable) :
                new ObjectParameter("QuantityonAvailable", typeof(string));
    
            var markupLevelParameter = markupLevel != null ?
                new ObjectParameter("MarkupLevel", markupLevel) :
                new ObjectParameter("MarkupLevel", typeof(string));
    
            var costParameter = cost != null ?
                new ObjectParameter("Cost", cost) :
                new ObjectParameter("Cost", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Updateinventory", itemidParameter, itemCodeParameter, inventTypeParameter, itemDescriptionParameter, prefVendorParameter, reorderPointMinParameter, reorderPointMaxParameter, quantityonHandParameter, quantityonOrderParameter, quantityonAvailableParameter, markupLevelParameter, costParameter);
        }
    }
}
