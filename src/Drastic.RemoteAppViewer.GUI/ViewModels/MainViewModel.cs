// <copyright file="MainViewModel.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;
using System.Collections.ObjectModel;

namespace Drastic.RemoteAppViewer.GUI.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private IMonitorEnumeration monitors;
        private IWindowEnumeration windows;

        public MainViewModel(IMonitorEnumeration monitors, IWindowEnumeration windows, IErrorHandlerService errorHandler, IAppDispatcher dispatcher)
            : base(errorHandler, dispatcher)
        {
            this.monitors = monitors;
            this.windows = windows;
            this.EnumerateMonitorsCommand = new AsyncCommand(this.EnumerateMonitorsAsync, null, this.Dispatcher, this.ErrorHandler);
            this.EnumerateAppWindowsCommand = new AsyncCommand(this.EnumerateAppWindowsAsync, null, this.Dispatcher, this.ErrorHandler);
        }

        public AsyncCommand EnumerateMonitorsCommand { get; }

        public AsyncCommand EnumerateAppWindowsCommand { get; }

        public ObservableCollection<ISurface> Surfaces { get; } = new ObservableCollection<ISurface>();

        public async Task EnumerateMonitorsAsync()
        {
            this.Surfaces.Clear();
            var monitorList = await this.monitors.GetMonitorsAsync();
            foreach (var monitor in monitorList)
            {
                this.Surfaces.Add(monitor);
            }
        }

        public async Task EnumerateAppWindowsAsync()
        {
            this.Surfaces.Clear();
            var appList = await this.windows.GetWindowsAsync();
            foreach (var app in appList)
            {
                this.Surfaces.Add(app);
            }
        }
    }
}