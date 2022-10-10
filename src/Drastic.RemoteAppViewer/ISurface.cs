// <copyright file="ISurface.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;

namespace Drastic.RemoteAppViewer
{
    public interface ISurface
    {
        /// <summary>
        /// Gets the window title.
        /// </summary>
        string Title { get; }
    }
}