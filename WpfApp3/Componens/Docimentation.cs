//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp3.Componens
{
    using System;
    using System.Collections.Generic;
    
    public partial class Docimentation
    {
        public int Id { get; set; }
        public Nullable<int> VisitorId { get; set; }
        public byte[] Photo { get; set; }
    
        public virtual Visitor Visitor { get; set; }
    }
}
