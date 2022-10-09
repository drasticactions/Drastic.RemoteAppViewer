﻿// <copyright file="CapturedFrame.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;
using CoreImage;
using CoreMedia;
using CoreVideo;

namespace Drastic.RemoteAppViewer.Mac
{
    /// <summary>
    /// Captured Frame.
    /// </summary>
    public class CapturedFrame : ICapturedFrame
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CapturedFrame"/> class.
        /// </summary>
        /// <param name="sample"><see cref="CMSampleBuffer"/>.</param>
        public CapturedFrame(CMSampleBuffer sample)
        {
            this.SampleBuffer = sample;
            var attachments = sample.GetAttachments(CMAttachmentMode.ShouldPropagate);

            using var imageBuffer = this.SampleBuffer.GetImageBuffer() as CVPixelBuffer;
            if (imageBuffer is not null)
            {
                this.Width = (int)imageBuffer.Width;
                this.Height = (int)imageBuffer.Height;
                this.Surface = imageBuffer.GetIOSurface();
                this.CIImage = new CIImage(imageBuffer);
            }
        }

        /// <inheritdoc/>
        public object Raw => this.CIImage ?? throw new NullReferenceException();

        public CMSampleBuffer SampleBuffer { get; }

        public IOSurface.IOSurface? Surface { get; }

        public CIImage? CIImage { get; }

        public CGRect? ContentRect { get; }

        public double ContentScale { get; }

        public double ScaleFactor { get; }

        /// <inheritdoc/>
        public int Width { get; }

        /// <inheritdoc/>
        public int Height { get; }

        /// <inheritdoc/>
        public byte[] ImageData => throw new NotImplementedException();
    }
}
