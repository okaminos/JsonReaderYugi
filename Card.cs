﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace JsonReaderYugi
{   
    [Serializable]
    public class Card
    {
        public String name;
        public String type;
        public String desc;
        public int def;
        public int atk;
        public int level;
        public String race;
        public String attribute;
        public String smallCardUrl;
        public String cardUrl;
        public String id;
        public Card()
        {

        }
        public Card(string iDF, string nameF, string typeF, string descF, int defF, int atkF, int levelF, string raceF, string attributeF, string cardUrl, string smallCardUrl)
        {
            this.Name = nameF;
            this.Type = typeF;
            this.Desc = descF;
            this.Def = defF;
            this.Atk = atkF;
            this.Level = levelF;
            this.Race = raceF;
            this.Attribute = attributeF;
            this.CardUrl = cardUrl;
            this.SmallCardUrl = smallCardUrl;
            this.Id = iDF;
        }

        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string Desc { get => desc; set => desc = value; }
        public int Def { get => def; set => def = value; }
        public int Atk { get => atk; set => atk = value; }
        public int Level { get => level; set => level = value; }
        public string Race { get => race; set => race = value; }
        public string Attribute { get => attribute; set => attribute = value; }
        public string SmallCardUrl { get => smallCardUrl; set => smallCardUrl = value; }
        public string CardUrl { get => cardUrl; set => cardUrl = value; }
        public string Id { get => id; set => id = value; }

        public void ToString()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("Card: " + name);
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Type: " + type);
            Console.WriteLine("Description: " + desc);
            Console.WriteLine("Atack: " + atk);
            Console.WriteLine("Defense: " + def);
            Console.WriteLine("Attribute: " + attribute);
            Console.WriteLine("Path Card Url: " + cardUrl);
            Console.WriteLine("Path Small Card Url: " + smallCardUrl);
            Console.WriteLine("***********************************\n\n");

        }
        public override bool Equals(object obj)
        {
            return obj is Card card &&
                   Name == card.Name &&
                   Type == card.Type &&
                   Desc == card.Desc &&
                   Def == card.Def &&
                   Atk == card.Atk &&
                   Level == card.Level &&
                   Race == card.Race &&
                   Attribute == card.Attribute &&
                   SmallCardUrl == card.SmallCardUrl &&
                   CardUrl == card.CardUrl;
        }


    }


}
