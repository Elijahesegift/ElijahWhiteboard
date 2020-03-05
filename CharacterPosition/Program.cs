using System;

namespace CharacterPosition
{
    public class Program
    {
        // write a method to find the position (not the index)
        // of the first occurence of a character in a string
        // return 0 if the character is not found in the string.
        public static int GetCharacterPosition(string input, char desiredChar)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == desiredChar) return i + 1;
            }
            return 0;
        }



        static void Main(string[] args)
        {
            Console.WriteLine("CharacterPosition.Program.Main()");
            Console.WriteLine(GetCharacterPosition("San Diego Zoo", 'o'));
            Console.WriteLine(GetCharacterPosition("San Diego Zoo", 'l'));
            Console.WriteLine(GetCharacterPosition("San Diego Zoo", 'S'));
            Console.WriteLine(GetCharacterPosition("San Diego Zoo", 'a'));
        }
    }
}
