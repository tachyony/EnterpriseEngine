// <copyright file="EnterpriseApi.svc.cs" company="EnterpriseEngine">
// Copyright © EnterpriseEngine 2013
// </copyright>
namespace EnterpriseEngineApi
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Xml;

    /// <summary>
    /// Enterprise Api
    /// </summary>
    public class EnterpriseApi : IEnterpriseApi
    {
        /// <summary>
        /// Valid characters
        /// </summary>
        private static readonly char[] chars = "bcdfghjklmnpqrstvwxyzABCDFGHIKLMNPQRSUVWXZ ?.".ToCharArray();

        /// <summary>
        /// Character values
        /// </summary>
        private Dictionary<char, int> charTable;

        /// <summary>
        /// Int function
        /// </summary>
        private Func<List<bool>, int> intFunc;

        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseApi"/> class.
        /// </summary>
        public EnterpriseApi()
        {
            charTable = new Dictionary<char, int>();
            int seed = new Random().Next();
            Action<char> actionRand = new Action<char>((character) =>
            {
                Random random = new Random(seed);
                charTable.Add(character, random.Next(-10, 10));
                seed = random.Next();
            });
            Array.ForEach<char>(chars, actionRand);

            Func<int, int, int> randomFunc = ((min, max) =>
            {
                Random random = new Random();
                return random.Next(min, max);
            });

            XmlDocument xmlDoc = new XmlDocument();
            if (System.IO.File.Exists(System.Windows.Forms.Application.StartupPath + "\\DecisionEngine.xml"))
            {
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.ValidationEventHandler += new System.Xml.Schema.ValidationEventHandler((sender, e) =>
                {
                    string a = e.Message;
                });
                XmlReader reader = XmlReader.Create(System.Windows.Forms.Application.StartupPath + "\\DecisionEngine.xml", settings);
                xmlDoc.Load(reader);
            }

            Func<int, int> decisionFunc = ((decisionNum) =>
            {
                int decisionResult = 0;
                XmlNode node = xmlDoc.DocumentElement.ChildNodes[decisionNum];
                if ((node != null) && node.Attributes["decisionType"].Value == "Random")
                {
                    var n1 = node["Min"].InnerText;
                    var n2 = node["Max"].InnerText;
                    int min = int.Parse(n1);
                    int max = int.Parse(n2);
                    decisionResult += randomFunc(min, max);
                }

                return decisionResult;
            });
            
            intFunc = ((decisions) =>
            {
                int intResult = 0;
                for (int i = 0; i < decisions.Count; i++)
                {
                    if (decisions[i])
                    {
                        intResult += decisionFunc(i);
                    }
                    else
                    {
                        intResult += 0;
                    }
                }

                return intResult;
            });
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
                int decisionResult = 0;
                char[] randomChars = decision.RandomString.ToCharArray();
                Array.ForEach<char>(randomChars, new Action<char>((character) =>
                {
                    if (charTable.ContainsKey(character))
                    {
                        decisionResult += charTable[character];
                    }
                }));


                int numsResult = intFunc(decision.CheckBox);
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
