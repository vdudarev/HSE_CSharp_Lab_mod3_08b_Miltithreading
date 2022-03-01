namespace Task04_Cyphers
{
    internal abstract class Cypher
    {
        protected abstract string Encrypt(string message);

        protected abstract string Decrypt(string message);
    }
}