using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EngineIO;

namespace HomeIo
{
    public static class ReadIO
    {
        public static bool ReadBitInput(int input)
        {
            MemoryBit HomeInput = MemoryMap.Instance.GetBit(input, MemoryType.Input);
            return HomeInput.Value;
        }

        public static float ReadFloatInput(int input)
        {
            MemoryFloat HomeInput = MemoryMap.Instance.GetFloat(input, MemoryType.Input);
            return HomeInput.Value;
        }

        public static bool ReadBitOutput(int input)
        {
            MemoryBit HomeInput = MemoryMap.Instance.GetBit(input, MemoryType.Output);
            return HomeInput.Value;
        }

        public static float ReadFloatOutput(int input)
        {
            MemoryFloat HomeInput = MemoryMap.Instance.GetFloat(input, MemoryType.Output);
            return HomeInput.Value;
        }

        public static DateTime ReadDateTimeMemory()
        {
            MemoryDateTime dateTime = MemoryMap.Instance.GetDateTime(65, MemoryType.Memory);
            return dateTime.Value;
        }

        public static float ReadFloatMemory(int memory)
        {
            MemoryFloat HomeMemory = MemoryMap.Instance.GetFloat(memory, MemoryType.Memory);
            return HomeMemory.Value;
        }

        public static object ReadInputType(string type, int numero)
        {
            switch (type)
            {
                case "bool":
                    return ReadIO.ReadBitInput(numero);
                case "float":
                    return ReadIO.ReadFloatInput(numero);
                default:
                    return null;
            }
        }

        public static object ReadOutputType(string type, int numero)
        {
            switch (type)
            {
                case "bool":
                    return ReadIO.ReadBitOutput(numero);
                case "float":
                    return ReadIO.ReadFloatOutput(numero);
                default:
                    return null;
            }
        }

        public static void update()
        {
            MemoryMap.Instance.Update();
        }
    }
}
