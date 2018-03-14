﻿// ***********************************************************************
// Copyright (c) 2018 Charlie Poole
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// ***********************************************************************

using System.Windows.Forms;
using NUnit.Engine;

namespace TestCentric.Gui.Model.Settings
{
    public class ErrorBrowserSettings : SettingsGroup
    {
        public ErrorBrowserSettings(ISettings settings)
             : base(settings, "Gui.ResultTabs.ErrorBrowser") { }

        public bool SourceCodeDisplay
        {
           get { return GetSetting("SourceCodeDisplay", false); }
           set { SaveSetting("SourceCodeDisplay", value); }
        }

        public Orientation SplitterOrientation
        {
            get { return GetSetting("SplitterOrientation", Orientation.Vertical); }
            set { SaveSetting("SplitterOrientation", value); }
        }

        public float VerticalPosition
        {
            get { return GetSetting("VerticalPosition", 0.3f); }
            set { SaveSetting("VerticalPosition", value); }
        }

        public float HorizontalPosition
        {
            get { return GetSetting("HorizontalPosition", 0.3f); }
            set { SaveSetting("HorizontalPosition", value); }
        }
    }
}