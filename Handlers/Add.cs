﻿using dnlib.DotNet.Emit;

namespace ArEmulator.Models.Handlers
{
    public class Add : Handler
    {
        public override OpCode Type => OpCodes.Add;

        public override void Handle(ARVM VM, ARVMInstruction instruction)
        {
            object a = VM.vmStack.Pop();
            object b = VM.vmStack.Pop();

            VM.vmStack.Push((int)b + (int)a);

            VM.ind++;
        }
    }
}
