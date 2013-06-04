// <copyright file="IDataLogger.cs" company="EnterpriseEngine">
// Copyright © EnterpriseEngine 2013
// </copyright>
namespace EnterpriseEngine.SqliteLogging
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    /// <summary>
    /// IData Logger
    /// </summary>
    interface IDataLogger
    {
        /// <summary>
        /// Logs the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        void Log(string message);

        /// <summary>
        /// Logs the specified audit message.
        /// </summary>
        /// <param name="message">The message.</param>
        void LogAudit(string message);
    }
}
