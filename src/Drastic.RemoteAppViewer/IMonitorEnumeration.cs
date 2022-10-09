// <copyright file="IMonitorEnumeration.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;

namespace Drastic.RemoteAppViewer
{
    /// <summary>
    /// Monitor Enumeration.
    /// </summary>
    public interface IMonitorEnumeration
    {
        /// <summary>
        /// Gets the list of monitors.
        /// </summary>
        /// <returns>List of <see cref="IMonitor"/>.</returns>
        IReadOnlyList<IMonitor> GetMonitors();

        /// <summary>
        /// Gets the list of monitors, async.
        /// </summary>
        /// <returns>List of <see cref="IMonitor"/>.</returns>
        Task<IReadOnlyList<IMonitor>> GetMonitorsAsync();
    }
}