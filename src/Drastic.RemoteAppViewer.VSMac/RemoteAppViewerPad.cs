// <copyright file="RemoteAppViewerPad.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;
using MonoDevelop.Components;
using MonoDevelop.Ide.Gui;

namespace Drastic.RemoteAppViewer.VSMac
{
    public partial class RemoteAppViewerPad : PadContent
    {
        private NSView content;

        public override Control Control => content;

        public RemoteAppViewerPad()
        {
            this.content = new NSView();
        }
    }
}