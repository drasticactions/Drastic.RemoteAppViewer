// <copyright file="IMonitorCaptureSurface.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;

namespace Drastic.RemoteAppViewer
{
    /// <summary>
    /// Monitor Capture Surface.
    /// </summary>
    public interface IMonitorCaptureSurface
    {
        /// <summary>
        /// Gets the <see cref="IMonitor"/>.
        /// </summary>
        IMonitor Monitor { get; }

        /// <summary>
        /// Gets the <see cref="ICaptureSurface"/>.
        /// </summary>
        ICaptureSurface Surface { get; }
    }
}