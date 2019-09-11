using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DataCollectorV3.Interfaces.Abstract.IUserControl
{
    public interface IParentModule
    {
        string BtnStartText { get; set; }
        List<IChildModule> ChildModules { get; }
        bool Sequential { get; }
        string Url { get; }
        Color UrlColor { get; set; }
        int ControlPage { get; }
        Color ControlPageColor { get; set; }
        string Separator { get; }
        Color SeparatorColor { get; set; }
        int StartPage { get; set; }
        Color StartPageColor { get; set; }
        int EndPage { get; set; }
        Color EndPageColor { get; set; }
        int Seconds { get; }
        Color SecondsColor { get; set; }
    }
}