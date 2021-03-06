﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class FamilyTreeEntities : DbContext
    {
        public FamilyTreeEntities()
            : base("name=FamilyTreeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AccessLevel> AccessLevel { get; set; }
        public virtual DbSet<Character> Character { get; set; }
        public virtual DbSet<CharacterBiography> CharacterBiography { get; set; }
        public virtual DbSet<CharacterBirthCountry> CharacterBirthCountry { get; set; }
        public virtual DbSet<CharacterBirthDate> CharacterBirthDate { get; set; }
        public virtual DbSet<CharacterBirthPlace> CharacterBirthPlace { get; set; }
        public virtual DbSet<CharacterDeathCountry> CharacterDeathCountry { get; set; }
        public virtual DbSet<CharacterDeathDate> CharacterDeathDate { get; set; }
        public virtual DbSet<CharacterDeathPlace> CharacterDeathPlace { get; set; }
        public virtual DbSet<CharacterFirstName> CharacterFirstName { get; set; }
        public virtual DbSet<CharacterLastName> CharacterLastName { get; set; }
        public virtual DbSet<CharacterLivingCountry> CharacterLivingCountry { get; set; }
        public virtual DbSet<CharacterLivingPlace> CharacterLivingPlace { get; set; }
        public virtual DbSet<CharacterNationality> CharacterNationality { get; set; }
        public virtual DbSet<CharacterPhoto> CharacterPhoto { get; set; }
        public virtual DbSet<CharacterReligious> CharacterReligious { get; set; }
        public virtual DbSet<CharacterSecondName> CharacterSecondName { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<House> House { get; set; }
        public virtual DbSet<HouseCharacter> HouseCharacter { get; set; }
        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<Nationality> Nationality { get; set; }
        public virtual DbSet<Place> Place { get; set; }
        public virtual DbSet<RelativeCharacter> RelativeCharacter { get; set; }
        public virtual DbSet<RelativeType> RelativeType { get; set; }
        public virtual DbSet<Religious> Religious { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<CharacterFullInfo> CharacterFullInfo { get; set; }
    
        public virtual int ChangeChar(Nullable<int> characterId, Nullable<int> userId, string firstName, string secondName, string lastName, string nationality, string birthCountry, string deathCountry, string livingCountry, string birthPlace, string deathPlace, string livingPlace, string religious, Nullable<System.DateTime> birthDate, Nullable<System.DateTime> deathDate, string biography, string photo)
        {
            var characterIdParameter = characterId.HasValue ?
                new ObjectParameter("CharacterId", characterId) :
                new ObjectParameter("CharacterId", typeof(int));
    
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("firstName", firstName) :
                new ObjectParameter("firstName", typeof(string));
    
            var secondNameParameter = secondName != null ?
                new ObjectParameter("secondName", secondName) :
                new ObjectParameter("secondName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("lastName", lastName) :
                new ObjectParameter("lastName", typeof(string));
    
            var nationalityParameter = nationality != null ?
                new ObjectParameter("nationality", nationality) :
                new ObjectParameter("nationality", typeof(string));
    
            var birthCountryParameter = birthCountry != null ?
                new ObjectParameter("birthCountry", birthCountry) :
                new ObjectParameter("birthCountry", typeof(string));
    
            var deathCountryParameter = deathCountry != null ?
                new ObjectParameter("deathCountry", deathCountry) :
                new ObjectParameter("deathCountry", typeof(string));
    
            var livingCountryParameter = livingCountry != null ?
                new ObjectParameter("livingCountry", livingCountry) :
                new ObjectParameter("livingCountry", typeof(string));
    
            var birthPlaceParameter = birthPlace != null ?
                new ObjectParameter("birthPlace", birthPlace) :
                new ObjectParameter("birthPlace", typeof(string));
    
            var deathPlaceParameter = deathPlace != null ?
                new ObjectParameter("deathPlace", deathPlace) :
                new ObjectParameter("deathPlace", typeof(string));
    
            var livingPlaceParameter = livingPlace != null ?
                new ObjectParameter("livingPlace", livingPlace) :
                new ObjectParameter("livingPlace", typeof(string));
    
            var religiousParameter = religious != null ?
                new ObjectParameter("religious", religious) :
                new ObjectParameter("religious", typeof(string));
    
            var birthDateParameter = birthDate.HasValue ?
                new ObjectParameter("birthDate", birthDate) :
                new ObjectParameter("birthDate", typeof(System.DateTime));
    
            var deathDateParameter = deathDate.HasValue ?
                new ObjectParameter("deathDate", deathDate) :
                new ObjectParameter("deathDate", typeof(System.DateTime));
    
            var biographyParameter = biography != null ?
                new ObjectParameter("biography", biography) :
                new ObjectParameter("biography", typeof(string));
    
            var photoParameter = photo != null ?
                new ObjectParameter("photo", photo) :
                new ObjectParameter("photo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ChangeChar", characterIdParameter, userIdParameter, firstNameParameter, secondNameParameter, lastNameParameter, nationalityParameter, birthCountryParameter, deathCountryParameter, livingCountryParameter, birthPlaceParameter, deathPlaceParameter, livingPlaceParameter, religiousParameter, birthDateParameter, deathDateParameter, biographyParameter, photoParameter);
        }
    
        public virtual ObjectResult<GetCharRelatives_Result> GetCharRelatives(Nullable<int> incomingCharacterID)
        {
            var incomingCharacterIDParameter = incomingCharacterID.HasValue ?
                new ObjectParameter("incomingCharacterID", incomingCharacterID) :
                new ObjectParameter("incomingCharacterID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCharRelatives_Result>("GetCharRelatives", incomingCharacterIDParameter);
        }
    
        public virtual int InsertNewChar(Nullable<int> userId, string firstName, string secondName, string lastName, string nationality, string birthCountry, string deathCountry, string livingCountry, string birthPlace, string deathPlace, string livingPlace, string religious, Nullable<System.DateTime> birthDate, Nullable<System.DateTime> deathDate, string biography, string photo)
        {
            var userIdParameter = userId.HasValue ?
                new ObjectParameter("UserId", userId) :
                new ObjectParameter("UserId", typeof(int));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("firstName", firstName) :
                new ObjectParameter("firstName", typeof(string));
    
            var secondNameParameter = secondName != null ?
                new ObjectParameter("secondName", secondName) :
                new ObjectParameter("secondName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("lastName", lastName) :
                new ObjectParameter("lastName", typeof(string));
    
            var nationalityParameter = nationality != null ?
                new ObjectParameter("nationality", nationality) :
                new ObjectParameter("nationality", typeof(string));
    
            var birthCountryParameter = birthCountry != null ?
                new ObjectParameter("birthCountry", birthCountry) :
                new ObjectParameter("birthCountry", typeof(string));
    
            var deathCountryParameter = deathCountry != null ?
                new ObjectParameter("deathCountry", deathCountry) :
                new ObjectParameter("deathCountry", typeof(string));
    
            var livingCountryParameter = livingCountry != null ?
                new ObjectParameter("livingCountry", livingCountry) :
                new ObjectParameter("livingCountry", typeof(string));
    
            var birthPlaceParameter = birthPlace != null ?
                new ObjectParameter("birthPlace", birthPlace) :
                new ObjectParameter("birthPlace", typeof(string));
    
            var deathPlaceParameter = deathPlace != null ?
                new ObjectParameter("deathPlace", deathPlace) :
                new ObjectParameter("deathPlace", typeof(string));
    
            var livingPlaceParameter = livingPlace != null ?
                new ObjectParameter("livingPlace", livingPlace) :
                new ObjectParameter("livingPlace", typeof(string));
    
            var religiousParameter = religious != null ?
                new ObjectParameter("religious", religious) :
                new ObjectParameter("religious", typeof(string));
    
            var birthDateParameter = birthDate.HasValue ?
                new ObjectParameter("birthDate", birthDate) :
                new ObjectParameter("birthDate", typeof(System.DateTime));
    
            var deathDateParameter = deathDate.HasValue ?
                new ObjectParameter("deathDate", deathDate) :
                new ObjectParameter("deathDate", typeof(System.DateTime));
    
            var biographyParameter = biography != null ?
                new ObjectParameter("biography", biography) :
                new ObjectParameter("biography", typeof(string));
    
            var photoParameter = photo != null ?
                new ObjectParameter("photo", photo) :
                new ObjectParameter("photo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertNewChar", userIdParameter, firstNameParameter, secondNameParameter, lastNameParameter, nationalityParameter, birthCountryParameter, deathCountryParameter, livingCountryParameter, birthPlaceParameter, deathPlaceParameter, livingPlaceParameter, religiousParameter, birthDateParameter, deathDateParameter, biographyParameter, photoParameter);
        }
    
        public virtual ObjectResult<SelectSameHouseMembers_Result> SelectSameHouseMembers(Nullable<int> characterid)
        {
            var characteridParameter = characterid.HasValue ?
                new ObjectParameter("Characterid", characterid) :
                new ObjectParameter("Characterid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectSameHouseMembers_Result>("SelectSameHouseMembers", characteridParameter);
        }
    }
}
