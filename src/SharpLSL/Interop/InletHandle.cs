#pragma warning disable CS1591
using System;

using Microsoft.Win32.SafeHandles;

namespace SharpLSL.Interop
{
    public sealed class InletHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        public InletHandle(bool ownsHandle)
            : base(ownsHandle)
        {
        }

        public InletHandle(IntPtr handle, bool ownsHandle)
            : base(ownsHandle)
        {
            SetHandle(handle);
        }

        protected override bool ReleaseHandle()
        {
            LSL.lsl_destroy_inlet(handle);
            return true;
        }
    }
}
