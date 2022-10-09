// <copyright file="MacCaptureItem.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;

namespace Drastic.RemoteAppViewer.Mac
{
    public class MacCaptureItem : ICaptureSurface
    {
        public MacCaptureItem(MonitorInfo info)
        {
            var item = new ScreenRecorder(info.Display);
            if (item is null)
            {
                throw new NullReferenceException(nameof(item));
            }

            this.RawSurface = item;
            this.Title = item.Display?.Description ?? string.Empty;
        }

        public MacCaptureItem(WindowInfo info)
        {
            var item = new ScreenRecorder(info.Window);
            if (item is null)
            {
                throw new NullReferenceException(nameof(item));
            }

            this.RawSurface = item;
            this.Title = item.Display?.Description ?? string.Empty;
        }

        /// <inheritdoc/>
        public string Title { get; }

        /// <inheritdoc/>
        public object RawSurface { get; }

        public ScreenRecorder? ScreenRecorder => this.RawSurface as ScreenRecorder;
    }
}
