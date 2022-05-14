using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsistentHashing
{
    internal class FNVHash
    { public static uint To32BitFnv1aHash(string toHash, bool separateUpperByte = false)
        {
            IEnumerable<byte> bytesToHash;
            if (separateUpperByte)
                bytesToHash = toHash.ToCharArray()
                    .Select(c => new[] { (byte)((c - (byte)c) >> 8), (byte)c })
                    .SelectMany(c => c);
            else
                bytesToHash = toHash.ToCharArray()
                    .Select(Convert.ToByte);
            //this is the actual hash function; very simple
            uint hash = FNVConstants.FnvOffset32;
            foreach (var chunk in bytesToHash)
            {
                hash ^= chunk;
                hash *= FNVConstants.FnvPrime32;
            }
            return hash;
        }
    }
}
