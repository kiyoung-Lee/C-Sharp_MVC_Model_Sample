using System;

namespace UtilLib.ControlLib
{
    public interface IWaitFormShowable
    {
        void Show(string caption, string message, object iController);
        void Ping(string message);
        void Hide();
        bool IsAlive();
    }
}
