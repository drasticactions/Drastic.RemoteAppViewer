// <copyright file="MonitorCapture.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;

namespace Drastic.RemoteAppViewer.Mac
{
    public class MonitorCapture : IMonitorCaptureSurface
    {
        public MonitorCapture(MonitorInfo info)
        {
            this.Monitor = info;
            this.Surface = new MacCaptureItem(info);
        }

        /// <inheritdoc/>
        public IMonitor Monitor { get; }

        /// <inheritdoc/>
        public ICaptureSurface Surface { get; }
    }
}
