﻿namespace LibGit2Sharp.Core.Handles
{
    internal class NoteSafeHandle : SafeHandleBase
    {
        protected override bool ReleaseHandle()
        {
            NativeMethods.git_note_free(handle);
            return true;
        }
    }
}
