using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNET_Demo.code {
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    sealed class LinkedPageAttribute : Attribute {
        public int Index;

        public string Link;
        public string Title;

        public LinkedPageAttribute(int Index) {
            this.Index = Index;
        }
    }
}