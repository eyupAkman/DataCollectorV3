using System.Drawing;

namespace DataCollectorV3.Interfaces.Abstract.IUserControl
{
    public interface IChildModule
    {
        bool AutoKey { get; set; }
        string Key { get; set; }
        Color KeyColor { get; set; }
        string Result { get; set; }
        Color ResultColor { get; set; }
        string XPath { get; set; }
        Color XPathColor { get; set; }
    }
}