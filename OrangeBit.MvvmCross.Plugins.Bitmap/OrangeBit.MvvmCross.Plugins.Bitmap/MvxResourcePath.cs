// (c) Copyright OrangeBit s.c.r.l. http://www.orangebit.it
// OrangeBit.MvvmCross.Plugins.Bitmap is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Sebastian Faltoni, sebastian(at)orangebit.it

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrangeBit.MvvmCross.Plugins.Bitmap
{

    public enum MvxResourcePathWhatIs
    {
        NamespaceName,
        FolderName,
        FileName
    }
    public class MvxResourcePath
    {
        internal string Name { get; set; }

        internal MvxResourcePathWhatIs WhatIs { get; set; } 

        internal MvxResourcePath Next { get; set; }


        public MvxResourcePath(string name, MvxResourcePath next = null, MvxResourcePathWhatIs whatIs = MvxResourcePathWhatIs.NamespaceName)
        {
            this.Name = name;
            this.WhatIs = whatIs;
            this.Next = next;
        }


    }
}
