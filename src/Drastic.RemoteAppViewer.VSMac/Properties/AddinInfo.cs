// <copyright file="AddinInfo.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using Mono.Addins;
using Mono.Addins.Description;

[assembly: Addin(
    "RemoteAppViewer",
    Namespace = "Drastic",
    Version = "99.0"
)]

[assembly: AddinName("Drastic Remote App Viewer")]
[assembly: AddinCategory("Mobile Development")]
[assembly: AddinDescription("Remote App Viewer")]
[assembly: AddinAuthor("Drastic Actions")]

static class VsBuildInfo
{
    // This is the minimum version of VS Mac that we require..
    public const string Version = MonoDevelop.BuildInfo.Version;
}