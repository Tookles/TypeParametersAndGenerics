using System.Xml;

namespace TypeParametersAndGenerics
{
  
    public class CustomStack<T> 
     {
        private T[] items = Array.Empty<T>();

        public T Pop()
        {
            T[] tempArray = new T[items.Length - 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                tempArray[i] = items[i];
            }
            T output = items[^1];
            items = tempArray;
            return output;
        }

        public void Push(T itemToAdd)
        {
            T[] tempArray = new T[items.Length + 1];

            for (int i = 0; i < items.Length; i++)
            {
                tempArray[i] = items[i];
            }
            tempArray[^1] = itemToAdd;
            items = tempArray;
        }
     }
    
}
