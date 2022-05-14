using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsistentHashing
{
    internal class FNVConstants
    {
        public static readonly uint FnvPrime32 = 16777619;
        public static readonly ulong FnvPrime64 = 1099511628211;
        public static readonly uint FnvOffset32 = 2166136261;
        public static readonly ulong FnvOffset64 = 14695981039346656037;
    }
}
