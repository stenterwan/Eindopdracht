
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace StoreWebservice
{

    using System;
    using System.Collections.Generic;

    public partial class Product
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {

            this.Orders = new HashSet<Order>();

        }


        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public int Stock { get; set; }



        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

        public virtual ICollection<Order> Orders { get; set; }

        public override string ToString()
        {
            return String.Format("{0}, {1}", this.Name, this.Stock);
        }

    }

}