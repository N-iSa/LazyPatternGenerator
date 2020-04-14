namespace ORMGenerator
{
    public class GroupElement
    {
        public string Key { get; set; }
        public string Type { get; set; }

        public GroupElement()
        {
            this.Type = "string";
        }
        public GroupElement(string strKey, string strType)
        {
            this.Key = strKey;
            this.Type = strType;
        }
    }
}