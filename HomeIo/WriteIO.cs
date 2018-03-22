using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EngineIO;

namespace HomeIo
{
    public static class WriteIO
    {
        public static void BitOutput(int input)
        {
            MemoryBit HomeInput = MemoryMap.Instance.GetBit(input, MemoryType.Output);
            HomeInput.Value = !HomeInput.Value;
            MemoryMap.Instance.Update();
        }

        public static void BitOutput(int input, bool value)
        {
            MemoryBit HomeInput = MemoryMap.Instance.GetBit(input, MemoryType.Output);
            HomeInput.Value = value;
            MemoryMap.Instance.Update();
        }
    }
}
