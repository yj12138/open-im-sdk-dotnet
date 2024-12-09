
namespace OpenIM.IMSDK.Util
{
    public static class Utils
    {
        public static void Log(params object[] args)
        {
#if IMSDK_LOG_ENABLE
            string prefix = "IMSDK";
            var info = "";
            foreach (var v in args)
            {
                info += v.ToString() + " ";
            }
            Console.WriteLine(string.Format("[{0}]:{1}", prefix, info));
#endif
        }
    }
};