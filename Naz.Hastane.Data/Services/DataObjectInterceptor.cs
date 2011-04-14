using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

using Castle.DynamicProxy;

namespace Interworks.NHibernateFramework
{
    public class DataObjectInterceptor : IInterceptor
    {
        private static object _syncRoot = new object();
        private static Dictionary<string, MethodInfo> _methodCache = new Dictionary<string, MethodInfo>();
        private object _target = null;

        public DataObjectInterceptor(object target)
        {
            _target = target;
        }

        public virtual void Intercept(IInvocation invocation)
        {
            Intercept(invocation, null);
        }

        public virtual void Intercept(IInvocation invocation, params object[] args)
        {
            // it's possible that the type that the proxy was built on is not the type of
            // the _target object.  If it is, simply invoke MethodInfo, if it's not, we have
            // to find the appropriate MethodInfo on the unknown type.
            if (invocation.Method.ReflectedType.ToString() == invocation.InvocationTarget.GetType().ToString())
            {
                invocation.Method.Invoke(_target, args);
            }
            else
            {
                MethodInfo method = GetMethod(invocation);
                method.Invoke(_target, args);
            }
        }

        private MethodInfo GetMethod(IInvocation invocation)
        {

            Type targetType = _target.GetType();

            string methodKey = GetMethodKey(targetType, invocation.Method.Name);

            if (_methodCache.ContainsKey(methodKey))
                return _methodCache[methodKey];
            else
            {
                MethodInfo methodInfo = null;
                if (invocation.Method.Name.StartsWith("get_") || invocation.Method.Name.StartsWith("set_"))
                    methodInfo = GetPropertyMethod(targetType, invocation);
                else
                {
                    methodInfo = GetMethod(targetType, invocation.Method.Name);
                }

                lock (_syncRoot)
                {
                    if (methodInfo != null && !_methodCache.ContainsKey(methodKey))
                        _methodCache.Add(methodKey, methodInfo);
                }

                return methodInfo;
            }
        }

        private MethodInfo GetMethod(Type targetType, string methodName)
        {
            // search class hierarchy for method
            Type type = targetType;
            do
            {
                // Use DeclaredOnly to see if we can get the method directly from this type
                MethodInfo method = type.GetMethod(methodName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly);

                if (method != null)
                    return method;

                type = type.BaseType;
            } while (type != null);

            return null;
        }

        private MethodInfo GetPropertyMethod(Type targetType, IInvocation invocation)
        {
            string propertyName = invocation.Method.Name.Split('_')[1];
            bool isGet = invocation.Method.Name.StartsWith("get_");

            Type type = targetType;
            PropertyInfo propertyInfo = null;

            do
            {
                propertyInfo = type.GetProperty(propertyName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly);

                if (propertyInfo != null)
                    break;

                type = type.BaseType;

            } while (type != null);

            if (propertyInfo == null)
                return null;

            if (isGet)
                return propertyInfo.GetGetMethod();
            else
                return propertyInfo.GetSetMethod();
        }

        private string GetMethodKey(Type targetType, string methodName)
        {
            return targetType.ToString() + "." + methodName;
        }
    }
}
