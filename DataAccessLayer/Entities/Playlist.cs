//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Playlist
    {
        public Playlist()
        {
            this.Accounts = new HashSet<Account>();
            this.Songs = new HashSet<Song>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
    }
}
