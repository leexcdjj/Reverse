using System.Diagnostics;

namespace CanCanNeedJJBong.Reverse.OpenTLBB;

class Program
{
    /// <summary>
    /// 跳过天龙八部登录器登录游戏
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Reverse!");

        string tlbbGamePath = "D:\\XTLBBCZ\\Bin\\Game.exe";
        string arg = "-fl";

        ProcessStartInfo tlbbProcesstInfo = new ProcessStartInfo();
        tlbbProcesstInfo.FileName = tlbbGamePath;
        tlbbProcesstInfo.Arguments = arg;
        
        // 启动目录设置，因为game.exe要读取dll文件等
        tlbbProcesstInfo.WorkingDirectory = "D:\\XTLBBCZ\\Bin";

        Process.Start(tlbbProcesstInfo);
        
        Console.ReadLine();
    }
}