//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract(IsReference = true)]
    public partial class Informations
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public virtual Tags tag_id { get; set; }
        [DataMember]
        public virtual Picture picture_id { get; set; }
    }
}
