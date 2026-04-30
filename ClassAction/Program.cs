using System;
using System.Collections.Generic;

namespace ClassAction
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int seed = int.Parse(args[0]);
            Random rng = new Random(seed);

            List<string> names = new List<string>
            {
                "Aldric", "Morgana", "Lyra", "Thorin", "Selene",
                "Kael", "Iris", "Dorian", "Nyx", "Artemis"
            };

            string name = names[rng.Next(names.Count)];

            int strength = rng.Next(10, 101);
            int intelligence = rng.Next(10, 101);
            int dexterity = rng.Next(10, 101);

            int health = rng.Next(80, 151);
            int damage = rng.Next(10, 31);

            int classType = rng.Next(1, 5);

            Character character;

            switch (classType)
            {
                case 1:
                    character = new Marauder(name, health, damage, strength);
                    break;

                case 2:
                    character = new Witch(name, health, damage, intelligence);
                    break;

                case 3:
                    character = new Huntress(name, health, damage, dexterity);
                    break;

                case 4:
                    character = new Templar(name, health, damage, strength, intelligence);
                    break;

                default:
                    return;
            }

            character.Describe();
            character.Attack();
        }
    }
}
