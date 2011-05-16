using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using FluentNHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Naz.Hastane.Data.Entities;
using System.Reflection;
using Naz.Hastane.Data.Services;
using Naz.Hastane.Data.Entities.StoredProcedure;

namespace Naz.Hastane.Data
{
    /// <summary>
    /// Handles creation and management of sessions and transactions.  It is a singleton because 
    /// building the initial session factory is very expensive. Inspiration for this class came 
    /// from Chapter 8 of Hibernate in Action by Bauer and King.  Although it is a sealed singleton
    /// you can use TypeMock (http://www.typemock.com) for more flexible testing.
    /// </summary>
    public sealed class NHibernateSessionManager
    {
        private const string DefaultConfigFile = "DefaultAppWeb.Config";
        private static readonly object _syncRoot = new object();

        private ISessionFactory theSessionFactory;
        #region Thread-safe, lazy Singleton

        /// <summary>
        /// This is a thread-safe, lazy singleton.  See http://www.yoda.arachsys.com/csharp/singleton.html
        /// for more details about its implementation.
        /// </summary>
        public static NHibernateSessionManager Instance
        {
            get
            {
                return Nested.NHibernateSessionManager;
            }
        }

        /// <summary>
        /// Private constructor to enforce singleton
        /// </summary>
        private NHibernateSessionManager() { }

        /// <summary>
        /// Assists with ensuring thread-safe, lazy singleton
        /// </summary>
        private class Nested
        {
            static Nested() { }
            internal static readonly NHibernateSessionManager NHibernateSessionManager =
                new NHibernateSessionManager();
        }

        #endregion

        /// <summary>
        /// This method attempts to find a session factory stored in <see cref="sessionFactories" />
        /// via its name; if it can't be found it creates a new one and adds it the hashtable.
        /// </summary>
        /// <param name="sessionFactoryConfigPath">Path location of the factory config</param>

        public ISessionFactory GetSessionFactory()
        {
            if (theSessionFactory == null)
                theSessionFactory = CreateSessionFactory();
            return theSessionFactory;
        }

        //private ISessionFactory GetSessionFactoryFor(string sessionFactoryConfigPath)
        //{
        //    //Check.Require(!string.IsNullOrEmpty(sessionFactoryConfigPath),
        //    //    "sessionFactoryConfigPath may not be null nor empty");

        //    //  Attempt to retrieve a stored SessionFactory from the hashtable.
        //    if (theSessionFactory == null)
        //        theSessionFactory = CreateSessionFactory();
        //    //ISessionFactory sessionFactory = CreateSessionFactory();// = (ISessionFactory)sessionFactories[sessionFactoryConfigPath];

        //    #region later
        //    //  try and get a session factory if we don't find one create it
        //    //lock (_syncRoot)
        //    //{
        //    //    if (!sessionFactories.TryGetValue(sessionFactoryConfigPath, out sessionFactory))
        //    //    {
        //    //        Configuration cfg = new Configuration();
        //    //        if (sessionFactoryConfigPath != DefaultConfigFile)
        //    //        {
        //    //            Check.Require(File.Exists(sessionFactoryConfigPath),
        //    //                "The config file at '" + sessionFactoryConfigPath + "' could not be found");
        //    //            cfg.Configure(sessionFactoryConfigPath);


        //    //        }
        //    //        else
        //    //        {
        //    //            cfg.Configure();
        //    //        }


        //    //        //  Now that we have our Configuration object, create a new SessionFactory
        //    //        sessionFactory = cfg.BuildSessionFactory();


        //    //        Check.Ensure(sessionFactory != null, "sessionFactory is null and was not built");
        //    //        sessionFactories.Add(sessionFactoryConfigPath, sessionFactory);
        //    //    }
        //    //}
        //    #endregion

        //    return sessionFactory;
        //}

