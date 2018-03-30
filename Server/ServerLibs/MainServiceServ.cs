using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BasicLib;

namespace Server.ServerLibs
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "MainServiceServ" в коде и файле конфигурации.
    public class MainServiceServ : IMain
    {
        public BasicLib.House getHouse(BasicLib.User incomingUser)
        {
            incomingUser = new BasicLib.User("lol", "bol");
            incomingUser.CharacterId = 1;
            using (FamilyTreeEntities db = new FamilyTreeEntities())
            {
                var ProcResults = db.SelectSameHouseMembers(incomingUser.CharacterId).ToList();
                BasicLib.House House = new BasicLib.House();
                foreach (var item in ProcResults)
                {
                    House.HouseMembers.Add(new BasicLib.Character()
                    {
                        Id = item.id,
                        FirstName = item.firstName,
                        SecondName = item.secondName,
                        LastName = item.lastName,
                        Nationality = item.nationality,
                        BirthCountry = item.birthCountry,
                        DeathCountry = item.deathCountry,
                        LivingCountry = item.livingCountry,
                        BirthPlace = item.birthPlace,
                        DeathPlace = item.deathPlace,
                        LivingPlace = item.deathPlace,
                        Religious = item.religious,
                        BirthDate = (DateTime)item.birthDate,
                        DeathDate = (DateTime)item.deathDate,
                        Biography = item.biography,
                        Photo = null,
                        Successor = null
                    });
                }
                return House;
            }
        }

        public void getLogs()
        {

            throw new NotImplementedException();
        }
    }
}
