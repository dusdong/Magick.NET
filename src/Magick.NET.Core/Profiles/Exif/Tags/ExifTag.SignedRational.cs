﻿// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.

namespace ImageMagick
{
    /// <content/>
    public abstract partial class ExifTag
    {
        /// <summary>
        /// Gets the ShutterSpeedValue exif tag.
        /// </summary>
        public static ExifTag<SignedRational> ShutterSpeedValue { get; } = new ExifTag<SignedRational>(ExifTagValue.ShutterSpeedValue);

        /// <summary>
        /// Gets the BrightnessValue exif tag.
        /// </summary>
        public static ExifTag<SignedRational> BrightnessValue { get; } = new ExifTag<SignedRational>(ExifTagValue.BrightnessValue);

        /// <summary>
        /// Gets the ExposureBiasValue exif tag.
        /// </summary>
        public static ExifTag<SignedRational> ExposureBiasValue { get; } = new ExifTag<SignedRational>(ExifTagValue.ExposureBiasValue);

        /// <summary>
        /// Gets the AmbientTemperature exif tag.
        /// </summary>
        public static ExifTag<SignedRational> AmbientTemperature { get; } = new ExifTag<SignedRational>(ExifTagValue.AmbientTemperature);

        /// <summary>
        /// Gets the WaterDepth exif tag.
        /// </summary>
        public static ExifTag<SignedRational> WaterDepth { get; } = new ExifTag<SignedRational>(ExifTagValue.WaterDepth);

        /// <summary>
        /// Gets the CameraElevationAngle exif tag.
        /// </summary>
        public static ExifTag<SignedRational> CameraElevationAngle { get; } = new ExifTag<SignedRational>(ExifTagValue.CameraElevationAngle);
    }
}
