// <copyright file="StartupHandler.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;
using MonoDevelop.Components.Commands;

namespace Drastic.RemoteAppViewer.VSMac
{
    /// <summary>
    /// Startup Handler.
    /// </summary>
    public class StartupHandler : CommandHandler
    {
        /// <inheritdoc/>
        protected override void Run()
        {
            Drastic.UI.Application.Current = new UI.Application();
            Drastic.UI.Application.Current.Resources = new UI.ResourceDictionary();
        }
    }
}