﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AntlrZ80Asm.Test.Assembler
{
    [TestClass]
    public class LoadOperationEmitTests : AssemblerTestBed
    {
        [TestMethod]
        public void Reg8ToReg8LoadOpsWorkAsExpected()
        {
            CodeEmitWorks("ld b,b", 0x40);
            CodeEmitWorks("ld b,c", 0x41);
            CodeEmitWorks("ld b,d", 0x42);
            CodeEmitWorks("ld b,e", 0x43);
            CodeEmitWorks("ld b,h", 0x44);
            CodeEmitWorks("ld b,l", 0x45);
            CodeEmitWorks("ld b,(hl)", 0x46);
            CodeEmitWorks("ld b,a", 0x47);

            CodeEmitWorks("ld c,b", 0x48);
            CodeEmitWorks("ld c,c", 0x49);
            CodeEmitWorks("ld c,d", 0x4A);
            CodeEmitWorks("ld c,e", 0x4B);
            CodeEmitWorks("ld c,h", 0x4C);
            CodeEmitWorks("ld c,l", 0x4D);
            CodeEmitWorks("ld c,(hl)", 0x4E);
            CodeEmitWorks("ld c,a", 0x4F);

            CodeEmitWorks("ld d,b", 0x50);
            CodeEmitWorks("ld d,c", 0x51);
            CodeEmitWorks("ld d,d", 0x52);
            CodeEmitWorks("ld d,e", 0x53);
            CodeEmitWorks("ld d,h", 0x54);
            CodeEmitWorks("ld d,l", 0x55);
            CodeEmitWorks("ld d,(hl)", 0x56);
            CodeEmitWorks("ld d,a", 0x57);

            CodeEmitWorks("ld e,b", 0x58);
            CodeEmitWorks("ld e,c", 0x59);
            CodeEmitWorks("ld e,d", 0x5A);
            CodeEmitWorks("ld e,e", 0x5B);
            CodeEmitWorks("ld e,h", 0x5C);
            CodeEmitWorks("ld e,l", 0x5D);
            CodeEmitWorks("ld e,(hl)", 0x5E);
            CodeEmitWorks("ld e,a", 0x5F);

            CodeEmitWorks("ld h,b", 0x60);
            CodeEmitWorks("ld h,c", 0x61);
            CodeEmitWorks("ld h,d", 0x62);
            CodeEmitWorks("ld h,e", 0x63);
            CodeEmitWorks("ld h,h", 0x64);
            CodeEmitWorks("ld h,l", 0x65);
            CodeEmitWorks("ld h,(hl)", 0x66);
            CodeEmitWorks("ld h,a", 0x67);

            CodeEmitWorks("ld l,b", 0x68);
            CodeEmitWorks("ld l,c", 0x69);
            CodeEmitWorks("ld l,d", 0x6A);
            CodeEmitWorks("ld l,e", 0x6B);
            CodeEmitWorks("ld l,h", 0x6C);
            CodeEmitWorks("ld l,l", 0x6D);
            CodeEmitWorks("ld l,(hl)", 0x6E);
            CodeEmitWorks("ld l,a", 0x6F);

            CodeEmitWorks("ld (hl),b", 0x70);
            CodeEmitWorks("ld (hl),c", 0x71);
            CodeEmitWorks("ld (hl),d", 0x72);
            CodeEmitWorks("ld (hl),e", 0x73);
            CodeEmitWorks("ld (hl),h", 0x74);
            CodeEmitWorks("ld (hl),l", 0x75);
            CodeEmitWorks("ld (hl),a", 0x77);

            CodeEmitWorks("ld a,b", 0x78);
            CodeEmitWorks("ld a,c", 0x79);
            CodeEmitWorks("ld a,d", 0x7A);
            CodeEmitWorks("ld a,e", 0x7B);
            CodeEmitWorks("ld a,h", 0x7C);
            CodeEmitWorks("ld a,l", 0x7D);
            CodeEmitWorks("ld a,(hl)", 0x7E);
            CodeEmitWorks("ld a,a", 0x7F);
        }

        [TestMethod]
        public void SpecReg8LoadOpsWorkAsExpected()
        {
            CodeEmitWorks("ld i,a", 0xED, 0x47);
            CodeEmitWorks("ld r,a", 0xED, 0x4F);
            CodeEmitWorks("ld a,i", 0xED, 0x57);
            CodeEmitWorks("ld a,r", 0xED, 0x5F);

            CodeEmitWorks("ld xh,b", 0xDD, 0x60);
            CodeEmitWorks("ld xh,c", 0xDD, 0x61);
            CodeEmitWorks("ld xh,d", 0xDD, 0x62);
            CodeEmitWorks("ld xh,e", 0xDD, 0x63);
            CodeEmitWorks("ld xh,xh", 0xDD, 0x64);
            CodeEmitWorks("ld xh,xl", 0xDD, 0x65);
            CodeEmitWorks("ld xh,a", 0xDD, 0x67);

            CodeEmitWorks("ld xl,b", 0xDD, 0x68);
            CodeEmitWorks("ld xl,c", 0xDD, 0x69);
            CodeEmitWorks("ld xl,d", 0xDD, 0x6A);
            CodeEmitWorks("ld xl,e", 0xDD, 0x6B);
            CodeEmitWorks("ld xl,xh", 0xDD, 0x6C);
            CodeEmitWorks("ld xl,xl", 0xDD, 0x6D);
            CodeEmitWorks("ld xl,a", 0xDD, 0x6F);

            CodeEmitWorks("ld yh,b", 0xFD, 0x60);
            CodeEmitWorks("ld yh,c", 0xFD, 0x61);
            CodeEmitWorks("ld yh,d", 0xFD, 0x62);
            CodeEmitWorks("ld yh,e", 0xFD, 0x63);
            CodeEmitWorks("ld yh,yh", 0xFD, 0x64);
            CodeEmitWorks("ld yh,yl", 0xFD, 0x65);
            CodeEmitWorks("ld yh,a", 0xFD, 0x67);

            CodeEmitWorks("ld yl,b", 0xFD, 0x68);
            CodeEmitWorks("ld yl,c", 0xFD, 0x69);
            CodeEmitWorks("ld yl,d", 0xFD, 0x6A);
            CodeEmitWorks("ld yl,e", 0xFD, 0x6B);
            CodeEmitWorks("ld yl,yh", 0xFD, 0x6C);
            CodeEmitWorks("ld yl,yl", 0xFD, 0x6D);
            CodeEmitWorks("ld yl,a", 0xFD, 0x6F);

            CodeEmitWorks("ld b,xh", 0xDD, 0x44);
            CodeEmitWorks("ld c,xh", 0xDD, 0x4C);
            CodeEmitWorks("ld d,xh", 0xDD, 0x54);
            CodeEmitWorks("ld e,xh", 0xDD, 0x5C);
            CodeEmitWorks("ld a,xh", 0xDD, 0x7C);

            CodeEmitWorks("ld b,xl", 0xDD, 0x45);
            CodeEmitWorks("ld c,xl", 0xDD, 0x4D);
            CodeEmitWorks("ld d,xl", 0xDD, 0x55);
            CodeEmitWorks("ld e,xl", 0xDD, 0x5D);
            CodeEmitWorks("ld a,xl", 0xDD, 0x7D);

            CodeEmitWorks("ld b,yh", 0xFD, 0x44);
            CodeEmitWorks("ld c,yh", 0xFD, 0x4C);
            CodeEmitWorks("ld d,yh", 0xFD, 0x54);
            CodeEmitWorks("ld e,yh", 0xFD, 0x5C);
            CodeEmitWorks("ld a,yh", 0xFD, 0x7C);

            CodeEmitWorks("ld b,yl", 0xFD, 0x45);
            CodeEmitWorks("ld c,yl", 0xFD, 0x4D);
            CodeEmitWorks("ld d,yl", 0xFD, 0x55);
            CodeEmitWorks("ld e,yl", 0xFD, 0x5D);
            CodeEmitWorks("ld a,yl", 0xFD, 0x7D);
        }

        [TestMethod]
        public void SpLoadOpsWorkAsExpected()
        {
            CodeEmitWorks("ld sp,hl", 0xF9);
            CodeEmitWorks("ld sp,ix", 0xDD, 0xF9);
            CodeEmitWorks("ld sp,iy", 0xFD, 0xF9);
        }

        [TestMethod]
        public void ValueToReg8LoadOpsWorkAsExpected()
        {
            CodeEmitWorks("ld b,48+#0A", 0x06, 0x3A);
            CodeEmitWorks("ld c,48+#0A", 0x0E, 0x3A);
            CodeEmitWorks("ld d,48+#0A", 0x16, 0x3A);
            CodeEmitWorks("ld e,48+#0A", 0x1E, 0x3A);
            CodeEmitWorks("ld h,48+#0A", 0x26, 0x3A);
            CodeEmitWorks("ld l,48+#0A", 0x2E, 0x3A);
            CodeEmitWorks("ld (hl),48+#0A", 0x36, 0x3A);
            CodeEmitWorks("ld a,48+#0A", 0x3E, 0x3A);

            CodeEmitWorks("ld xh,48+#0A", 0xDD, 0x26, 0x3A);
            CodeEmitWorks("ld xl,48+#0A", 0xDD, 0x2E, 0x3A);
            CodeEmitWorks("ld yh,48+#0A", 0xFD, 0x26, 0x3A);
            CodeEmitWorks("ld yl,48+#0A", 0xFD, 0x2E, 0x3A);
        }

        [TestMethod]
        public void ValueToReg16LoadOpsWorkAsExpected()
        {
            CodeEmitWorks("ld bc,#1000*2+#34", 0x01, 0x34, 0x20);
            CodeEmitWorks("ld de,#1000*2+#34", 0x11, 0x34, 0x20);
            CodeEmitWorks("ld hl,#1000*2+#34", 0x21, 0x34, 0x20);
            CodeEmitWorks("ld sp,#1000*2+#34", 0x31, 0x34, 0x20);
            CodeEmitWorks("ld ix,#1000*2+#34", 0xDD, 0x21, 0x34, 0x20);
            CodeEmitWorks("ld iy,#1000*2+#34", 0xFd, 0x21, 0x34, 0x20);
        }

        [TestMethod]
        public void Reg16IndirectToALoadOpsWorkAsExpected()
        {
            CodeEmitWorks("ld a,(bc)", 0x0A);
            CodeEmitWorks("ld a,(de)", 0x1A);
        }

        [TestMethod]
        public void AToReg16IndirectLoadOpsWorkAsExpected()
        {
            CodeEmitWorks("ld (bc),a", 0x02);
            CodeEmitWorks("ld (de),a", 0x12);
        }

        [TestMethod]
        public void AddressIndirectToRegLoadOpsWorkAsExpected()
        {
            CodeEmitWorks("ld a,(#4000)", 0x3A, 0x00, 0x40);
            CodeEmitWorks("ld bc,(#4000+32)", 0xED, 0x4B, 0x20, 0x40);
            CodeEmitWorks("ld de,(#4000+32)", 0xED, 0x5B, 0x20, 0x40);
            CodeEmitWorks("ld hl,(#4000+32)", 0x2A, 0x20, 0x40);
            CodeEmitWorks("ld sp,(#4000+32)", 0xED, 0x7B, 0x20, 0x40);
            CodeEmitWorks("ld ix,(#4000+32)", 0xDD, 0x2A, 0x20, 0x40);
            CodeEmitWorks("ld iy,(#4000+32)", 0xFD, 0x2A, 0x20, 0x40);
        }

        [TestMethod]
        public void RegToAddressIndirectLoadOpsWorkAsExpected()
        {
            CodeEmitWorks("ld (#4000),a", 0x32, 0x00, 0x40);
            CodeEmitWorks("ld (#4000+32),bc", 0xED, 0x43, 0x20, 0x40);
            CodeEmitWorks("ld (#4000+32),de", 0xED, 0x53, 0x20, 0x40);
            CodeEmitWorks("ld (#4000+32),hl", 0x22, 0x20, 0x40);
            CodeEmitWorks("ld (#4000+32),sp", 0xED, 0x73, 0x20, 0x40);
            CodeEmitWorks("ld (#4000+32),ix", 0xDD, 0x22, 0x20, 0x40);
            CodeEmitWorks("ld (#4000+32),iy", 0xFD, 0x22, 0x20, 0x40);
        }

        [TestMethod]
        public void IxIndexedAddressToReg8LoadOpsWorkAsExpected()
        {
            CodeEmitWorks("ld b,(ix)", 0xDD, 0x46, 0x00);
            CodeEmitWorks("ld b,(ix+8)", 0xDD, 0x46, 0x08);
            CodeEmitWorks("ld b,(ix-6)", 0xDD, 0x46, 0xFA);
            CodeEmitWorks("ld c,(ix)", 0xDD, 0x4E, 0x00);
            CodeEmitWorks("ld c,(ix+8)", 0xDD, 0x4E, 0x08);
            CodeEmitWorks("ld c,(ix-6)", 0xDD, 0x4E, 0xFA);
            CodeEmitWorks("ld d,(ix)", 0xDD, 0x56, 0x00);
            CodeEmitWorks("ld d,(ix+8)", 0xDD, 0x56, 0x08);
            CodeEmitWorks("ld d,(ix-6)", 0xDD, 0x56, 0xFA);
            CodeEmitWorks("ld e,(ix)", 0xDD, 0x5E, 0x00);
            CodeEmitWorks("ld e,(ix+8)", 0xDD, 0x5E, 0x08);
            CodeEmitWorks("ld e,(ix-6)", 0xDD, 0x5E, 0xFA);
            CodeEmitWorks("ld h,(ix)", 0xDD, 0x66, 0x00);
            CodeEmitWorks("ld h,(ix+8)", 0xDD, 0x66, 0x08);
            CodeEmitWorks("ld h,(ix-6)", 0xDD, 0x66, 0xFA);
            CodeEmitWorks("ld l,(ix)", 0xDD, 0x6E, 0x00);
            CodeEmitWorks("ld l,(ix+8)", 0xDD, 0x6E, 0x08);
            CodeEmitWorks("ld l,(ix-6)", 0xDD, 0x6E, 0xFA);
            CodeEmitWorks("ld a,(ix)", 0xDD, 0x7E, 0x00);
            CodeEmitWorks("ld a,(ix+8)", 0xDD, 0x7E, 0x08);
            CodeEmitWorks("ld a,(ix-6)", 0xDD, 0x7E, 0xFA);
        }

        [TestMethod]
        public void IyIndexedAddressToReg8LoadOpsWorkAsExpected()
        {
            CodeEmitWorks("ld b,(iy)", 0xFD, 0x46, 0x00);
            CodeEmitWorks("ld b,(iy+8)", 0xFD, 0x46, 0x08);
            CodeEmitWorks("ld b,(iy-6)", 0xFD, 0x46, 0xFA);
            CodeEmitWorks("ld c,(iy)", 0xFD, 0x4E, 0x00);
            CodeEmitWorks("ld c,(iy+8)", 0xFD, 0x4E, 0x08);
            CodeEmitWorks("ld c,(iy-6)", 0xFD, 0x4E, 0xFA);
            CodeEmitWorks("ld d,(iy)", 0xFD, 0x56, 0x00);
            CodeEmitWorks("ld d,(iy+8)", 0xFD, 0x56, 0x08);
            CodeEmitWorks("ld d,(iy-6)", 0xFD, 0x56, 0xFA);
            CodeEmitWorks("ld e,(iy)", 0xFD, 0x5E, 0x00);
            CodeEmitWorks("ld e,(iy+8)", 0xFD, 0x5E, 0x08);
            CodeEmitWorks("ld e,(iy-6)", 0xFD, 0x5E, 0xFA);
            CodeEmitWorks("ld h,(iy)", 0xFD, 0x66, 0x00);
            CodeEmitWorks("ld h,(iy+8)", 0xFD, 0x66, 0x08);
            CodeEmitWorks("ld h,(iy-6)", 0xFD, 0x66, 0xFA);
            CodeEmitWorks("ld l,(iy)", 0xFD, 0x6E, 0x00);
            CodeEmitWorks("ld l,(iy+8)", 0xFD, 0x6E, 0x08);
            CodeEmitWorks("ld l,(iy-6)", 0xFD, 0x6E, 0xFA);
            CodeEmitWorks("ld a,(iy)", 0xFD, 0x7E, 0x00);
            CodeEmitWorks("ld a,(iy+8)", 0xFD, 0x7E, 0x08);
            CodeEmitWorks("ld a,(iy-6)", 0xFD, 0x7E, 0xFA);
        }

        [TestMethod]
        public void Reg8ToIxIndexedAddressLoadOpsWorkAsExpected()
        {
            CodeEmitWorks("ld (ix),b", 0xDD, 0x70, 0x00);
            CodeEmitWorks("ld (ix+8),b", 0xDD, 0x70, 0x08);
            CodeEmitWorks("ld (ix-6),b", 0xDD, 0x70, 0xFA);
            CodeEmitWorks("ld (ix),c", 0xDD, 0x71, 0x00);
            CodeEmitWorks("ld (ix+8),c", 0xDD, 0x71, 0x08);
            CodeEmitWorks("ld (ix-6),c", 0xDD, 0x71, 0xFA);
            CodeEmitWorks("ld (ix),d", 0xDD, 0x72, 0x00);
            CodeEmitWorks("ld (ix+8),d", 0xDD, 0x72, 0x08);
            CodeEmitWorks("ld (ix-6),d", 0xDD, 0x72, 0xFA);
            CodeEmitWorks("ld (ix),e", 0xDD, 0x73, 0x00);
            CodeEmitWorks("ld (ix+8),e", 0xDD, 0x73, 0x08);
            CodeEmitWorks("ld (ix-6),e", 0xDD, 0x73, 0xFA);
            CodeEmitWorks("ld (ix),h", 0xDD, 0x74, 0x00);
            CodeEmitWorks("ld (ix+8),h", 0xDD, 0x74, 0x08);
            CodeEmitWorks("ld (ix-6),h", 0xDD, 0x74, 0xFA);
            CodeEmitWorks("ld (ix),l", 0xDD, 0x75, 0x00);
            CodeEmitWorks("ld (ix+8),l", 0xDD, 0x75, 0x08);
            CodeEmitWorks("ld (ix-6),l", 0xDD, 0x75, 0xFA);
            CodeEmitWorks("ld (ix),a", 0xDD, 0x77, 0x00);
            CodeEmitWorks("ld (ix+8),a", 0xDD, 0x77, 0x08);
            CodeEmitWorks("ld (ix-6),a", 0xDD, 0x77, 0xFA);
        }

        [TestMethod]
        public void Reg8ToIyIndexedAddressLoadOpsWorkAsExpected()
        {
            CodeEmitWorks("ld (iy),b", 0xFD, 0x70, 0x00);
            CodeEmitWorks("ld (iy+8),b", 0xFD, 0x70, 0x08);
            CodeEmitWorks("ld (iy-6),b", 0xFD, 0x70, 0xFA);
            CodeEmitWorks("ld (iy),c", 0xFD, 0x71, 0x00);
            CodeEmitWorks("ld (iy+8),c", 0xFD, 0x71, 0x08);
            CodeEmitWorks("ld (iy-6),c", 0xFD, 0x71, 0xFA);
            CodeEmitWorks("ld (iy),d", 0xFD, 0x72, 0x00);
            CodeEmitWorks("ld (iy+8),d", 0xFD, 0x72, 0x08);
            CodeEmitWorks("ld (iy-6),d", 0xFD, 0x72, 0xFA);
            CodeEmitWorks("ld (iy),e", 0xFD, 0x73, 0x00);
            CodeEmitWorks("ld (iy+8),e", 0xFD, 0x73, 0x08);
            CodeEmitWorks("ld (iy-6),e", 0xFD, 0x73, 0xFA);
            CodeEmitWorks("ld (iy),h", 0xFD, 0x74, 0x00);
            CodeEmitWorks("ld (iy+8),h", 0xFD, 0x74, 0x08);
            CodeEmitWorks("ld (iy-6),h", 0xFD, 0x74, 0xFA);
            CodeEmitWorks("ld (iy),l", 0xFD, 0x75, 0x00);
            CodeEmitWorks("ld (iy+8),l", 0xFD, 0x75, 0x08);
            CodeEmitWorks("ld (iy-6),l", 0xFD, 0x75, 0xFA);
            CodeEmitWorks("ld (iy),a", 0xFD, 0x77, 0x00);
            CodeEmitWorks("ld (iy+8),a", 0xFD, 0x77, 0x08);
            CodeEmitWorks("ld (iy-6),a", 0xFD, 0x77, 0xFA);
        }

        [TestMethod]
        public void ValueToIndexedAddressLoadOpsWorkAsExpected()
        {
            CodeEmitWorks("ld (ix),#23", 0xDD, 0x36, 0x00, 0x23);
            CodeEmitWorks("ld (ix+8),#23", 0xDD, 0x36, 0x08, 0x23);
            CodeEmitWorks("ld (ix-6),#23", 0xDD, 0x36, 0xFA, 0x23);
            CodeEmitWorks("ld (iy),#23", 0xFD, 0x36, 0x00, 0x23);
            CodeEmitWorks("ld (iy+8),#23", 0xFD, 0x36, 0x08, 0x23);
            CodeEmitWorks("ld (iy-6),#23", 0xFD, 0x36, 0xFA, 0x23);
        }

        [TestMethod]
        public void InvalidLoadOpsRaiseError()
        {
            CodeRaisesInvalidArgument("ld (hl),(hl)");

            CodeRaisesInvalidArgument("ld xh,h");
            CodeRaisesInvalidArgument("ld xh,l");
            CodeRaisesInvalidArgument("ld xh,(hl)");
            CodeRaisesInvalidArgument("ld xl,h");
            CodeRaisesInvalidArgument("ld xl,l");
            CodeRaisesInvalidArgument("ld xl,(hl)");

            CodeRaisesInvalidArgument("ld yh,h");
            CodeRaisesInvalidArgument("ld yh,l");
            CodeRaisesInvalidArgument("ld yh,(hl)");
            CodeRaisesInvalidArgument("ld yl,h");
            CodeRaisesInvalidArgument("ld yl,l");
            CodeRaisesInvalidArgument("ld yl,(hl)");

            CodeRaisesInvalidArgument("ld xh,yh");
            CodeRaisesInvalidArgument("ld xh,yl");
            CodeRaisesInvalidArgument("ld yh,xh");
            CodeRaisesInvalidArgument("ld yh,xl");

            CodeRaisesInvalidArgument("ld h,xh");
            CodeRaisesInvalidArgument("ld l,xh");
            CodeRaisesInvalidArgument("ld (hl),xh");
            CodeRaisesInvalidArgument("ld h,xl");
            CodeRaisesInvalidArgument("ld l,xl");
            CodeRaisesInvalidArgument("ld (hl),xl");

            CodeRaisesInvalidArgument("ld h,yh");
            CodeRaisesInvalidArgument("ld l,yh");
            CodeRaisesInvalidArgument("ld (hl),yh");
            CodeRaisesInvalidArgument("ld h,yl");
            CodeRaisesInvalidArgument("ld l,yl");
            CodeRaisesInvalidArgument("ld (hl),yl");
        }
    }
}