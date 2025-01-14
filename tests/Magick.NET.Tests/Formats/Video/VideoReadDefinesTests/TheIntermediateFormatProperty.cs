﻿// Copyright Dirk Lemstra https://github.com/dlemstra/Magick.NET.
// Licensed under the Apache License, Version 2.0.

using ImageMagick;
using ImageMagick.Formats;
using Xunit;

namespace Magick.NET.Tests
{
    public partial class VideoReadDefinesTests
    {
        public class TheIntermediateFormatProperty
        {
            [Fact]
            public void ShouldSetTheDefineWhenValueIsSet()
            {
                using (var image = new MagickImage(MagickColors.Magenta, 1, 1))
                {
                    image.Settings.SetDefines(new VideoReadDefines(MagickFormat.Mp4)
                    {
                        IntermediateFormat = IntermediateFormat.Pam,
                    });

                    Assert.Equal("pam", image.Settings.GetDefine("video:intermediate-format"));
                }
            }

            [Fact]
            public void ShouldNotSetTheDefineWhenValueIsNotSet()
            {
                using (var image = new MagickImage())
                {
                    image.Settings.SetDefines(new VideoReadDefines(MagickFormat.Mp4)
                    {
                        IntermediateFormat = null,
                    });

                    Assert.Null(image.Settings.GetDefine("video:intermediate-format"));
                }
            }
        }
    }
}
