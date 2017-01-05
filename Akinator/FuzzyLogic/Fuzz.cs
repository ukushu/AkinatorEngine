using System.Linq;

namespace AkinatorEngine.FuzzyLogic
{
    /// <summary>
    /// Fuzz Min/Max logic
    /// </summary>
    public static class Fuzz
    {
        /// <summary>
        /// Logic AND returns possibility of all events in the same time
        /// </summary>
        public static float And(params float[] eventsPossibility)
        {
            Helper.OutOfRangeCheck(eventsPossibility);

            var mnoj = eventsPossibility.Aggregate((p, x) => p *= x);

            return mnoj;
        }

        /// <summary>
        /// returns possibility of any of events
        /// </summary>
        public static float Or(params float[] eventsPossibility)
        {
            Helper.OutOfRangeCheck(eventsPossibility);

            var summ = eventsPossibility.Aggregate((p, x) => p += x);

            return summ / eventsPossibility.Length;
        }

        /// <summary>
        /// Returns IMpossibility of any of events
        /// </summary>
        /// <param name="eventsPossibility"></param>
        public static float Not(params float[] eventsPossibility)
        {
            return 1.0f - Or(eventsPossibility);
        }
    }

}
