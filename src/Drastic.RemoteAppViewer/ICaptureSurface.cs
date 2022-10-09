// <copyright file="ICaptureSurface.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;

namespace Drastic.RemoteAppViewer
{
    /// <summary>
    /// Capture Surface.
    /// Represents the raw surface on the given platform.
    /// Ex. IOSurface on Mac.
    /// </summary>
    public interface ICaptureSurface
    {
        /// <summary>
        /// Gets the raw surface object.
        /// Can be cast into the actual object.
        /// </summary>
        object RawSurface { get; }

        /// <summary>
        /// Gets the title of the surface.
        /// </summary>
        string Title { get; }
    }
}