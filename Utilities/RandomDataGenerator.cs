using System;

namespace ApiTestFramework.Utilities
{
    public static class RandomDataGenerator
    {
        private static Random _random = new Random();

        public static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[_random.Next(s.Length)]).ToArray());
        }

        public static int GenerateRandomNumber(int min, int max)
        {
            return _random.Next(min, max + 1);
        }
    }
}