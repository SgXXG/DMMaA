namespace Lab4
{
    public class Vector
    {
        public Vector(int size)
        {
            Elements = new int[size];
        }

        public int[] Elements { get; private set; }

        public static Vector operator *(int integer, Vector vector)
        {
            var result = new Vector(vector.Elements.Length);
            for (int i = 0; i < vector.Elements.Length; i++)
            {
                result.Elements[i] =  vector.Elements[i] *integer;
            }
            return result;
        }
    }
}