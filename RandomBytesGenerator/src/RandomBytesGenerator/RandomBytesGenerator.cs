using System;

namespace Savage
{
    public static class RandomBytesGenerator
    {
        public static byte[] Generate(int arraySize)
        {
            if (arraySize < 1)
                throw new ArgumentException("Array size cannot be less than 1");

            System.Security.Cryptography.RandomNumberGenerator rng = System.Security.Cryptography.RandomNumberGenerator.Create();
            var array = new byte[arraySize];
            rng.GetBytes(array);

            return array;
        }

        public static string GenerateAsBase64(int arraySize)
        {
            return Convert.ToBase64String(Generate(arraySize));
        }
    }
}
