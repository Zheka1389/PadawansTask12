using System;

namespace PadawansTask12
{
    public static class StringExtension
    {
        public static bool AllCharactersAreUnique(string source)
        {
            if (source == null)
                throw new ArgumentNullException();
            if (source == "")
                throw new ArgumentException();
            if (source.Length > 128)
                return false;

            bool[] char_set = new bool[128];
            for (int i = 0; i < source.Length; i++)
            {
                for (int y = i + 1; y < source.Length; y++)
                {
                    if (source[i] == source[y])
                        return false;
                }

            }
            return true;
        }
    }
}