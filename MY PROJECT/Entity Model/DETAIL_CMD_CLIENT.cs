//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MY_PROJECT.Entity_Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class DETAIL_CMD_CLIENT
    {
        public int ID_PRODUIT { get; set; }
        public int ID_CMD { get; set; }
        public Nullable<int> QUANTITE { get; set; }
        public Nullable<decimal> PRICE { get; set; }
    
        public virtual Commande_Client Commande_Client { get; set; }
        public virtual Produit Produit { get; set; }
    }
}
