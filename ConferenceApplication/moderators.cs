//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConferenceApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class moderators
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public moderators()
        {
            this.activities = new HashSet<activities>();
        }
    
        public int moderator_id { get; set; }
        public string last_name { get; set; }
        public string first_name { get; set; }
        public string patronymic { get; set; }
        public string gender { get; set; }
        public string email_address { get; set; }
        public System.DateTime birthday { get; set; }
        public int country { get; set; }
        public string phone_number { get; set; }
        public string speciality { get; set; }
        public string @event { get; set; }
        public string password { get; set; }
        public string photo_path { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<activities> activities { get; set; }
    }
}
