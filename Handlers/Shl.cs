﻿using dnlib.DotNet.Emit;


namespace ArEmulator.Models.Handlers
{
    public class Shl : Handler
    {
        public override OpCode Type => OpCodes.Shl;

        public override void Handle(ARVM VM, ARVMInstruction instruction)
        {
            object a = VM.vmStack.Pop();
            object b = VM.vmStack.Pop();

            VM.vmStack.Push((int)b << (int)a);

            VM.ind++;
        }
    }
}
