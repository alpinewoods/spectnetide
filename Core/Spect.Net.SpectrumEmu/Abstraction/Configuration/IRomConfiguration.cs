﻿namespace Spect.Net.SpectrumEmu.Abstraction.Configuration
{
    /// <summary>
    /// This interface defines the configuration data for the ROM
    /// </summary>
    public interface IRomConfiguration: IDeviceConfiguration
    {
        /// <summary>
        /// The number of ROM banks
        /// </summary>
        int NumberOfRoms { get; } 
    }
}