// <copyright file="WindowCapture.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;

namespace Drastic.RemoteAppViewer.Mac
{
    public class WindowCapture : IWindowCaptureSurface
    {
        public WindowCapture(WindowInfo info)
        {
            this.Window = info;
            this.Surface = new MacCaptureItem(info);
        }

        /// <inheritdoc/>
        public IWindow Window { get; }

        /// <inheritdoc/>
        public ICaptureSurface Surface { get; }
    }
}
