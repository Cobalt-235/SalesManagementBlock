using Quanlybangame.BLL;
using Quanlybangame.DTO;
using Quanlybangame.UI.Forms;
using QuanlybangameMoi_UI;

namespace QuanlybangameMoi;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new trangchinh());
    }
}