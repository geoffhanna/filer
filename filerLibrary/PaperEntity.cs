using Microsoft.WindowsAzure.Storage.Table;


namespace filerLibrary
{
    public class PaperEntity : TableEntity, IPaper
    {

        public PaperEntity ()
        {
            this.PartitionKey = "Paper";
            Name = string.Empty;
            Folder = string.Empty;
            HangingFolder = string.Empty;
            HangingFolderGroup = string.Empty;
            Drawer = string.Empty;
        }
        public string Name { get; set; }
        public string Folder { get; set; }
        public string HangingFolder { get; set; }
        public string HangingFolderGroup { get; set; }
        public string Drawer { get; set; }
        public new string RowKey
        {
            get
            {
                return $"{Name.GetHashCode().ToString("X8")}{Folder.GetHashCode().ToString("X8")}{HangingFolder.GetHashCode().ToString("X8")}{HangingFolderGroup.GetHashCode().ToString("X8")}{Drawer.GetHashCode().ToString("X8")}";
            }
            private set { }
        }
    }
}
