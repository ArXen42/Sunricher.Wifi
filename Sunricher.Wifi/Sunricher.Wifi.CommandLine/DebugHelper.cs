using System;
using System.Linq;
using System.Reflection;
using System.Text;
using Sunricher.Wifi.Api;

namespace Sunricher.Wifi.CommandLine
{
	internal class DebugHelper
	{
		/// <summary>
		///     Used for converting constants from java code (wrote as decimal values of type signed byte) to more convenient hex
		///     representation.
		/// </summary>
		public static String GetConvertedSByteArrayString(FieldInfo fieldInfo)
		{
			if (fieldInfo.FieldType != typeof(SByte[]))
				throw new ArgumentException("Not SByte.");

			var field = fieldInfo.GetValue(null);
			var array = (SByte[]) field;

			var sb = new StringBuilder();
			sb.Append($"public static Byte[] {fieldInfo.Name} = {{");

			foreach (SByte item in array)
			{
				sb.Append($"0x{item:X}, ");
			}

			sb.Remove(sb.Length - 2, 2);
			sb.Append("};");

			return sb.ToString();
		}

		/// <summary>
		///     Generates code for all Java-style constants.
		/// </summary>
		public static void PrintConvertedConstants(Type type)
		{
			foreach (FieldInfo fieldInfo in typeof(ApiConstants).GetFields().OrderBy(fi => fi.Name))
			{
				if (fieldInfo.FieldType == typeof(SByte[]))
					Console.WriteLine(GetConvertedSByteArrayString(fieldInfo));
			}
		}

		public static String GetByteArrayHexString(Byte[] array)
		{
			var sb = new StringBuilder();
			sb.Append(@"{");
			foreach (Byte b in array)
			{
				sb.Append(b.ToString("X"));
				sb.Append(@", ");
			}

			sb.Remove(sb.Length - 2, 2);
			sb.Append(@"}");

			return sb.ToString();
		}
	}
}