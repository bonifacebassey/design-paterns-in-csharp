using System.Runtime.InteropServices;

namespace Fischer.DataSuite.Host.Interface.BlazorServerClient
{
    class CurrentOSPlatform
    {
        //public static bool IsAndroid => OperatingSystem.IsAndroid();

        /// <summary>
        /// Returns true if current OS is Windows
        /// </summary>
        public static bool IsWindows() => IsOSPlatform(OSPlatform.Windows);

        /// <summary>
        /// Returns true if current OS is Linux
        /// </summary>
        public static bool IsLinux() => IsOSPlatform(OSPlatform.Linux);

        /// <summary>
        /// Returns true if current OS is OSX
        /// </summary>
        public static bool IsMacOS() => IsOSPlatform(OSPlatform.OSX);

        /// <summary>
        /// Returns true if current OS matches OSPlatform
        /// </summary>
        /// <param name="osPlatform"></param>
        public static bool IsOSPlatform(OSPlatform osPlatform) => RuntimeInformation.IsOSPlatform(osPlatform);
    }
}
