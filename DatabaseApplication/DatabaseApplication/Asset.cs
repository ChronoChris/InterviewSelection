//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class Asset
    {
        public int AssetId { get; set; }
        public string AssetModelNo { get; set; }
        public byte[] AssetPic { get; set; }
        public System.Data.Entity.Spatial.DbGeography AssetLocation { get; set; }
        public decimal AssetBookValue { get; set; }
        public short AssetDepYear { get; set; }
        public System.DateTime AssetAcqDate { get; set; }
        public int ProjectId { get; set; }
        public int EntityId { get; set; }
    
        public virtual BusinessEntity BusinessEntity { get; set; }
        public virtual Project Project { get; set; }
    }
}