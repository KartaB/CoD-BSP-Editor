using CoD_BSP_Editor.Libs;
using System.Runtime.InteropServices;

namespace CoD_BSP_Editor.Data
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct BrushSides
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] PlaneDistanceUnion;
        public uint MaterialID;

        public uint GetPlaneIndex()
        {
            uint PlaneIndex = BinLib.ReadFromByteArray<uint>(PlaneDistanceUnion);
            return PlaneIndex;
        }

        public float GetDistance()
        {
            float Distance = BinLib.ReadFromByteArray<float>(PlaneDistanceUnion);
            return Distance;
        }
    }
}
