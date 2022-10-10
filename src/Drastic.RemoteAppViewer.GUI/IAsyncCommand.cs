// <copyright file="IAsyncCommand.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;
using System.Windows.Input;

namespace Drastic.RemoteAppViewer.GUI
{
    /// <summary>
    /// IAsyncCommand.
    /// </summary>
    public interface IAsyncCommand : ICommand
    {
        /// <summary>
        /// Execute Async.
        /// </summary>
        /// <returns><see cref="Task"/>.</returns>
        Task ExecuteAsync();

        /// <summary>
        /// Can execute Command.
        /// </summary>
        /// <returns>Boolean.</returns>
        bool CanExecute();
    }
}