//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Musem.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Curator_Exhibition
    {
        public int Id_CuratorExhibition { get; set; }
        public Nullable<int> Id_Curator { get; set; }
        public Nullable<int> Id_Exhibition { get; set; }
    
        public virtual Curator Curator { get; set; }
        public virtual Exhibitions Exhibitions { get; set; }
    }
}
