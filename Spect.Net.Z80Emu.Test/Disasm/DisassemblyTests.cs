﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spect.Net.Spectrum.Utilities;
using Spect.Net.Z80Emu.Disasm;
using Spect.Net.Z80Emu.Test.Helpers;

// ReSharper disable InconsistentNaming

namespace Spect.Net.Z80Emu.Test.Disasm
{
    [TestClass]
    public class DisassemblyTests
    {
        private static byte[] s_Spectrum48Rom;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            s_Spectrum48Rom = RomHelper.ExtractResourceFile("ZXSpectrum48.rom");
        }

        [TestMethod]
        public void DisassemblerWorks()
        {
            // --- Arrange
            var project = new Z80DisAsmProject
            {
                Z80Binary = s_Spectrum48Rom
            };
            var disasm = new Z80Disassembler(project);

            // --- Act
            var output = disasm.Disassemble(0, 1000);
            foreach (var item in output.OutputItems)
            {
                Console.WriteLine(item);
            }
        }
    }
}
