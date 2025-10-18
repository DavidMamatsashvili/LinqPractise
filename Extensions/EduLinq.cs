using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LinqPractise.Extensions
{
    public static class LinqMethods{
        public static IEnumerable<T> EduWhere<T>(this IEnumerable<T> args, Func<T,bool>predicate){
            foreach(var element in args){
                if(predicate(element)) yield return element;
            }
        }
    }
}
