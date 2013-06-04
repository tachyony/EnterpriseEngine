// <copyright file="AuditMessage.cs" company="EnterpriseEngine">
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
    public class AuditMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditMessage"/> class.
        /// </summary>
        public AuditMessage()
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
