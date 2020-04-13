using System.Collections.Generic;

namespace ORMGenerator
{
    public class Group
    {
        public string Titel { get; set; }
        public List<GroupElement> Elements { get; set; }

        public Group()
        {
            this.Elements = new List<GroupElement>();
        }
        public Group(string strTitel)
        {
            this.Titel = strTitel;
            this.Elements = new List<GroupElement>();
        }
    }
}