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
    
    public partial class Appointment
    {
        public Appointment()
        {
            this.AppointmentsEmployees = new HashSet<AppointmentsEmployee>();
        }
    
        public int AppointmentId { get; set; }
        public System.TimeSpan Appointmenttime { get; set; }
        public System.DateTime Appointmentdate { get; set; }
        public int CustomerId { get; set; }
        public System.Data.Entity.Spatial.DbGeography AppointmentLocation { get; set; }
        public int EntityId { get; set; }
    
        public virtual BusinessEntity BusinessEntity { get; set; }
        public virtual Customers Customer { get; set; }
        public virtual ICollection<AppointmentsEmployee> AppointmentsEmployees { get; set; }
    }
}