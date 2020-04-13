using System.Net;
using System.Linq;
using System;
using System.IO;
namespace ORMGenerator
{
    public class Generator
    {
        public static bool generateFile(string _templateName, Group _group)
        {
            string strOutput = String.Empty;
            string strDateiname = String.Empty;
            try
            {
                string strTemplate = File.ReadAllText(@"./templates/" + _templateName);
                string[] strTemplateSplit = strTemplate.Split("</Filename>");
                strDateiname = strTemplateSplit[0].Substring(10).Replace("<TITEL>", _group.Titel);


                string[] strForeach = strTemplateSplit[1].Split("<FOREACH>");
                foreach (string s in strForeach)
                {
                    if(s.Contains("</FOREACH>"))
                    {
                        string[] strForeachSplit = s.Split("</FOREACH>");
                        foreach (GroupElement ge in _group.Elements)
                        {
                            strOutput += strForeachSplit[0].Replace("<KEY>", ge.Key).Replace("<TYPE>", ge.Type);
                        }
                        strOutput += (strForeachSplit[1]);
                    }
                    else
                    {
                        strOutput += s;
                    }
                }
                strOutput = strOutput.Replace("<TITEL>", _group.Titel);
            }
            catch(Exception ex) 
            { 
                Console.WriteLine(ex.Message); 
                return false;            
            }

            try 
            { 
                File.WriteAllText(@"./Output/" + strDateiname, strOutput); 
            }
            catch(Exception ex) 
            { 
                Console.WriteLine(ex.Message);
                return false; 
            }
            return true;
        }
    }
}