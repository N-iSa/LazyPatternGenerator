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
                    // New variable, because you apparently can't change the foreach-variable.
                    string strText = s.Replace("\r\n", "\n");
                    // Bugfix
                    // If you split with "<FOREACH>", the string will still contain the \n.
                    // This newline however isn't supposed to be in the template and therefore is a bug.
                    if(strText.StartsWith("\n"))
                    {
                        strText = strText.Substring(1);
                    }

                    if(strText.Contains("</FOREACH>"))
                    {
                        string[] strForeachSplit = strText.Split("</FOREACH>");
                        foreach (GroupElement ge in _group.Elements)
                        {
                            strOutput += strForeachSplit[0].Replace("<KEY>", ge.Key).Replace("<TYPE>", ge.Type);//.Replace("\r\n", "");
                        }
                        strOutput += (strForeachSplit[1]);
                    }
                    else
                    {
                        strOutput += strText;
                    }
                }
                strOutput = strOutput.Replace("<TITEL>", _group.Titel);
            }
            catch(Exception ex) 
            { 
                Console.WriteLine(ex.Message); 
                return false;            
            }

            // I prefer to seperate the text and the writing into a file.
            // This way I dont have to check:
            // 1. Did an error appear midway while getting the text
            // 2. Does a file exist after an error?
            // 3. Do I have to delete the File?
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