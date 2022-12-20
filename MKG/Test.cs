using System;
using System.Collections.Generic;

namespace MKG
{
    class Test
    {
        public List<Question> questions = new List<Question>();
        public string thema;
    }
    class Question
    {
        public string text;
        public List<Variant> variants = new List<Variant>();
    }
    class Variant
    {
        public Variant(string text, bool isTrue)
        {
            this.text = text;
            this.isTrue = isTrue;
        }

        public string text;
        public bool isTrue;
    }
    public static class ExtShuffle
    {
        private static Random rng = new Random();
        public static void Shuffle<T>(this IList<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    } 
}
