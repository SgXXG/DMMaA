using System;

namespace Lab4
{
    public class Function
    {
        public Function(int size)
        {
            Elements = new int[size];
            for (int i = 0; i < size; i++)
            {
                Elements[i] = 0;
            }
        }

        public int[] Elements { get; set; }

        public int GetValue(Vector vector)
        {
            if(vector.Elements.Length != Elements.Length) throw new Exception();
            int result = 0;
            for (int i = 0; i < vector.Elements.Length; i++)
            {
                result += vector.Elements[i] * Elements[i];
            }
            return result;
        }

        public static Function operator +(Function function, Vector vector)
        {
            if(function.Elements.Length != vector.Elements.Length) throw new Exception();
            var result = new Function(function.Elements.Length);
            for (int i = 0; i < function.Elements.Length; i++)
            {
                result.Elements[i] = function.Elements[i] + vector.Elements[i];
            }
            return result;
        }
    }
}
