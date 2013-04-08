using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrangeBit.MvvmCross.Plugins.Bitmap
{
    public static class Extensions
    {
        public static string GetResourcePath(this MvxResourcePath compositionRoot, string separator, bool includeNameSpace = true)
        {
            var final = "";
            if (compositionRoot == null) return null;
            var current = compositionRoot;
            while (true)
            {
                if (current == null) break;
                if (current.WhatIs == MvxResourcePathWhatIs.NamespaceName && !includeNameSpace)
                {
                    current = current.Next;
                    continue;
                }
                if (final != "")
                    final += separator;
                final += current.Name;

                current = current.Next;
            }

            return final;
        }
    }
}
