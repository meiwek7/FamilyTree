//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Server
{
    using System;
    using System.Collections.Generic;
    
    public partial class CharacterBiography
    {
        public Nullable<int> characterId { get; set; }
        public string biography { get; set; }
        public int changeId { get; set; }
    
        public virtual Character Character { get; set; }
        public virtual Logs Logs { get; set; }
    }
}
