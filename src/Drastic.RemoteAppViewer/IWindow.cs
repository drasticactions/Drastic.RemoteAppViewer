// <copyright file="IWindow.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;

namespace Drastic.RemoteAppViewer
{
    /// <summary>
    /// Window information.
    /// </summary>
    public interface IWindow
    {
        /// <summary>
        /// Gets the window title.
        /// </summary>
        string Title { get; }

        /// <summary>
        /// Gets the raw handler.
        /// </summary>
        object RawHandler { get; }
    }
}