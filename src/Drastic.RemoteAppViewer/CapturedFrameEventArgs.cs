// <copyright file="CapturedFrameEventArgs.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;

namespace Drastic.RemoteAppViewer
{
    /// <summary>
    /// Captured Frame Event Arguments.
    /// </summary>
    public class CapturedFrameEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CapturedFrameEventArgs"/> class.
        /// </summary>
        /// <param name="frame"><see cref="ICapturedFrame"/>.</param>
        public CapturedFrameEventArgs(ICapturedFrame frame)
        {
            this.Frame = frame;
        }

        /// <summary>
        /// Gets the captured frame.
        /// </summary>
        public ICapturedFrame Frame { get; }
    }
}