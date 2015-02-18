namespace Wiki.Core
{
    using System.Runtime.InteropServices;

    using Wiki.Models.Enums;

    /// <summary>
    /// System.Console extended class
    /// </summary>
    public class Console
    {
        private static string line;

        [DllImport("kernel32.dll")]
        private static extern System.IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(System.IntPtr handle, int code);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetForegroundWindow(System.IntPtr handle);

        public static string ReadLine()
        {
            return System.Console.ReadLine();
        }

        public static T ReadLine<T>()
        {
            object result;
            line = System.Console.ReadLine();
            switch (System.Type.GetTypeCode(typeof(T)))
            {
                case System.TypeCode.Boolean:
                    result = bool.Parse(line);
                    break;
                case System.TypeCode.Byte:
                    result = byte.Parse(line);
                    break;
                case System.TypeCode.Char:
                    result = char.Parse(line);
                    break;
                case System.TypeCode.DateTime:
                    result = System.DateTime.Parse(line);
                    break;
                case System.TypeCode.Decimal:
                    result = decimal.Parse(line);
                    break;
                case System.TypeCode.Double:
                    result = double.Parse(line);
                    break;
                case System.TypeCode.Int16:
                    result = short.Parse(line);
                    break;
                case System.TypeCode.Int32:
                    result = int.Parse(line);
                    break;
                case System.TypeCode.Int64:
                    result = long.Parse(line);
                    break;
                case System.TypeCode.Object:
                    result = line;
                    break;
                case System.TypeCode.SByte:
                    result = sbyte.Parse(line);
                    break;
                case System.TypeCode.Single:
                    result = float.Parse(line);
                    break;
                case System.TypeCode.String:
                    result = line;
                    break;
                case System.TypeCode.UInt16:
                    result = ushort.Parse(line);
                    break;
                case System.TypeCode.UInt32:
                    result = uint.Parse(line);
                    break;
                case System.TypeCode.UInt64:
                    result = ulong.Parse(line);
                    break;
                default:
                    throw new System.NotImplementedException();
            }

            return (T)System.Convert.ChangeType(result, typeof(T));
        }

        public static void Write(string value)
        {
            System.Console.Write(value);
        }

        public static void WriteLine()
        {
            System.Console.WriteLine();
        }

        public static void WriteLine(dynamic value)
        {
            System.Console.WriteLine(value);
        }

        public static void WriteLine(string format, params object[] arg)
        {
            System.Console.WriteLine(format, arg);
        }

        public static System.ConsoleKeyInfo ReadKey()
        {
            return System.Console.ReadKey();
        }

        public static void Clear()
        {
            System.Console.Clear();
        }

        /// <summary>
        /// Shows the console window.
        /// </summary>
        public static void Show()
        {
            ShowWindow(GetConsoleWindow(), 5);
        }

        /// <summary>
        /// Hides the console window.
        /// </summary>
        public static void Hide()
        {
            ShowWindow(GetConsoleWindow(), 0);
        }

        /// <summary>
        /// Puts the console window on focus.
        /// </summary>
        public static void OnFocus()
        {
            SetForegroundWindow(GetConsoleWindow());
        }

        /// <summary>
        /// Sets foreground and background console colors.
        /// </summary>
        /// <param name="foregroundColor">The foreground console color.</param>
        /// <param name="backgroundColor">The background console color. By default is black.</param>
        public static void SetColor(Color foregroundColor, Color backgroundColor = Color.Black)
        {
            System.Console.ForegroundColor = (System.ConsoleColor)((int)foregroundColor);
            System.Console.BackgroundColor = (System.ConsoleColor)((int)backgroundColor);
        }

        public static void ResetColor()
        {
            System.Console.ResetColor();
        }

        /// <summary>
        /// Prints some log message with different color.
        /// </summary>
        /// <param name="log">The log message.</param>
        /// <param name="isOk">To mark the log as Good use 'true' or 'false' to mark it as Bad. By default is 'null' (neutral).</param>
        public static void Log(dynamic log, bool? isOk = null)
        {
            SetColor(isOk == null ? Color.White : ((bool)isOk ? Color.Green : Color.Red));
            WriteLine(log);
            ResetColor();
        }
    }
}
