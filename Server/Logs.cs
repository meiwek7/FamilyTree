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
    
    public partial class Logs
    {
        public int changeId { get; set; }
        public int userId { get; set; }
    
        public virtual CharacterBiography CharacterBiography { get; set; }
        public virtual CharacterBirthCountry CharacterBirthCountry { get; set; }
        public virtual CharacterBirthDate CharacterBirthDate { get; set; }
        public virtual CharacterBirthPlace CharacterBirthPlace { get; set; }
        public virtual CharacterDeathCountry CharacterDeathCountry { get; set; }
        public virtual CharacterDeathDate CharacterDeathDate { get; set; }
        public virtual CharacterDeathPlace CharacterDeathPlace { get; set; }
        public virtual CharacterFirstName CharacterFirstName { get; set; }
        public virtual CharacterLastName CharacterLastName { get; set; }
        public virtual CharacterLivingCountry CharacterLivingCountry { get; set; }
        public virtual CharacterLivingPlace CharacterLivingPlace { get; set; }
        public virtual CharacterNationality CharacterNationality { get; set; }
        public virtual CharacterPhoto CharacterPhoto { get; set; }
        public virtual CharacterReligious CharacterReligious { get; set; }
        public virtual CharacterSecondName CharacterSecondName { get; set; }
        public virtual User User { get; set; }
    }
}