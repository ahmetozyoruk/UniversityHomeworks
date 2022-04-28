// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Windows.Forms;
using SelectionTarget.Adapter_Pattern;

namespace SelectionPatternTarget
{
    public partial class Target : Form
    {
        /// <summary>
        ///     The target application for the SelectionPattern Sample.
        /// </summary>
        public Target()
        {
            InitializeComponent();
            ApplyPattern();
        }

        private void ApplyPattern()
        {

            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Trace.WriteLine("Adaptee interface is incompatible with the client.");
            Trace.WriteLine("But with adapter client can call it's method.");

            Trace.WriteLine(target.GetRequest());
        }

        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Target());

        }
    }
}