// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics;
using System.Windows.Controls;
using PathAnimations.composite_pattern;

namespace PathAnimations
{
    public partial class SampleViewer : Page
    {
        public SampleViewer()
        {
            IhtiyaclariKarcila();

            InitializeComponent();
        }

        private void IhtiyaclariKarcila()
        {
            Musteri musteri = new Musteri();

            // This way the client code can support the simple leaf
            // components...
            Yaprak leaf = new Yaprak();
            Console.WriteLine("Musteri: Bir dalim var:");
            musteri.IslemMusteri(leaf);

            // ...as well as the complex composites.
            Dal tree = new Dal();
            Dal branch1 = new Dal();
            branch1.Ekle(new Yaprak());
            branch1.Ekle(new Yaprak());
            Dal branch2 = new Dal();
            branch2.Ekle(new Yaprak());
            tree.Ekle(branch1);
            tree.Ekle(branch2);
            Trace.WriteLine("Musteri: Simdi dalli budakli bir agacim oldu:");
            musteri.IslemMusteri(tree);

            Trace.Write("Musteri: Agacim buyoyormu nee? :\n");
            musteri.IslemMusteri_2(tree, leaf);
        }
    }
}