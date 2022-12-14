// <copyright file="IAppDispatcher.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;

namespace Drastic.RemoteAppViewer.GUI
{
    public interface IAppDispatcher
    {
        bool Dispatch(Action action);
    }
}