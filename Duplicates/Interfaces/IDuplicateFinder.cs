namespace Duplicates.Interfaces
{
    interface IDuplicateFinder
    {
        int Find(int[] source);

        int FindHash(int[] source);
    }
}
