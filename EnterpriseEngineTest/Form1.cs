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
            try
            {
                EnterpriseEngineApi.DecisionType decType = new EnterpriseEngineApi.DecisionType();
                decType.Result = false;
                decType.RandomString = "Foam";
                decType.CheckBox = new List<bool>();
                for (int h = 0; h < 132; h++)
                {
                    decType.CheckBox.Add(true);
                }

                Stopwatch sw = Stopwatch.StartNew();
                EventWaitHandle[] whs = new EventWaitHandle[20];
                for (int j = 0; j < 20; j++)
                {
                    whs[j] = new EventWaitHandle(false, EventResetMode.ManualReset);
                    Thread ts = new Thread(new ParameterizedThreadStart((num) =>
                    {
                        int h = 0;
                        EnterpriseEngineApi.EnterpriseApi eapiClient = new EnterpriseEngineApi.EnterpriseApi();
                        for (int i = 0; i < 100; i++)
                        {
                            EnterpriseEngineApi.DecisionType decisionResult = eapiClient.GetDecision(decType);
                            if (decisionResult.Result)
                            {
                                h++;
                            }
                        }

                        Trace.WriteLine((h > 50).ToString() + (h-50).ToString());
                        whs[(int)num].Set();
                    }));
                    ts.IsBackground = true;
                    ts.Start(j);
                }

                for (int k = 0; k < 20; k++)
                {
                    whs[k].WaitOne();
                }

                Trace.WriteLine("Time=" + sw.ElapsedMilliseconds);
            }
            catch (Exception eek)
            {
                Trace.WriteLine(eek.Message);
            }
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
