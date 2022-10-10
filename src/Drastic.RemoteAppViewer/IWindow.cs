// <copyright file="IWindow.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;

namespace Drastic.RemoteAppViewer
{
    /// <summary>
    /// Window information.
    /// </summary>
    public interface IWindow : ISurface
    {
        /// <summary>
        /// Gets the raw handler.
        /// </summary>
        object RawHandler { get; }
    }
}