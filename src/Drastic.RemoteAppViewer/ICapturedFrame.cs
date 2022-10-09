// <copyright file="ICapturedFrame.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;

namespace Drastic.RemoteAppViewer
{
    /// <summary>
    /// Captured Frame.
    /// </summary>
    public interface ICapturedFrame
    {
        /// <summary>
        /// Gets the Width of the frame.
        /// </summary>
        int Width { get; }

        /// <summary>
        /// Gets the height of the frame.
        /// </summary>
        int Height { get; }

        /// <summary>
        /// Gets the image data as a byte array.
        /// </summary>
        byte[] ImageData { get; }

        /// <summary>
        /// Gets the raw object.
        /// </summary>
        object Raw { get; }
    }
}