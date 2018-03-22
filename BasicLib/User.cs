using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace BasicLib
{
    [DataContract]
    public partial class User
    {
        [DataMember]
        private int id;
        [DataMember]
        private string email;
        [DataMember]
        private int characterId;
        [DataMember]
        private string password;
        [DataMember]
        private string phoneNumber;
        [DataMember]
        private System.DateTime lastLogIn;
        [DataMember]
        private string accessLevelType;

        public User(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public int Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public int CharacterId { get => characterId; set => characterId = value; }
        public string Password { get => password; set => password = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public DateTime LastLogIn { get => lastLogIn; set => lastLogIn = value; }
        public string AccessLevelType { get => accessLevelType; set => accessLevelType = value; }
    }
}