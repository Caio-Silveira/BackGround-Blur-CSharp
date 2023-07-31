namespace Example
{
    public static class Blur
    {
        public static void SetBlur(IntPtr handle)
        {
            var accent = new W_APIs.ACCENTPOLICY
            {
                nAccentState = 3,
                nFlags = 2,
                nColor = unchecked((int)0x88000000), // A cor de desfoque (blur) é definida aqui (use 0xRRGGBB)
                nAnimationId = 0
            };

            var accentStructSize = Marshal.SizeOf(accent);
            var accentPtr = Marshal.AllocHGlobal(accentStructSize);
            Marshal.StructureToPtr(accent, accentPtr, false);

            var data = new W_APIs.WINCOMPATTRDATA
            {
                nAttribute = 19,
                pData = accentPtr,
                ulDataSize = accentStructSize
            };

            W_APIs.SetWindowCompositionAttribute(handle, ref data);

            Marshal.FreeHGlobal(accentPtr);
        }
    }
}
