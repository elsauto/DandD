using System;
using CharacterLibrary;

namespace CharacterCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            var character = new Character("Demogorgon");
            character.GenerateCharacter();
            Console.Write(character.ToString());
        }
    }
}
