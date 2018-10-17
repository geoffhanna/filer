using System;
using System.Collections.Generic;
using System.Text;

namespace filerLibrary
{
    interface IPaper
    {
        string Name { get; set; }
        string Folder{ get; set; }
        string HangingFolder { get; set; }
        string HangingFolderGroup { get; set; }
        string Drawer { get; set; }
    }
}
