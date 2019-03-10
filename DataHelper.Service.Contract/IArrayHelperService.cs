using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHelper.Service.Contract
{
    public interface IArrayHelperService
    {
        int[] Reverse(int[] items);
        int[] DeletePart(int[] items, int position);
    }
}
