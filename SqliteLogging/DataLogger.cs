// <copyright file="DataLogger.cs" company="EnterpriseEngine">
// Copyright © EnterpriseEngine 2013
// </copyright>
namespace EnterpriseEngine.SqliteLogging
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using EnterpriseEngine.SqliteLogging.Entities;
    using FluentNHibernate.Automapping;
    using FluentNHibernate.Cfg;
    using FluentNHibernate.Cfg.Db;
    using NHibernate;
    using NHibernate.Cfg;
    using NHibernate.Tool.hbm2ddl;

    /// <summary>
    /// Data Logger
    /// </summary>
    public class DataLogger : IDataLogger
    {
        /// <summary>
        /// Session Factory
        /// </summary>
        private ISessionFactory sessionFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataLogger"/> class.
        /// </summary>
        public DataLogger()
        {
            AutoMap.AssemblyOf<AuditMessage>();
            this.sessionFactory = Fluently.Configure().Database(SQLiteConfiguration.Standard.UsingFile(System.Configuration.ConfigurationManager.AppSettings["DatabasePath"])).Mappings(m => m.AutoMappings.Add(AutoMap.AssemblyOf<AuditMessage>(new LogConfiguration()))).ExposeConfiguration(this.BuildSchema).BuildSessionFactory();
        }

        /// <summary>
        /// Logs the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Log(string message)
        {
            using (ISession session = this.sessionFactory.OpenSession())
            {
                LogMessage logMessage = new LogMessage();
                logMessage.Message = message;
                session.Save(logMessage);
            }
        }

        /// <summary>
        /// Logs the audit message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void LogAudit(string message)
        {
            using (ISession session = this.sessionFactory.OpenSession())
            {
                AuditMessage auditMessage = new AuditMessage();
                auditMessage.Message = message;
                session.Save(auditMessage);
            }
        }

        /// <summary>
        /// Builds the schema.
        /// </summary>
        /// <param name="config">The config.</param>
        public void BuildSchema(Configuration config)
        {
            // Creates database structure
            new SchemaExport(config).Create(false, true);
        }
    }
}
