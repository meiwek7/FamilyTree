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
    
    public partial class HouseCharacter
    {
        public int id { get; set; }
        public int houseId { get; set; }
        public int characterId { get; set; }
    
        public virtual Character Character { get; set; }
        public virtual House House { get; set; }
    }
}
