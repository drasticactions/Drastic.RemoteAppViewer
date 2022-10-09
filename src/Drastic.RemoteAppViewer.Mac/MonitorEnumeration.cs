// <copyright file="MonitorEnumeration.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;
using ScreenCaptureKit;

namespace Drastic.RemoteAppViewer.Mac
{
    public class MonitorEnumeration : IMonitorEnumeration
    {
        /// <inheritdoc/>
        public IReadOnlyList<IMonitor> GetMonitors() => this.GetMonitorsAsync().Result;

        /// <inheritdoc/>
        public async Task<IReadOnlyList<IMonitor>> GetMonitorsAsync()
        {
            var list = new List<MonitorInfo>();
            var result = await SCShareableContent.GetShareableContentAsync(true, false);
            foreach (var item in result.Displays)
            {
                list.Add(new MonitorInfo(item));
            }

            return list;
        }
    }
}
