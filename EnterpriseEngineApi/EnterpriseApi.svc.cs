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
            try
            {
                Func<int, bool> ifFunc = IfFunc(
                    IfFunc(
                        IfFunc(
                            IfFunc(
                                IfFunc(
                                    IfFunc(
                                        IfFunc(
                                            NestIfFunc(decision.CheckBox[127]),
                                            NestIfFunc(decision.CheckBox[128]),
                                            decision.CheckBox[63]),
                                        IfFunc(
                                            NestIfFunc(decision.CheckBox[129]),
                                            NestIfFunc(decision.CheckBox[130]),
                                            decision.CheckBox[64]),
                                        decision.CheckBox[31]),
                                    IfFunc(
                                        IfFunc(
                                            NestIfFunc(decision.CheckBox[131]),
                                            NestIfFunc(decision.CheckBox[132]),
                                            decision.CheckBox[65]),
                                        NestIfFunc(decision.CheckBox[66]),
                                        decision.CheckBox[32]),
                                    decision.CheckBox[15]),
                                IfFunc(
                                    IfFunc(
                                        IfFunc(
                                            NestIfFunc(decision.CheckBox[69]),
                                            NestIfFunc(decision.CheckBox[69]),
                                            decision.CheckBox[67]),
                                        IfFunc(
                                            NestIfFunc(decision.CheckBox[69]),
                                            NestIfFunc(decision.CheckBox[69]),
                                            decision.CheckBox[68]),
                                        decision.CheckBox[33]),
                                    IfFunc(
                                        NestIfFunc(decision.CheckBox[69]),
                                        NestIfFunc(decision.CheckBox[70]),
                                        decision.CheckBox[34]),
                                    decision.CheckBox[16]),
                                decision.CheckBox[7]),
                            IfFunc(
                                IfFunc(
                                    IfFunc(
                                        NestIfFunc(decision.CheckBox[71]),
                                        NestIfFunc(decision.CheckBox[72]),
                                        decision.CheckBox[35]),
                                    IfFunc(
                                        NestIfFunc(decision.CheckBox[73]),
                                        NestIfFunc(decision.CheckBox[74]),
                                        decision.CheckBox[36]),
                                    decision.CheckBox[17]),
                                IfFunc(
                                    IfFunc(
                                        NestIfFunc(decision.CheckBox[75]),
                                        NestIfFunc(decision.CheckBox[76]),
                                        decision.CheckBox[37]),
                                    IfFunc(
                                        NestIfFunc(decision.CheckBox[77]),
                                        NestIfFunc(decision.CheckBox[78]),
                                        decision.CheckBox[38]),
                                    decision.CheckBox[18]),
                                decision.CheckBox[8]),
                            decision.CheckBox[3]),
                        IfFunc(
                            IfFunc(
                                IfFunc(
                                    IfFunc(
                                        NestIfFunc(decision.CheckBox[79]),
                                        NestIfFunc(decision.CheckBox[80]),
                                        decision.CheckBox[39]),
                                    IfFunc(
                                        NestIfFunc(decision.CheckBox[81]),
                                        NestIfFunc(decision.CheckBox[82]),
                                        decision.CheckBox[40]),
                                    decision.CheckBox[19]),
                                IfFunc(
                                    IfFunc(
                                        NestIfFunc(decision.CheckBox[83]),
                                        NestIfFunc(decision.CheckBox[84]),
                                        decision.CheckBox[41]),
                                    IfFunc(
                                        NestIfFunc(decision.CheckBox[85]),
                                        NestIfFunc(decision.CheckBox[86]),
                                        decision.CheckBox[42]),
                                    decision.CheckBox[20]),
                                decision.CheckBox[9]),
                            IfFunc(
                                IfFunc(
                                    IfFunc(
                                        NestIfFunc(decision.CheckBox[87]),
                                        NestIfFunc(decision.CheckBox[88]),
                                        decision.CheckBox[43]),
                                    IfFunc(
                                        NestIfFunc(decision.CheckBox[89]),
                                        NestIfFunc(decision.CheckBox[90]),
                                        decision.CheckBox[44]),
                                    decision.CheckBox[21]),
                                IfFunc(
                                    IfFunc(
                                        NestIfFunc(decision.CheckBox[91]),
                                        NestIfFunc(decision.CheckBox[92]),
                                        decision.CheckBox[45]),
                                    IfFunc(
                                        NestIfFunc(decision.CheckBox[93]),
                                        NestIfFunc(decision.CheckBox[94]),
                                        decision.CheckBox[46]),
                                    decision.CheckBox[22]),
                                decision.CheckBox[10]),
                            decision.CheckBox[4]),
                        decision.CheckBox[1]),
                    IfFunc(
                        IfFunc(
                            IfFunc(
                                IfFunc(
                                    IfFunc(
                                        NestIfFunc(decision.CheckBox[95]),
                                        NestIfFunc(decision.CheckBox[96]),
                                        decision.CheckBox[47]),
                                    IfFunc(
                                        NestIfFunc(decision.CheckBox[97]),
                                        NestIfFunc(decision.CheckBox[98]),
                                        decision.CheckBox[48]),
                                    decision.CheckBox[23]),
                                IfFunc(
                                    IfFunc(
                                        NestIfFunc(decision.CheckBox[99]),
                                        NestIfFunc(decision.CheckBox[100]),
                                        decision.CheckBox[49]),
                                    IfFunc(
                                        NestIfFunc(decision.CheckBox[101]),
                                        NestIfFunc(decision.CheckBox[102]),
                                        decision.CheckBox[50]),
                                    decision.CheckBox[24]),
                                decision.CheckBox[11]),
                            IfFunc(
                                IfFunc(
                                    IfFunc(
                                        NestIfFunc(decision.CheckBox[103]),
                                        NestIfFunc(decision.CheckBox[104]),
                                        decision.CheckBox[51]),
                                    IfFunc(
                                        NestIfFunc(decision.CheckBox[105]),
                                        NestIfFunc(decision.CheckBox[106]),
                                        decision.CheckBox[52]),
                                    decision.CheckBox[25]),
                                IfFunc(
                                    IfFunc(
                                        NestIfFunc(decision.CheckBox[107]),
                                        NestIfFunc(decision.CheckBox[108]),
                                        decision.CheckBox[53]),
                                    IfFunc(
                                        NestIfFunc(decision.CheckBox[109]),
                                        NestIfFunc(decision.CheckBox[110]),
                                        decision.CheckBox[54]),
                                    decision.CheckBox[26]),
                                decision.CheckBox[12]),
                            decision.CheckBox[5]),
                        IfFunc(
                            IfFunc(
                                IfFunc(
                                    IfFunc(
                                        NestIfFunc(decision.CheckBox[111]),
                                        NestIfFunc(decision.CheckBox[112]),
                                        decision.CheckBox[55]),
                                    IfFunc(
                                        NestIfFunc(decision.CheckBox[113]),
                                        NestIfFunc(decision.CheckBox[114]),
                                        decision.CheckBox[56]),
                                    decision.CheckBox[27]),
                                IfFunc(
                                    IfFunc(
                                        NestIfFunc(decision.CheckBox[115]),
                                        NestIfFunc(decision.CheckBox[116]),
                                        decision.CheckBox[57]),
                                    IfFunc(
                                        NestIfFunc(decision.CheckBox[117]),
                                        NestIfFunc(decision.CheckBox[118]),
                                        decision.CheckBox[58]),
                                    decision.CheckBox[28]),
                                decision.CheckBox[13]),
                            IfFunc(
                                IfFunc(
                                    IfFunc(
                                        NestIfFunc(decision.CheckBox[119]),
                                        NestIfFunc(decision.CheckBox[120]),
                                        decision.CheckBox[59]),
                                    IfFunc(
                                        NestIfFunc(decision.CheckBox[121]),
                                        NestIfFunc(decision.CheckBox[122]),
                                        decision.CheckBox[60]),
                                    decision.CheckBox[29]),
                                IfFunc(
                                    IfFunc(
                                        NestIfFunc(decision.CheckBox[123]),
                                        NestIfFunc(decision.CheckBox[124]),
                                        decision.CheckBox[61]),
                                    IfFunc(
                                        NestIfFunc(decision.CheckBox[125]),
                                        NestIfFunc(decision.CheckBox[126]),
                                        decision.CheckBox[62]),
                                    decision.CheckBox[30]),
                                decision.CheckBox[14]),
                            decision.CheckBox[6]),
                        decision.CheckBox[2]),
                    decision.CheckBox[0]);
                bool ok = ifFunc(0);

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
        
        /// <summary>
        /// If func.
        /// </summary>
        /// <param name="trueFunc">The true func.</param>
        /// <param name="falseFunc">The false func.</param>
        /// <param name="condition">if set to <c>true</c> condition.</param>
        /// <returns></returns>
        private Func<int, bool> IfFunc(Func<int, bool> trueFunc, Func<int, bool> falseFunc, bool condition)
        {
            if (condition)
            {
                return trueFunc;
            }
            else
            {
                return falseFunc;
            }
        }

        /// <summary>
        /// Nested if func.
        /// </summary>
        /// <param name="trueFunc">The true func.</param>
        /// <param name="falseFunc">The false func.</param>
        /// <param name="condition">if set to <c>true</c> condition.</param>
        /// <returns></returns>
        private Func<int, bool> NestIfFunc(bool condition)
        {
            Func<int, bool> decisionFunc = ((amount) =>
            {
                Random random = new Random();
                if (random.Next(-10, 10) > amount)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });

            return IfFunc(decisionFunc, decisionFunc, condition);
        }
    }
}
