using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;


namespace BasicLib
{
    [DataContract]
    public class Character
    {
        public Character()
        {

        }
        public Character(Character chr)
        {
            this.id                 = chr.Id                    ;
            this.nationality        = chr.Nationality           ;
            this.birthCountry       = chr.BirthCountry          ;
            this.deathCountry       = chr.DeathCountry          ;
            this.livingCountry      = chr.LivingCountry         ;
            this.birthPlace         = chr.BirthPlace            ;
            this.deathPlace         = chr.DeathPlace            ;
            this.livingPlace        = chr.LivingPlace           ;
            this.religious          = chr.Religious             ;
            this.firstName          = chr.FirstName             ;
            this.secondName         = chr.SecondName            ;
            this.lastName           = chr.LastName              ;
            this.birthDate          = chr.BirthDate             ;
            this.deathDate          = chr.DeathDate             ;
            this.biography          = chr.Biography             ;
            this.photo              = chr.Photo                 ;
        }
        [DataMember]
        private int id;
        [DataMember]
        private string nationality;
        [DataMember]
        private string birthCountry;
        [DataMember]
        private string deathCountry;
        [DataMember]
        private string livingCountry;
        [DataMember]
        private string birthPlace;
        [DataMember]
        private string deathPlace;
        [DataMember]
        private string livingPlace;
        [DataMember]
        private string religious;
        [DataMember]
        private string firstName;
        [DataMember]
        private string secondName;
        [DataMember]
        private string lastName;
        [DataMember]
        private System.DateTime birthDate;
        [DataMember]
        private System.DateTime deathDate;
        [DataMember]
        private string biography;
        [DataMember]
        private string photo;
        [DataMember]
        private List<Character> successor;
        private int left;
        private int top;

        public int Id { get { return id; } set { id = value; } }
        public string Nationality { get { return nationality; } set { nationality = value; } }
        public string BirthCountry { get { return birthCountry; } set { birthCountry = value; } }
        public string DeathCountry { get { return deathCountry; } set { deathCountry = value; } }
        public string LivingCountry { get { return livingCountry; } set { livingCountry = value; } }
        public string BirthPlace { get { return birthPlace; } set { birthPlace = value; } }
        public string DeathPlace { get { return deathPlace; } set { deathPlace = value; } }
        public string LivingPlace { get { return livingPlace; } set { livingPlace = value; } }
        public string Religious { get { return religious ; } set { religious = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string SecondName { get { return secondName; } set { secondName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public DateTime BirthDate { get { return birthDate; } set { birthDate = value; } }
        public DateTime DeathDate { get
            {
                return deathDate;
            } set { deathDate = value; } }
        public string Biography { get { return biography; } set { biography = value; } }
        public string Photo { get { return photo; } set { photo = value; } }
        public List<Character> Successor { get { return successor; } set { successor = value; } }
        public int Top { get { return top; } set { top = value;} }
        public int Left { get { return left; } set { left = value; } }
    }
}