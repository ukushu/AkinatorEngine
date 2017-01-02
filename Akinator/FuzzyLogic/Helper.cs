using System;

namespace AkinatorEngine.FuzzyLogic
{
    public static class Helper
    {
        /// <summary>
        /// Checking that any of params is less 0 or more than 1.
        /// </summary>
        /// <param name="variants"></param>
        /// <returns>false of thrown OutOfRange error</returns>
        public static bool OutOfRangeCheck(params float[] variants)
        {
            foreach (var v in variants)
            {
                if (v < 0.0 || v > 1.0)
                {
                    throw new IndexOutOfRangeException();
                }
            }

            return false;
        }

        /*
         * Формула Байеса позволяет «переставить причину и следствие»: по известному факту события 
         * вычислить вероятность того, что оно было вызвано данной причиной.
         * События, отражающие действие «причин», в данном случае называют гипотезами, так как они — 
         * предполагаемые события, повлекшие данное. Безусловную вероятность справедливости гипотезы 
         * называют априорной (насколько вероятна причина вообще), а условную — с учетом факта 
         * произошедшего события — апостериорной (насколько вероятна причина оказалась с учетом данных о событии).
         
            Пример
            *EventA — в баке нет бензина
            *EventB — машина не заводится. 
            *pBA - вероятность того, что машина не заведется, если в баке нет бензина, равняется единице. 
            *pA - вероятность того, что в баке нет бензина. Равна произведению вероятности pB того, что машина не заводится, 
            на вероятность pAB того, что причиной EeventB стало именно отсутствие бензина EventA, а не, к примеру, разряженный аккумулятор.
         */

        /// <summary>
        /// Returns possibility of eventA in case of eventB already was
        /// </summary>
        /// <param name="pBA">possibility of eventB in Case of EventA already was</param>
        /// <param name="pA">possibility of eventA in general (not related to B)</param>
        /// <param name="pB">possibility of eventB in general</param>
        /// <returns>pAB - possibility of eventA relatively to eventB</returns>
        public static float Bayes(float pBA, float pA, float pB = 0.5f)
        {
            return (pBA * pA) / pB;
        }
    }

}
