using DataHelper.Provider.Contract;
using System;

namespace DataHelper.Provider
{
    public class ArrayHelperProvider: IArrayHelperProvider
    {
        public int[] Reverse(int[] items)
        {
            var length = items.Length;
            if (length == 0)
                return items;

            for (var i = 0; i < length / 2; i++) {
                //swap the first and last item
                var temp = items[i];
                items[i] = items[length - i - 1];
                items[length - i - 1] = temp;
            }

            return items;
        }

        public int[] DeletePart(int[] items, int position)
        {
            var length = items.Length;

            if (length == 0 || position <= 0 || position > length)
                return items;

            var index = position - 1;
            for (var i = index; i < length - 1; i++)
            {
                // shift items left, to fill the gap at [index]
                items[i] = items[i + 1];
            }
            
            // finally, let's decrement Array's size by one
            Array.Resize(ref items, length - 1);

            return items;
        }
    }
}
