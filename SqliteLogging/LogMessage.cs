// <copyright file="LogMessage.cs" company="EnterpriseEngine">
// Copyright © EnterpriseEngine 2013
// </copyright>
namespace EnterpriseEngine.SqliteLogging
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Log Message
    /// </summary>
    public class LogMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogMessage"/> class.
        /// </summary>
        public LogMessage()
        {
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>
        /// The id.
        /// </value>
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string Message
        {
            get;
            set;
        }
    }
}
