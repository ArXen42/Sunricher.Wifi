using System;
using System.Reflection;
using Sunricher.Wifi.Api;

namespace Sunricher.Wifi.CommandLine
{
	internal class DebugHelper
	{
		/// <summary>
		///    Used for converting constants from java code (wrote as decimal values of type signed byte) to more convenient hex representation.
		/// </summary>
		private static void PrintSByteConstant(FieldInfo fieldInfo)
		{
			if (fieldInfo.FieldType != typeof(SByte[]))
				throw new ArgumentException("Not SByte.");

			var field = fieldInfo.GetValue(null);
			var constant = (SByte[]) field;
			Console.WriteLine($"public static Byte[] {fieldInfo.Name} = {{ 0x{constant[0]:X}, 0x{constant[1]:X}, 0x{constant[2]:X} }};");
		}

		/// <summary>
		///    Generates code for all Java-style constants.
		/// </summary>
		private static void ConvertByteConstants(Type type)
		{
			foreach (FieldInfo fieldInfo in typeof(ApiConstants).GetFields())
			{
				if (fieldInfo.FieldType == typeof(SByte[]))
					PrintSByteConstant(fieldInfo);
			}
		}
	}
}