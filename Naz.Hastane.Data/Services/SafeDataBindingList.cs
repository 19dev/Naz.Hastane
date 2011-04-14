using System.Collections.Generic;
using Castle.DynamicProxy;

namespace Interworks.NHibernateFramework
{
    public class SafeDataBindingList<T> : List<T>
    {
        private IList<T> _innerList;

        private SafeDataBindingList(IList<T> list)
            : base(list.Count)
        {
            _innerList = list;

            ProxyGenerator generator = new ProxyGenerator();

            foreach (T obj in list)
            {
                this.Add((T)generator.CreateClassProxy(typeof(T), new DataObjectInterceptor(obj)));
            }
        }

        public IList<T> InnerList
        {
            get { return _innerList; }
        }

        /// <summary>
        /// Creates a safe-wrapper around a list if needed for 
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static IList<T> Create(IList<T> list)
        {
            if (list.Count <= 1)
                return list;

            string t1 = "";
            string t2 = "";

            t1 = list[0].GetType().ToString();

            bool uniformList = true;
            for (int i = 1; i < list.Count; i++)
            {
                t2 = list[i].GetType().ToString();
                if (t1 == t2)
                    continue;
                else
                {
                    uniformList = false;
                    break;
                }
            }

            if (uniformList)
                return list;

            return new SafeDataBindingList<T>(list);
        }
    }
}
