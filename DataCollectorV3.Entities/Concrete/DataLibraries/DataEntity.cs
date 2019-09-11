using System.Collections.Generic;
using DataCollectorV3.Interfaces.Abstract.IData;

namespace DataCollectorV3.Entities.Concrete.DataLibraries
{
    public class DataEntity : IDataEntity
    {
        public List<string> KeyList { get; set; } = new List<string>();
        public List<string> PathList { get; set; } = new List<string>();
        public List<bool> BoolList { get; set; } = new List<bool>();
        public List<string[]> ObjList { get; set; } = new List<string[]>();
    }
}