        private static ISessionFactory CreateSessionFactory()
        {
            var intercepter = new DataBindingIntercepter();

            ISessionFactory sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008
                .ConnectionString( c => c
                    .Server(Instance.DatabaseServer)
                    .Database(Instance.DatabaseName)
                    .Username(Instance.DatabaseUserName)
                    .Password(Instance.DatabasePassword)))
                .Mappings(m =>m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly())
                    //.ExportTo("D:\\Projects\\Naz.Hastane.Git\\Naz.Hastane.Data\\Docs\\GeneratedHBM")
                    )
                //.Mappings(m => m.HbmMappings.AddClasses(typeof(AccountingDailySummary)))
                //.Mappings(m => m.HbmMappings.AddClasses(typeof(DailyTellerReportRecord)))
                //.Mappings(m => m.HbmMappings.AddClasses(typeof(PatientBalanceRecord)))
                //.Mappings(m => m.HbmMappings.AddClasses(typeof(EczaneDagilim)))
                .Mappings(m => m.HbmMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))

                .ExposeConfiguration(x => x.SetInterceptor(intercepter))
                  
                .BuildSessionFactory();

            intercepter.SessionFactory = sessionFactory;
            return sessionFactory;
        }

        public string DatabaseServer;
        public string DatabaseName;
        public string DatabaseUserName;
        public string DatabasePassword;

        #region Other Code to be implemented later
        ///// <summary>
        ///// Allows you to register an interceptor on a new session.  This may not be called if there is already
        ///// an open session attached to the HttpContext.  If you have an interceptor to be used, modify
        ///// the HttpModule to call this before calling BeginTransaction().
        ///// </summary>
        //public void RegisterInterceptorOn(string sessionFactoryConfigPath, IInterceptor interceptor)
        //{
        //    ISession session = (ISession)ContextSessions[sessionFactoryConfigPath];

        //    if (session != null && session.IsOpen)
        //    {
        //        throw new CacheException("You cannot register an interceptor once a session has already been opened");
        //    }

        //    GetSessionFrom(sessionFactoryConfigPath, interceptor);
        //}

        //public ISession GetSessionFrom(string sessionFactoryConfigPath)
        //{
        //    return GetSessionFrom(sessionFactoryConfigPath, null);
        //}
        ///// <summary>
        ///// Gets or creates an ISession using the web / app config file.
        ///// </summary>
        ///// <returns></returns>
        //public ISession GetSessionFrom()
        //{
        //    return GetSessionFrom(DefaultConfigFile, null);
        //}
        ///// <summary>
        ///// Gets a session with or without an interceptor.  This method is not called directly; instead,
        ///// it gets invoked from other public methods.
        ///// </summary>
        //private ISession GetSessionFrom(string sessionFactoryConfigPath, IInterceptor interceptor)
        //{
        //    var allSessions = ContextSessions;
        //    ISession session = null;
        //    if (!allSessions.TryGetValue(sessionFactoryConfigPath, out session))
        //    {
        //        if (interceptor != null)
        //        {
        //            session = GetSessionFactoryFor(sessionFactoryConfigPath).OpenSession(interceptor);
        //        }
        //        else
        //        {
        //            session = GetSessionFactoryFor(sessionFactoryConfigPath).OpenSession();
        //        }

        //        allSessions[sessionFactoryConfigPath] = session;
        //    }

        //    //session.FlushMode = FlushMode.Always;

        //    Check.Ensure(session != null, "session was null");

        //    return session;
        //}

        ///// <summary>
        ///// Flushes anything left in the session and closes the connection.
        ///// </summary>
        //public void CloseSessionOn(string sessionFactoryConfigPath)
        //{
        //    ISession session;
        //    if (ContextSessions.TryGetValue(sessionFactoryConfigPath, out session))
        //    {
        //        if (session.IsOpen)
        //        {
        //            session.Flush();
        //            session.Close();
        //        }
        //        ContextSessions.Remove(sessionFactoryConfigPath);

        //    }

        //}

        //public ITransaction BeginTransactionOn(string sessionFactoryConfigPath)
        //{
        //    ITransaction transaction;

        //    if (!ContextTransactions.TryGetValue(sessionFactoryConfigPath, out transaction))
        //    {
        //        transaction = GetSessionFrom(sessionFactoryConfigPath).BeginTransaction();
        //        ContextTransactions.Add(sessionFactoryConfigPath, transaction);
        //    }

        //    return transaction;
        //}

        //public void CommitTransactionOn(string sessionFactoryConfigPath)
        //{

        //    try
        //    {
        //        if (HasOpenTransactionOn(sessionFactoryConfigPath))
        //        {
        //            ITransaction transaction = (ITransaction)ContextTransactions[sessionFactoryConfigPath];

        //            transaction.Commit();
        //            ContextTransactions.Remove(sessionFactoryConfigPath);
        //        }
        //    }
        //    catch (HibernateException he)
        //    {
        //        try
        //        {
        //            RollbackTransactionOn(sessionFactoryConfigPath);
        //        }
        //        finally
        //        {
        //            throw he;
        //        }
        //    }
        //}

        //public bool HasOpenTransactionOn(string sessionFactoryConfigPath)
        //{
        //    ITransaction transaction;
        //    if (ContextTransactions.TryGetValue(sessionFactoryConfigPath, out transaction))
        //    {

        //        return !transaction.WasCommitted && !transaction.WasRolledBack;
        //    }
        //    return false;
        //}

        //public void RollbackTransactionOn(string sessionFactoryConfigPath)
        //{

        //    try
        //    {
        //        if (HasOpenTransactionOn(sessionFactoryConfigPath))
        //        {
        //            ITransaction transaction = (ITransaction)ContextTransactions[sessionFactoryConfigPath];

        //            transaction.Rollback();
        //        }

        //        ContextTransactions.Remove(sessionFactoryConfigPath);
        //    }
        //    finally
        //    {

        //        ForceCloseSessionOn(sessionFactoryConfigPath);
        //    }
        //}

        ///// <summary>
        ///// Since multiple databases may be in use, there may be one transaction per database 
        ///// persisted at any one time.  The easiest way to store them is via a hashtable
        ///// with the key being tied to session factory.  If within a web context, this uses
        ///// <see cref="HttpContext" /> instead of the WinForms specific <see cref="CallContext" />.  
        ///// Discussion concerning this found at http://forum.springframework.net/showthread.php?t=572
        ///// </summary>
        //private Dictionary<string, ITransaction> ContextTransactions
        //{
        //    get
        //    {
        //        if (IsInWebContext())
        //        {
        //            if (HttpContext.Current.Items[TRANSACTION_KEY] == null)
        //                HttpContext.Current.Items[TRANSACTION_KEY] = new Dictionary<string, ITransaction>();

        //            return (Dictionary<string, ITransaction>)HttpContext.Current.Items[TRANSACTION_KEY];
        //        }
        //        else
        //        {
        //            if (CallContext.GetData(TRANSACTION_KEY) == null)
        //                CallContext.SetData(TRANSACTION_KEY, new Dictionary<string, ITransaction>());

        //            return (Dictionary<string, ITransaction>)CallContext.GetData(TRANSACTION_KEY);
        //        }
        //    }
        //}

        ///// <summary>
        ///// Since multiple databases may be in use, there may be one session per database 
        ///// persisted at any one time.  The easiest way to store them is via a hashtable
        ///// with the key being tied to session factory.  If within a web context, this uses
        ///// <see cref="HttpContext" /> instead of the WinForms specific <see cref="CallContext" />.  
        ///// Discussion concerning this found at http://forum.springframework.net/showthread.php?t=572
        ///// </summary>
        //private Dictionary<string, ISession> ContextSessions
        //{
        //    get
        //    {
        //        if (IsInWebContext())
        //        {
        //            if (HttpContext.Current.Items[SESSION_KEY] == null)
        //                HttpContext.Current.Items[SESSION_KEY] = new Dictionary<string, ISession>();

        //            return (Dictionary<string, ISession>)HttpContext.Current.Items[SESSION_KEY];
        //        }
        //        else
        //        {
        //            if (CallContext.GetData(SESSION_KEY) == null)
        //                CallContext.SetData(SESSION_KEY, new Dictionary<string, ISession>());

        //            return (Dictionary<string, ISession>)CallContext.GetData(SESSION_KEY);
        //        }
        //    }
        //}

        //private bool IsInWebContext()
        //{
        //    return HttpContext.Current != null;
        //}

        //private Dictionary<string, ISessionFactory> sessionFactories = new Dictionary<string, ISessionFactory>();
        //private const string TRANSACTION_KEY = "CONTEXT_TRANSACTIONS";
        //private const string SESSION_KEY = "CONTEXT_SESSIONS";

        //public bool HasOpenTransactionOn()
        //{
        //    return HasOpenTransactionOn(DefaultConfigFile);
        //}

        //public void CommitTransactionOn()
        //{
        //    CommitTransactionOn(DefaultConfigFile);
        //}

        //public void CloseSessionOn()
        //{
        //    CloseSessionOn(DefaultConfigFile);
        //}

        //public void ForceCloseSessionOn()
        //{
        //    ForceCloseSessionOn(DefaultConfigFile);

        //}

        //public void ForceCloseSessionOn(string sessionFactoryConfigPath)
        //{
        //    ISession session;
        //    if (ContextSessions.TryGetValue(sessionFactoryConfigPath, out session))
        //    {
        //        if (session.IsOpen)
        //        {

        //            session.Close();
        //        }
        //        ContextSessions.Remove(sessionFactoryConfigPath);

        //    }
        //}

        //public void BeginTransactionOn()
        //{
        //    this.BeginTransactionOn(DefaultConfigFile);
        //}

        //public void RollbackTransactionOn()
        //{
        //    this.RollbackTransactionOn(DefaultConfigFile);
        //}
        #endregion

    }
}
