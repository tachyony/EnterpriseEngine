// <copyright file="IEnterpriseApi.cs" company="EnterpriseEngine">
// Copyright © EnterpriseEngine 2013
// </copyright>
namespace EnterpriseEngineApi
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.ServiceModel;
    using System.ServiceModel.Web;
    using System.Text;
    
    /// <summary>
    /// Enterprise Api
    /// </summary>
    [ServiceContract]
    public interface IEnterpriseApi
    {
        /// <summary>
        /// Gets the decision.
        /// </summary>
        /// <param name="decision">The decision.</param>
        /// <returns>Decision result</returns>
        [OperationContract]
        DecisionType GetDecision(DecisionType decision);
    }

    /// <summary>
    /// Decision Type
    /// </summary>
    [DataContract]
    public class DecisionType
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="DecisionType"/> is result.
        /// </summary>
        /// <value>
        ///   <c>true</c> if result; otherwise, <c>false</c>.
        /// </value>
        [DataMember]
        public bool Result
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the random string.
        /// </summary>
        /// <value>
        /// The random string.
        /// </value>
        [DataMember]
        public string RandomString
        {
            get;
            set;
        }
    }
}
