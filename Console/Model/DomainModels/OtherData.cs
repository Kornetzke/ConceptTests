using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DomainModels
{
    class OtherData
    {
        int ID { get; set;}

        int UserID { get; set; }
        DateTime CreationDateTime { get; set; }
        DateTime LastUpdatedDateTime { get; set; }
        string SomeInformation { get; set; }

    }
}
