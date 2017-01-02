using System.Linq;

namespace AkinatorEngine.FuzzyLogic
{
    /// <summary>
    /// Fuzz Min/Max logic
    /// </summary>
    public static class Fuzz
    {
        public static float And(params float[] variants)
        {
            Helper.OutOfRangeCheck(variants);

            return variants.Min();
        }

        public static float Or(params float[] variants)
        {
            Helper.OutOfRangeCheck(variants);

            return variants.Max();
        }

        public static float Xor(params float[] variants)
        {
            return 1 - Or(variants);
        }

        public static float Not(params float[] variants)
        {
            Helper.OutOfRangeCheck(variants);

            var summ = variants.Aggregate((p, x) => p += x);

            return 1.0f - summ;
        }
    }

}
