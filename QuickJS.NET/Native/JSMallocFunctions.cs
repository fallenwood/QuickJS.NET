using System;
using System.Runtime.InteropServices;

namespace QuickJS.Native
{
	[StructLayout(LayoutKind.Sequential)]
	public struct JSMallocFunctions
	{
        // void *(*js_calloc)(void *opaque, size_t count, size_t size);
        // void *(*js_malloc)(void *opaque, size_t size);
        // void (*js_free)(void *opaque, void *ptr);
        // void *(*js_realloc)(void *opaque, void *ptr, size_t size);
        // size_t (*js_malloc_usable_size)(const void *ptr);
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public JSCallocDelegate js_calloc;
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public JSMallocDelegate js_malloc;
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public JSFreeDelegate js_free;
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public JSReallocDelegate js_realloc;
		[MarshalAs(UnmanagedType.FunctionPtr)]
		public JSMallocUsableSizeDelegate js_malloc_usable_size;

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr JSCallocDelegate(IntPtr opaque, UIntPtr count, UIntPtr size);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr JSMallocDelegate(IntPtr opaque, UIntPtr size);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void JSFreeDelegate(IntPtr opaque, IntPtr ptr);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate IntPtr JSReallocDelegate(IntPtr opaque, IntPtr ptr, UIntPtr size);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate UIntPtr JSMallocUsableSizeDelegate([In] IntPtr ptr);
	}
}
