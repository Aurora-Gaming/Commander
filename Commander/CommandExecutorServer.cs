using Microsoft.Xna.Framework;
using TShockAPI;

namespace Commander;

public class CommandExecutorServer : CommandExecutor
{
    public CommandExecutorServer() : base("Server")
    {
        Group = new SuperAdminGroup();
        Account = Server.Account;
    }

    public override void SendMessage(string msg, Color color)
      => Server.SendMessage(msg, color);

    public override void SendMessage(string msg, byte red, byte green, byte blue)
      => Server.SendMessage(msg, red, green, blue);

    public override void SendSuccessMessage(string msg) => Server.SendSuccessMessage(msg);

    public override void SendInfoMessage(string msg) => Server.SendInfoMessage(msg);

    public override void SendWarningMessage(string msg) => Server.SendWarningMessage(msg);

    public override void SendErrorMessage(string msg) => Server.SendErrorMessage(msg);
}
