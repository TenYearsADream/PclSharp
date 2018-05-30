// Code generated by a template
using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using PclSharp.Struct;
using PclSharp.Std;

namespace PclSharp
{
	public static unsafe partial class Invoke
	{
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void pclbase_xyz_setInputCloud(IntPtr ptr, IntPtr cloud);
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern void pclbase_xyz_setIndices(IntPtr ptr, IntPtr indices);
		
		[DllImport(Native.DllName, CallingConvention=Native.CallingConvention)]
		public static extern PointXYZ* pclbase_xyz_indexGet(IntPtr ptr, int idx);
	}

	public static unsafe class PclBaseOfXYZ
	{
		public static void SetInputCloud(this PclBase<PointXYZ> _ptr, PointCloud<PointXYZ> cloud)
			=> Invoke.pclbase_xyz_setInputCloud(_ptr, cloud);

		public static void SetIndices(this PclBase<PointXYZ> _ptr, VectorOfInt indices)
			=> Invoke.pclbase_xyz_setIndices(_ptr, indices);

		public static ref PointXYZ Index(this PclBase<PointXYZ> _ptr, int idx)
			=> ref Unsafe.AsRef<PointXYZ>(Invoke.pclbase_xyz_indexGet(_ptr, idx));
	}
}