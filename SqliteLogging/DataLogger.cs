// <copyright file="DataLogger.cs" company="EnterpriseEngine">
// Copyright © EnterpriseEngine 2013
// </copyright>
namespace EnterpriseEngine.SqliteLogging
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Data Logger
    /// </summary>
    public class DataLogger : IDataLogger
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataLogger"/> class.
        /// </summary>
        public DataLogger()
        {
        }

        /// <summary>
        /// Logs the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Log(string message)
        {
            LogMessage logMessage = new LogMessage();
            logMessage.Message = message;
        }

        /// <summary>
        /// Logs the audit message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void LogAudit(string message)
        {
            AuditMessage auditMessage = new AuditMessage();
            auditMessage.Message = message;
        }
    }
}
