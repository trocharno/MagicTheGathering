//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MagicTheGathering_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kaart
    {
        public int ID { get; set; }
        public string Naam { get; set; }
        public Nullable<int> TypeID { get; set; }
        public string KaartTekst { get; set; }
        public string FlavorText { get; set; }
        public string Wartermark { get; set; }
        public int ExpansionID { get; set; }
        public int RarityID { get; set; }
        public int KaartNummer { get; set; }
        public Nullable<int> ArtistID { get; set; }
        public int ColorID { get; set; }
        public Nullable<int> DeckID { get; set; }
    
        public virtual Artist Artist { get; set; }
        public virtual Color Color { get; set; }
        public virtual Deck Deck { get; set; }
        public virtual Expansion Expansion { get; set; }
        public virtual Rarity Rarity { get; set; }
        public virtual Type Type { get; set; }
    }
}