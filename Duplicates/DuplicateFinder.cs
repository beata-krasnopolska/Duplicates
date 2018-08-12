using Duplicates.Interfaces;
using System.Collections.Generic;

namespace Duplicates
{
    class DuplicateFinder : IDuplicateFinder
    {
        public int Find(int[] source)
        {
            var length = source.Length;
            var lowestDuplicateIndex = source.Length;
            var duplicateExist = false;

            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (source[i] == source[j] && j < lowestDuplicateIndex)
                    {
                        lowestDuplicateIndex = j;
                        duplicateExist = true;
                    }
                }
            }

            if (duplicateExist)
                return source[lowestDuplicateIndex];

            return -1;
        }

        public int FindHash(int[] source)
        {
            var hashSet = new HashSet<int>();

            for (int i = 0; i < source.Length; i++)
            {
                if (!hashSet.Contains(source[i]))
                    hashSet.Add(source[i]);
                else
                    return source[i];
            }

            return -1;
        }
    }
}
