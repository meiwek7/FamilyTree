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
            using (FamilyTreeEntities db = new FamilyTreeEntities())
            {
                var ProcResults = db.SelectSameHouseMembers(incomingUser.CharacterId).ToList();
                BasicLib.House House = new BasicLib.House();
                #region InitializeHouse
                FillHouse(ProcResults, House);
                #region Comments
                //foreach (var item in ProcResults)
                //{
                //    var chr = new BasicLib.Character();
                //    chr.Id = item.id;
                //    chr.FirstName = item.firstName;
                //    chr.SecondName = item.secondName;
                //    chr.LastName = item.lastName;
                //    chr.Nationality = item.nationality;
                //    chr.BirthCountry = item.birthCountry;
                //    chr.DeathCountry = item.deathCountry;
                //    chr.LivingCountry = item.livingCountry;
                //    chr.BirthPlace = item.birthPlace;
                //    chr.DeathPlace = item.deathPlace;
                //    chr.LivingPlace = item.deathPlace;
                //    chr.Religious = item.religious;
                //    if (item.birthDate == null)
                //        chr.BirthDate = DateTime.MinValue;
                //    else
                //        chr.BirthDate = (DateTime)item.birthDate;
                //    if (item.deathDate == null)
                //        chr.DeathDate = DateTime.MinValue;
                //    else
                //        chr.DeathDate = (DateTime)item.deathDate;
                //    chr.Biography = item.biography;
                //    chr.Photo = null;
                //    chr.Successor = null;
                //    House.HouseMembers.Add(chr);
                //}
                #endregion
                #endregion
                return House;
            }
        }

        private bool FillHouse(List<SelectSameHouseMembers_Result> querryResultList, BasicLib.House House)
        {
            foreach (var item in querryResultList)
            {
                var chr = new BasicLib.Character();
                chr.Id = item.id;
                chr.FirstName = item.firstName;
                chr.SecondName = item.secondName;
                chr.LastName = item.lastName;
                chr.Nationality = item.nationality;
                chr.BirthCountry = item.birthCountry;
                chr.DeathCountry = item.deathCountry;
                chr.LivingCountry = item.livingCountry;
                chr.BirthPlace = item.birthPlace;
                chr.DeathPlace = item.deathPlace;
                chr.LivingPlace = item.livingPlace;//OchepyatkaTut!!!
                chr.Religious = item.religious;
                if (item.birthDate == null)
                    chr.BirthDate = DateTime.MinValue;
                else
                    chr.BirthDate = (DateTime)item.birthDate;
                if (item.deathDate == null)
                    chr.DeathDate = DateTime.MinValue;
                else
                    chr.DeathDate = (DateTime)item.deathDate;
                chr.Biography = item.biography;
                chr.Photo = item.photo;
                chr.Successor = null;
                House.HouseMembers.Add(chr);
            }
            return false;
        }

        public void InsertNewCharacter(BasicLib.User curUser, BasicLib.House incHs)
        {
            using (FamilyTreeEntities db = new FamilyTreeEntities())
            {
                //Добавить запись в Таблицу Чаров
                Server.Character newChar = new Server.Character();
                newChar.creator = curUser.Id;
                db.Character.Add(newChar);
                db.SaveChanges();
                //Добавить запись в КроссТаблицу ЧарДом
                Server.HouseCharacter HoCh = new HouseCharacter();
                HoCh.houseId = db.House.Where(x => x.houseKeeper == curUser.CharacterId).ToList().First().id;
                HoCh.characterId = db.Character.Where(x => x.creator == curUser.Id).ToList().Last().id;
                db.HouseCharacter.Add(HoCh);
                db.SaveChanges();
            }
        }

        public List<string> GetAllCountries()
        {
            List<string> Countries = new List<string>();
            using (FamilyTreeEntities db = new FamilyTreeEntities())
            {
                foreach (var item in db.Country.ToList())
                {
                    Countries.Add(item.name);
                }
            }
            return Countries;
        }

        public List<string> GetAllPlaces()
        {
            List<string> Places = new List<string>();
            using (FamilyTreeEntities db = new FamilyTreeEntities())
            {
                foreach (var item in db.Place.ToList())
                {
                    Places.Add(item.name);
                }
            }
            return Places;
        }

        public List<string> GetAllReligious()
        {
            List<string> Religious = new List<string>();
            using (FamilyTreeEntities db = new FamilyTreeEntities())
            {
                foreach (var item in db.Religious.ToList())
                {
                    Religious.Add(item.name);
                }
            }
            return Religious;
        }

        public List<string> GetAllNationality()
        {
            List<string> Nationality = new List<string>();
            using (FamilyTreeEntities db = new FamilyTreeEntities())
            {
                foreach (var item in db.Nationality.ToList())
                {
                    Nationality.Add(item.name);
                }
            }
            return Nationality;
        }

        public void ChangeChar(BasicLib.User incUser, BasicLib.Character incCharacter)
        {
            //Выбрать существующего юзера

            //Изменить

            //Сохранить

            //Вернуть новый контекст
            using (FamilyTreeEntities db = new FamilyTreeEntities())
            {
                var tmp1 = db.ChangeChar(incCharacter.Id,
                    incUser.Id,
                    incCharacter.FirstName,
                    incCharacter.SecondName,
                    incCharacter.LastName,
                    incCharacter.Nationality,
                    incCharacter.BirthCountry,
                    incCharacter.DeathCountry,
                    incCharacter.LivingCountry,
                    incCharacter.BirthPlace,
                    incCharacter.DeathPlace,
                    incCharacter.LivingPlace,
                    incCharacter.Religious,
                    incCharacter.BirthDate,
                    //DateTime.MinValue,
                    incCharacter.DeathDate,
                    //DateTime.MinValue,
                    incCharacter.Biography,
                    incCharacter.Photo
                    );
                //var tmp1 = db.ChangeChar(incCharacter.Id,
                //    incUser.Id,
                //    "Ivanich",
                //    null,
                //    null,
                //    null,
                //    null,
                //    null,
                //    null,
                //    null,
                //    null,
                //    null,
                //    null,
                //    //incCharacter.BirthDate,
                //    null,
                //    //incCharacter.DeathDate,
                //    null,
                //    null,
                //    null
                //    );
                db.SaveChanges();
            }
        }

        public void getLogs()
        {

            throw new NotImplementedException();
        }
    }
}
