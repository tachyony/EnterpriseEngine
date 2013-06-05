// <copyright file="EnterpriseApi.svc.cs" company="EnterpriseEngine">
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
    [ServiceBehavior(ConcurrencyMode=ConcurrencyMode.Multiple, InstanceContextMode=InstanceContextMode.PerCall)]
    public class EnterpriseApi : IEnterpriseApi
    {
        /// <summary>
        /// Gets the data using data contract.
        /// </summary>
        /// <param name="decision">The decision.</param>
        /// <returns>The result</returns>
        public DecisionType GetDecision(DecisionType decision)
        {
            try
            {
                char[] chars = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
                Dictionary<char, int> charTable = new Dictionary<char, int>();
                int seed = new Random().Next();
                Action<char> actionRand = new Action<char>((character) =>
                {
                    Random random = new Random(seed);
                    charTable.Add(character, random.Next(-100, 100));
                    seed = random.Next();
                });
                Array.ForEach<char>(chars, actionRand);

                int decisionResult = 0;
                Action<char> actionStrimmer = new Action<char>((character) =>
                {
                    if (charTable.ContainsKey(character))
                    {
                        decisionResult += charTable[character];
                    }
                });
                char[] randomChars = decision.RandomString.ToCharArray();
                Array.ForEach<char>(randomChars, actionStrimmer);

                if (decisionResult >= 0)
                {
                    decision.Result = true;
                }
            }
            catch (Exception eek)
            {
                decision.RandomString = eek.Message;
            }

            return decision;
        }
    }
}
