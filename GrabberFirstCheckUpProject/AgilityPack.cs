using System;
using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;

namespace GrabberFirstCheckUpProject
{
   public static class AgilityPack
    {

        public static void scrapDataByURl() {

            String source = "http://www.besoft.hr/mrcina/";
            HtmlAgilityPack.HtmlDocument htmlDoc = new HtmlAgilityPack.HtmlDocument();
            htmlDoc.OptionOutputAsXml = true;

            htmlDoc = new HtmlWeb().Load(source);
            HtmlAgilityPack.HtmlNode.ElementsFlags.Remove("form");

            List<HtmlAttribute> formAttributes = new List<HtmlAttribute>();
            IEnumerable<HtmlNode> inputs;

            inputs = htmlDoc.DocumentNode.Descendants("input");

            foreach (var input in inputs)
            {
                IEnumerable<HtmlAttribute> attributes;
                attributes = input.Attributes;
                String outer = input.OuterHtml;

                foreach (var att in attributes)
                {
                    if (att.ToString() == "value")
                    {
                        String value = att.Value;
                    }

                    formAttributes.Add(att);
                }//foreach (var att in attributes)
            }// foreach (var input in inputs)
        }//  public static void scrapDataByURl() {




    }//    class AgilityPack


    public static class HtmlNodeExtensions
    {
        public static IEnumerable<HtmlNode> GetElementsByName(this HtmlNode parent, string name)
        {
            return parent.Descendants().Where(node => node.Name == name);
        }// public static IEnumerable<HtmlNode> GetElementsByName(this HtmlNode parent, string name)

        public static IEnumerable<HtmlNode> GetElementsByTagName(this HtmlNode parent, string name)
        {          
                return parent.Descendants(name);
        }// public static IEnumerable<HtmlNode> GetElementsByTagName(this HtmlNode parent, string name)


    }//   public static class HtmlNodeExtensions
}//namespace GrabberFirstCheckUpProject

