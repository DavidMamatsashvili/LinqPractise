using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LinqPractise.Extensions
{
    public static class LinqMethods{
        //where
        public static IEnumerable<T> EduWhere<T>(this IEnumerable<T> source, Func<T,bool>predicate){
            foreach(var element in source){
                if(predicate(element)) yield return element;
            }
        }

        //select
        public static IEnumerable<TResult> EduSelect<T,TResult>(this IEnumerable<T> source, Func<T,TResult>predicate){
            foreach(var element in source){
                yield return predicate(element);
            }
        }
    }
}
