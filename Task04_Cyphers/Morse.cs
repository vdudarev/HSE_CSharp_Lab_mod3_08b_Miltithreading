using System;
using System.Collections.Generic;
using System.Text;

namespace Task04_Cyphers
{
    internal class Morse : Cypher
    {
        private static readonly Dictionary<char, string> SymbolToCypherMapping = new()
        {
            {'a', ".-"}, {'b', "-..."}, {'c', "-.-."}, {'d', "-.."},
            {'e', "."}, {'f', "..-."}, {'g', "--."}, {'h', "...."},
            {'i', ".."}, {'j', ".---"}, {'k', "-.-"}, {'l', ".-.."},
            {'m', "--"}, {'n', "-."}, {'o', "---"}, {'p', ".--."},
            {'q', "--.-"}, {'r', ".-."}, {'s', "..."}, {'t', "-"},
            {'u', "..-"}, {'v', "...-"}, {'w', ".--"}, {'x', "-..-"},
            {'y', "-.--"}, {'z', "--.."}, {'.', ".-.-.-"}, {',', "--..--"}
        };

        private static readonly Dictionary<string, char> CypherToSymbolMapping = new()
        {
            {".-", 'a'}, {"-...", 'b'}, {"-.-.", 'c'}, {"-..", 'd'},
            {".", 'e'}, {"..-.", 'f'}, {"--.", 'g'}, {"....", 'h'},
            {"..", 'i'}, {".---", 'j'}, {"-.-", 'k'}, {".-..", 'l'},
            {"--", 'm'}, {"-.", 'n'}, {"---", 'o'}, {".--.", 'p'},
            {"--.-", 'q'}, {".-.", 'r'}, {"...", 's'}, {"-", 't'},
            {"..-", 'u'}, {"...-", 'v'}, {".--", 'w'}, {"-..-", 'x'},
            {"-.--", 'y'}, {"--..", 'z'}, {".-.-.-", '.'}, {"--..--", ','}
        };

        protected override string Encrypt(string message)
        {
            var encryptedMessage = new StringBuilder();

            foreach (char symbol in message)
            {
                if (symbol != ' ')
                {
                    encryptedMessage.Append(SymbolToCypherMapping[char.ToLower(symbol)]);
                }
                else
                {
                    encryptedMessage.Append(' ');
                }

                encryptedMessage.Append(' ');
            }

            return encryptedMessage.ToString().TrimEnd();
        }

        protected override string Decrypt(string message)
        {
            var decryptedMessage = new StringBuilder();

            string[] encryptedWords = message.Split("  ");
            
            foreach (string encryptedWord in encryptedWords)
            {
                string[] encryptedSymbols = encryptedWord.Trim().Split();
                foreach (string encryptedSymbol in encryptedSymbols)
                {
                    decryptedMessage.Append(CypherToSymbolMapping[encryptedSymbol]);
                }

                decryptedMessage.Append(' ');
            }

            return decryptedMessage.ToString();
        }
    }
}