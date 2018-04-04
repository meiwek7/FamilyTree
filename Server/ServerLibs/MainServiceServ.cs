﻿using System;
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
                chr.LivingPlace = item.deathPlace;
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
                chr.Photo = null;
                chr.Successor = null;
                House.HouseMembers.Add(chr);
            }
            return false;
        }

        public void InsertNewCharacter()
        {
            using (FamilyTreeEntities db = new FamilyTreeEntities())
            {
                //Добавить запись в Таблицу Чаров
                //db.Character;
                //Добавить запись в КроссТаблицу ЧарДом

                //Вернуть новый дом в контекст
            }
        }

        public void ChangeUser(BasicLib.House House)
        {
            //Выбрать существующего юзера

            //Изменить
            
            //Сохранить

            //Вернуть новый контекст
        }

        public void getLogs()
        {

            throw new NotImplementedException();
        }
    }
}
