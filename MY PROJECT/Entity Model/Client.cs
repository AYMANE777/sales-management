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
    
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            this.Commande_Client = new HashSet<Commande_Client>();
        }
    
        public int id_client { get; set; }
        public string Nom_client { get; set; }
        public string email { get; set; }
        public string telephone { get; set; }
        public string CIN { get; set; }
        public string Adresse { get; set; }
        public string ville { get; set; }
        public byte[] image_client { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Commande_Client> Commande_Client { get; set; }
    }
}
