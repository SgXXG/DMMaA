using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Persiptron
    {
        private readonly int classCount;

        private readonly int vectorsSize;

        public bool Warning { get; set; }

        public Persiptron(int classCount, int vectorsSize)
        {
            this.classCount = classCount;
            this.vectorsSize = vectorsSize;
        }

        public Function[] GetSepareteFunctions(Vector[][] teachingVectors)
        {
            var result = EmptyFunctions();
            Warning = false;
            bool nextIteration = true;
            int iterationNumber = 0;
            while (nextIteration && iterationNumber < 1000)
            {
                iterationNumber++;
                nextIteration = DoOneIteration(teachingVectors, result);
            }
            if (iterationNumber == 1000) Warning = true;
            return result;

        }

        private Function[] EmptyFunctions()
        {
            var result = new Function[classCount];
            for (int i = 0; i < classCount; i++)
            {
                result[i] = new Function(vectorsSize);
            }
            return result;
        }

        private bool DoOneIteration(Vector[][] teachingVectors, Function[] result)
        {
            bool nextIteration = false;
            if (teachingVectors.Length != classCount) throw new Exception();
            for (int classNumber = 0; classNumber < classCount; classNumber++)
            {
                for (int i = 0; i < teachingVectors[classNumber].Length; i++)
                {
                    if (WorkWithVector(teachingVectors[classNumber][i], result, classNumber))
                    {
                        nextIteration =true;
                    }
                }
            }
            return nextIteration;
        }

        private bool WorkWithVector(Vector currentVector, Function[] result, int vectorsClass)
        {
            var maxClass = GetMaxVectorClass(result, currentVector);
            if (maxClass != vectorsClass)
            {
                Panish(currentVector, result, vectorsClass);
                return true;
            }
            return false;
        }

        private void Panish(Vector currentVector, Function[] result, int vectorsClass)
        {
            for (int i = 0; i < classCount; i++)
            {
                if (i == vectorsClass)
                {
                    result[i] += currentVector;
                }
                else
                {
                    result[i] += -1*currentVector;
                }
            }
        }

        public int GetMaxVectorClass(Function[] result, Vector currentVector)
        {
            int max = result[0].GetValue(currentVector);
            int maxClass = 0;
            int maxCount = 1;
            for (int j = 1; j < classCount; j++)
            {
                int currentValue = result[j].GetValue(currentVector);
                if (currentValue > max)
                {
                    maxCount = 0;
                    max = currentValue;
                    maxClass = j;
                }
                if (currentValue == max)
                {
                    maxCount++;
                }
            }
            return maxCount == 1 ?  maxClass : -1;
        }
    }
}
