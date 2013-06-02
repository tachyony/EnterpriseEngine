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
            LogModelContainer container = new LogModelContainer();
            container.Logs.AddObject(new Log() { Message = message });
            container.SaveChanges();
        }

        /// <summary>
        /// Logs the audit message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void LogAudit(string message)
        {
            LogModelContainer container = new LogModelContainer();
            container.Audits.AddObject(new Audit() { Message = message });
            container.SaveChanges();
        }
    }
}
