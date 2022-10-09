// <copyright file="IWindowEnumeration.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;

namespace Drastic.RemoteAppViewer
{
    /// <summary>
    /// Window Enumeration.
    /// </summary>
    public interface IWindowEnumeration
    {
        /// <summary>
        /// Gets the list of windows on the given platform.
        /// </summary>
        /// <returns>List of <see cref="IWindow"/>.</returns>
        IReadOnlyList<IWindow> GetWindows();

        /// <summary>
        /// Gets the list of windows on the given platform, async.
        /// </summary>
        /// <returns>List of <see cref="IWindow"/>.</returns>
        Task<IReadOnlyList<IWindow>> GetWindowsAsync();
    }
}