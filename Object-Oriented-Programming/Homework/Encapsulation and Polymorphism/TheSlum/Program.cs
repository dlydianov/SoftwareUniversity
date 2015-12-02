using System;
using TheSlum.Caharcters;
using TheSlum.Items;

namespace TheSlum
{
    using GameEngine;

    public class Program : Engine
    {
        public static void Main()
        {
            Engine engine = new Program();
            engine.Run();
        }

        protected override void ExecuteCommand(string[] inputParams)
        {
            base.ExecuteCommand(inputParams);
            switch (inputParams[0])
            {
                case "create":
                    this.CreateCharacter(inputParams);
                    break;
                case "add":
                    this.AddItem(inputParams);
                    break;
            }
        }

        protected override void CreateCharacter(string[] inputParams)
        {
            string typeOfCharacter = inputParams[1];
            string characterId = inputParams[2];
            int X = int.Parse(inputParams[3]);
            int Y = int.Parse(inputParams[4]);
            Team team = (Team) Enum.Parse(typeof (Team), inputParams[5]);

            Character character;
            switch (typeOfCharacter)
            {
                case "healer":
                    character = new Mage(characterId, X, Y, team);
                    break;
                case "mage":
                    character = new Mage(characterId, X, Y, team);
                    break;
                case "warrior":
                    character = new Warrior(characterId, X, Y, team);
                    break;
                default:
                    throw new ArgumentException("Such character doesn't exist");
            }
            characterList.Add(character);
        }

        protected override void AddItem(string[] inputParams)
        {
            string character = inputParams[1];
            string itemClass = inputParams[2];
            string itemId = inputParams[3];

            Item item;
            switch (itemClass)
            {
                case "axe":
                    Item axe = new Axe(itemId);
                    characterList.Find(x => x.Id == character).AddToInventory(axe);
                    break;
                case "injection":
                    Item injection = new Injection(itemId);
                    characterList.Find(x => x.Id == character).AddToInventory(injection);
                    break;
                case "pill":
                    Item pill = new Pill(itemId);
                    characterList.Find(x => x.Id == character).AddToInventory(pill);
                    break;
                case "shield":
                    Item shield = new Shield(itemId);
                    characterList.Find(x => x.Id == character).AddToInventory(shield);
                    break;
                default:
                    throw new ArgumentException("Item missing", "No such an item exist.");
            }
        }
    }
}
