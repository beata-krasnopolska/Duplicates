using Duplicates.Interfaces;

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
                var chosenNumber = source[i];

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
    }
}
