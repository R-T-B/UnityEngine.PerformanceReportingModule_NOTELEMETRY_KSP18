using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine.Analytics
{
	public static class PerformanceReporting
	{
		public static bool enabled = false;

		public static long graphicsInitializationFinishTime = 0;
	}
}
