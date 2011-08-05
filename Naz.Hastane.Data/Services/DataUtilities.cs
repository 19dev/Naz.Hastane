using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Utils.Reflection;
using System.Linq.Expressions;

namespace Naz.Hastane.Data.Services
{
    public static class DataUtilities
    {
        //public static string GetMemberName<TModel, TReturn>(Expression<Func<TModel, TReturn>> expression)
        //{
        //    return ReflectionHelper.GetMember<TModel, TReturn>(expression).Name;
        //}

        public static string GetMemberName<TModel>(Expression<Func<TModel, object>> expression)
        {
            return ReflectionHelper.GetMember(expression).Name;
        }

    }
}
