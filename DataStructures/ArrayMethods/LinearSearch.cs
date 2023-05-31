namespace DataStructures.ArrayMethods
{
    public class ArrayMethods
    {
        public static bool LinearSearch(int[] array, int key)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == key)
                {
                    return true;
                }
            }

            return false;

        }

    }
}
