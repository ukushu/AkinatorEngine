using System.Linq;

namespace AkinatorEngine.FuzzyLogic
{

    /// <summary>
    /// Fuzz Colometric Logic
    /// </summary>
    public static class FuzzColo
    {
        public static float And(params float[] variants)
        {
            Helper.OutOfRangeCheck(variants);

            return variants.Aggregate((p, x) => p *= x);// * each element
        }

        public static float Or(params float[] variants)
        {
            Helper.OutOfRangeCheck(variants);

            var summ = variants.Aggregate((p, x) => p += x);

            var multiplication = variants.Aggregate((p, x) => p *= x);

            return summ - multiplication;
        }

        public static float Xor(params float[] variants)
        {
            return 1 - Or(variants);
        }

        public static float Not(params float[] variants)
        {
            return Fuzz.Not(variants);
        }
    }

}
