using System.Collections.Generic;

namespace DataCollectorV3.Interfaces.Abstract.IData
{
    public interface IDataEntity
    {
        List<string> KeyList { get; set; }
        List<string> PathList { get; set; }
        List<bool> BoolList { get; set; }
        List<string[]> ObjList { get; set; }
    }
}