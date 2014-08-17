using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace AutofacStartupSetup.Utils.Data
{
    public class ExpressionHelper
    {
        public static Func<T, R> GetFieldAccessor<T, R>(string fieldName)
        {
            ParameterExpression param = Expression.Parameter(typeof(T), "arg");

            MemberExpression member = Expression.Field(param, fieldName);

            LambdaExpression lambda = Expression.Lambda(typeof(Func<T, R>), member, param);

            return (Func<T, R>)lambda.Compile();
        }
    }
}