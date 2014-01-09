﻿namespace SoundFingerprinting.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [DeploymentItem(@"x86", @"x86")]
    [DeploymentItem(@"x64", @"x64")]
    [DeploymentItem(@"libfftw3-3.dll")]
    [DeploymentItem(@"libfftw3f-3.dll")]
    [DeploymentItem(@"libfftw3l-3.dll")]
    [TestClass]
    public abstract class AbstractTest
    {
        protected const double Epsilon = 0.0001;

        protected const int BitsPerSample = 32;
        
        protected const int SampleRate = 5512;

        protected const int SamplesPerFingerprint = 128 * 64;

        protected const int WaveHeader = 58;

        protected const string PathToMp3 = @"Kryptonite.mp3";

        protected const string PathToSamples = @"floatsamples.bin";

        protected const int SamplesToRead = 128 * 64;

        protected const int MinYear = 1501;

        protected readonly bool[] GenericFingerprint = new[]
            {
                true, false, true, false, true, false, true, false, true, false, true, false, false, true, false, true,
                false, true, false, true, false, true, false, true, true, false, true, false, true, false, true, false,
                true, false, true, false, false, true, false, true, false, true, false, true, false, true, false, true,
                true, false, true, false, true, false, true, false, true, false, true, false, false, true, false, true,
                false, true, false, true, false, true, false, true, true, false, true, false, true, false, true, false,
                true, false, true, false, false, true, false, true, false, true, false, true, false, true, false, true,
                true, false, true, false, true, false, true, false, true, false, true, false, false, true, false, true,
                false, true, false, true, false, true, false, true
            };

        protected readonly byte[] GenericSignature = new[]
                                                         {
                                                             (byte)1, (byte)2, (byte)3, (byte)4, (byte)5, (byte)6, (byte)7, (byte)8, (byte)9, (byte)10, (byte)11, (byte)12,
                                                             (byte)13, (byte)14, (byte)15, (byte)16, (byte)17, (byte)18, (byte)19, (byte)20, (byte)21, (byte)22, (byte)23,
                                                             (byte)24, (byte)25
                                                         };
    }
}
