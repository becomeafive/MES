using System;
using System.Collections.Generic;
using System.Text;

namespace VOL.Core.Extensions
{
    public static class Class1
    {
        public static IEnumerable<TSource> Distinct<TSource, TKey>(
        this IEnumerable<TSource> source,
        Func<TSource, TKey> keySelector)
        {
            var hashSet = new HashSet<TKey>();

            foreach (TSource element in source)
            {
                if (hashSet.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }
    }
}
