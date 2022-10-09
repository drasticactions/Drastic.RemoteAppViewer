// <copyright file="IWindowCaptureSurface.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;

namespace Drastic.RemoteAppViewer
{
    /// <summary>
    /// Window Capture Surface.
    /// </summary>
    public interface IWindowCaptureSurface
    {
        /// <summary>
        /// Gets the <see cref="IWindow"/>.
        /// </summary>
        IWindow Window { get; }

        /// <summary>
        /// Gets the <see cref="ICaptureSurface"/>.
        /// </summary>
        ICaptureSurface Surface { get; }
    }
}