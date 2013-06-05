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
    using System.Text;

    /// <summary>
    /// Enterprise Api
    /// </summary>
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.PerCall)]
    public class EnterpriseApi : IEnterpriseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseApi"/> class.
        /// </summary>
        public EnterpriseApi()
        {
        }

        /// <summary>
        /// Gets the data using data contract.
        /// </summary>
        /// <param name="decision">The decision.</param>
        /// <returns>The result</returns>
        public DecisionType GetDecision(DecisionType decision)
        {
            DecisionType resultDecision = new DecisionType()
            {
                CheckBox = decision.CheckBox
            };
            try
            {
                Func<int> decisionFunc = (() =>
                {
                    Random random = new Random();
                    return random.Next(-10, 10);
                });

                Func<bool, int> ifFunc = ((condition) =>
                {
                    if (condition)
                    {
                        return decisionFunc();
                    }
                    else
                    {
                        return 0;
                    }
                });

                Func<List<bool>, int> intFunc = ((decisions) =>
                {
                    int intResult = 0;
                    for (int i = 0; i < decisions.Count; i++)
                    {
                        intResult += ifFunc(decisions[i]);
                    }

                    return intResult;
                });

                int numsResult = intFunc(decision.CheckBox);

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

                decisionResult += numsResult;
                if (decisionResult >= 0)
                {
                    resultDecision.Result = true;
                }
            }
            catch (Exception eek)
            {
                resultDecision.RandomString = eek.Message;
            }

            return resultDecision;
        }
    }
}
