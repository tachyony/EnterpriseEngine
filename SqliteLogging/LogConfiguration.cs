// <copyright file="LogConfiguration.cs" company="EnterpriseEngine">
// Copyright © EnterpriseEngine 2013
// </copyright>
namespace EnterpriseEngine.SqliteLogging
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FluentNHibernate;
    using FluentNHibernate.Automapping;

    /// <summary>
    /// Log Configuration
    /// </summary>
    public class LogConfiguration : DefaultAutomappingConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogConfiguration"/> class.
        /// </summary>
        public LogConfiguration()
        {
        }

        /// <summary>
        /// Should map.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>Should map</returns>
        public override bool ShouldMap(Type type)
        {
            return type.Namespace == "EnterpriseEngine.SqliteLogging.Entities";
        }

        /// <summary>
        /// Determines whether the specified member is id.
        /// </summary>
        /// <param name="member">The member.</param>
        /// <returns>
        ///   <c>true</c> if the specified member is id; otherwise, <c>false</c>.
        /// </returns>
        public override bool IsId(Member member)
        {
            return member.Name == "Id";
        }
    }
}
