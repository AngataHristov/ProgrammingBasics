using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WaveBits
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        int startWavePosition = new int();
        int lengthWave = new int();
        int previousWaveBit = 0;

        for (int i = 0; i < 64; i++)
        {
            long currentBit = n >> i & 1;
            if (currentBit == 1)
            {
                int k = i;
                int currentLength = 1;

                while (true)
                {
                    if (previousWaveBit == 0 && (n >> k & 1) == 1)
                    {

                    }
                }
            }
        }
    }
}
