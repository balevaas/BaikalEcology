using System.Diagnostics;

namespace CoreModel
{
    public static class OuterHandler
    {
        public static void Starter(string path)
        {
            Process module = new();
            module.StartInfo.FileName = path;
            module.Start();
        }
    }
}