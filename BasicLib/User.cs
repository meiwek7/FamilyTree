using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Security;

namespace BasicLib
{
    [DataContract]
    public class User
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
        

       
        public User()
        {

        }
        public User(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        public int Id { get { return id; } set { id = value; } }
        public string Email { get { return email; } set { email = value; } }
        public int CharacterId { get { return characterId; } set { characterId = value; } }
        public SecureString MyProperty { get; set; }
        public string Password { get { return password; } set { password = value; } }
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        public DateTime LastLogIn { get { return lastLogIn; } set { lastLogIn = value; } }
        public string AccessLevelType { get { return accessLevelType; } set { accessLevelType = value; } }
       
    }
    }
