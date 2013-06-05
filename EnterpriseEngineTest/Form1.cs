// <copyright file="Form1.cs" company="EnterpriseEngine">
// Copyright © EnterpriseEngine 2013
// </copyright>
namespace EnterpriseEngineTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using EnterpriseEngine.SqliteLogging;
    using EnterpriseEngine.Test.EnterpriseApi;
    using System.Threading;

    /// <summary>
    /// The form
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Data Logger
        /// </summary>
        private DataLogger logger;
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            this.InitializeComponent();
            this.logger = new DataLogger();
        }

        /// <summary>
        /// Handles the Click event of the button1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void Button1_Click(object sender, EventArgs e)
        {
            this.logger.LogAudit(this.textBox1.Text);
        }

        /// <summary>
        /// Handles the Click event of the button2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void Button2_Click(object sender, EventArgs e)
        {
            this.logger.Log(this.textBox1.Text);
        }

        /// <summary>
        /// Handles the Click event of the Button3 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void Button3_Click(object sender, EventArgs e)
        {
            DecisionType decType = new DecisionType();
            decType.Result = false;
            decType.RandomString = "Foam";
            decType.CheckBox = new List<bool>();
            for (int h = 0; h < 132; h++)
            {
                decType.CheckBox.Add(true);
            }

            Stopwatch sw = Stopwatch.StartNew();
            try
            {
                int g = 0;
                int h = 0;
                for (int j = 0; j < 18; j++)
                {
                    Thread ts = new Thread(new ThreadStart(() =>
                    {
                        for (int i = 0; i < 100; i++)
                        {
                            EnterpriseApiClient eapiClient = new EnterpriseApiClient();
                            eapiClient.Open();
                            DecisionType decisionResult = eapiClient.GetDecision(decType);

                            // Trace.WriteLine(decisionResult.Result.ToString() + "::" + decisionResult.RandomString);
                            if (decisionResult.Result)
                            {
                                h++;
                            }

                            g++;
                            eapiClient.Close();
                        }
                    }));
                    ts.IsBackground = true;
                    ts.Start();
                }

                for (int i = 0; i < 200; i++)
                {
                    EnterpriseApiClient eapiClient = new EnterpriseApiClient();
                    eapiClient.Open();
                    DecisionType decisionResult = eapiClient.GetDecision(decType);
                    
                    // Trace.WriteLine(decisionResult.Result.ToString() + "::" + decisionResult.RandomString);
                    if (decisionResult.Result)
                    {
                        h++;
                    }

                    g++;
                    eapiClient.Close();
                }
                
                Trace.WriteLine(h.ToString() + "/" + g.ToString());
            }
            catch (Exception eek)
            {
                Trace.WriteLine(eek.Message);
            }

            Trace.WriteLine(sw.ElapsedMilliseconds.ToString());
        }

        /// <summary>
        /// Handles the Click event of the button4 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void button4_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter s = new System.IO.StreamWriter("Table.txt");
            int h = 0;
            for (int i = 0; i < 12; i++)
            {
                s.WriteLine("<tr>");
                for (int j = 0; j < 11; j++)
                {
                    s.WriteLine("<td><asp:RadioButton ID=\"RadioButtonYes" + h.ToString() + "\" runat=\"server\" Text=\"Yes\" GroupName=\"Group" + h.ToString() + "\" /> <asp:RadioButton ID=\"RadioButtonNo" + h.ToString() + "\" runat=\"server\" Text=\"No\" GroupName=\"Group" + h.ToString() + "\" Checked=\"True\" /></td>");
                    h++;
                }

                s.WriteLine("</tr>");
            }
            s.Flush();
            s.Dispose();
        }
    }
}
