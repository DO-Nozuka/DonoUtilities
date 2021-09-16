namespace Dono.Utilities
{
    public static class InRangeExtension
    {
        // byte
        public static bool InRange(this byte num, byte max)
        {
            return num.InRange(0, max);
        }
        public static bool InRange(this byte num, byte min, byte max)
        {
            return min <= num && num <= max;
        }

        // sbyte
        public static bool InRange(this sbyte num, sbyte max)
        {
            return num.InRange(0, max);
        }
        public static bool InRange(this sbyte num, sbyte min, sbyte max)
        {
            return min <= num && num <= max;
        }

        // decimal
        public static bool InRange(this decimal num, decimal max)
        {
            return num.InRange(0, max);
        }

        public static bool InRange(this decimal num, decimal min, decimal max)
        {
            return min <= num && num <= max;
        }

        // double
        public static bool InRange(this double num, double max)
        {
            return num.InRange(0, max);
        }
        public static bool InRange(this double num, double min, double max)
        {
            return min <= num && num <= max;
        }

        // float
        public static bool InRange(this float num, float max)
        {
            return num.InRange(0, max);
        }
        public static bool InRange(this float num, float min, float max)
        {
            return min <= num && num <= max;
        }

        // int
        public static bool InRange(this int num, int max)
        {
            return num.InRange(0, max);
        }

        public static bool InRange(this int num, int min, int max)
        {
            return min <= num && num <= max;
        }
        
        // uint
        public static bool InRange(this uint num, uint max)
        {
            return num.InRange(0, max);
        }

        public static bool InRange(this uint num, uint min, uint max)
        {
            return min <= num && num <= max;
        }

#if CSHARP_9_OR_LATER
        // nint
        public static bool InRange(this nint num, nint max)
        {
            return num.InRange(0, max);
        }

        public static bool InRange(this nint num, nint min, nint max)
        {
            return min <= num && num <= max;
        }


        // nuint
        public static bool InRange(this nuint num, nuint max)
        {
            return num.InRange(0, max);
        }

        public static bool InRange(this nuint num, nuint min, nuint max)
        {
            return min <= num && num <= max;
        }
#endif

        // long
        public static bool InRange(this long num, long max)
        {
            return num.InRange(0, max);
        }

        public static bool InRange(this long num, long min, long max)
        {
            return min <= num && num <= max;
        }

        // ulong
        public static bool InRange(this ulong num, ulong max)
        {
            return num.InRange(0, max);
        }

        public static bool InRange(this ulong num, ulong min, ulong max)
        {
            return min <= num && num <= max;
        }

        // short
        public static bool InRange(this short num, short max)
        {
            return num.InRange(0, max);
        }

        public static bool InRange(this short num, short min, short max)
        {
            return min <= num && num <= max;
        }

        // ushort
        public static bool InRange(this ushort num, ushort max)
        {
            return num.InRange(0, max);
        }

        public static bool InRange(this ushort num, ushort min, ushort max)
        {
            return min <= num && num <= max;
        }
    }
}