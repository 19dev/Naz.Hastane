//using System.Collections.Generic;
using Castle.DynamicProxy;
using Iesi.Collections.Generic;

namespace Interworks.NHibernateFramework
{
    public class SafeDataBindingSet<T> : HashedSet<T>
    {
        private ISet<T> _innerSet;

        private SafeDataBindingSet(ISet<T> set)
            : base()
        {
            _innerSet = set;

            ProxyGenerator generator = new ProxyGenerator();

            foreach (T obj in set)
            {
                this.Add((T)generator.CreateClassProxy(typeof(T), new DataObjectInterceptor(obj)));
            }
        }

        public ISet<T> InnerSet
        {
            get { return _innerSet; }
        }

        /// <summary>
        /// Creates a safe-wrapper around a list if needed for 
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static ISet<T> Create(ISet<T> set)
        {
            if (set.Count <= 1)
                return set;

            string t1 = "";
            string t2 = "";

            bool uniformSet = true;
            foreach (T obj in set)
            {
                if (t1 == "")
                {
                    t1 = obj.GetType().ToString();
                    continue;
                }

                t2 = obj.GetType().ToString();

                if (t1 == t2)
                    continue;
                else
                {
                    uniformSet = false;
                    break;
                }
            }

            if (uniformSet)
                return set;

            return new SafeDataBindingSet<T>(set);
        }
    }
}
