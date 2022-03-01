using System.Text;

namespace Task04_Cyphers
{
    internal class Rot1 : Cypher
    {
        protected override string Encrypt(string message)
        {
            var encryptedMessage = new StringBuilder();

            foreach (char symbol in message)
            {
                encryptedMessage.Append(ShiftSymbol(symbol, false));
            }

            return encryptedMessage.ToString();
        }

        protected override string Decrypt(string message)
        {
            var decryptedMessage = new StringBuilder();

            foreach (char symbol in message)
            {
                decryptedMessage.Append(ShiftSymbol(symbol, true));
            }

            return decryptedMessage.ToString();
        }

        private static char ShiftSymbol(char symbol, bool toLeft)
        {
            if (char.IsLetter(symbol))
            {
                return toLeft switch
                {
                    true => symbol switch
                    {
                        'Z' => 'A',
                        'z' => 'a',
                        _ => (char) (symbol + 1)
                    },
                    false => symbol switch
                    {
                        'A' => 'Z',
                        'a' => 'z',
                        _ => (char) (symbol - 1)
                    }
                };
            }

            return symbol;
        }
    }
}