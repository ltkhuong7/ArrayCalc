using DataHelper.Provider.Contract;
using DataHelper.Service.Contract;
using System;

namespace DataHelper.Service
{
    public class ArrayHelperService: IArrayHelperService
    {
        private IArrayHelperProvider _arrayHelperProvider;

        public ArrayHelperService(IArrayHelperProvider arrayHelperProvider) {
            _arrayHelperProvider = arrayHelperProvider;
        }

        public int[] Reverse(int[] items)
        {
            if (items == null || items.Length == 0)
                throw new ArgumentException("Failed to reverse array, No item found");

            var result = _arrayHelperProvider.Reverse(items);

            return result;
        }

        public int[] DeletePart(int[] items, int position)
        {
            if (items == null || items.Length == 0)
                throw new ArgumentException("Failed to delete item, No item found");

            if (position < 1 || position > items.Length)
                throw new ArgumentException("Failed to delete item, Invalid delete position");

            var result = _arrayHelperProvider.DeletePart(items, position);

            return result;
        }
    }
}
