using System;
using System.Collections.Generic;
using System.Text;

namespace AlexaANWFacts
{
    public class GetResource
    {
        public List<ANW_FactResource> GetResources()
        {
            List<ANW_FactResource> resources = new List<ANW_FactResource>();
            ANW_FactResource enUSResource = new ANW_FactResource("en-US");
            enUSResource.SkillName = "American Ninja Warrior Season 10 Facts";
            enUSResource.GetFactMessage = "Here's your face : ";
            enUSResource.HelpMessage = "You can tell me a American Ninja Warrior Season 10 Fact, or , you can say exit...What can I help you with?";
            enUSResource.HelpReprompt = "What can I help you with?";
            enUSResource.StopMessage = "Goodbye!";
            enUSResource.Facts.Add("");
            enUSResource.Facts.Add("");
            enUSResource.Facts.Add("");
            enUSResource.Facts.Add("");
            enUSResource.Facts.Add("");
            enUSResource.Facts.Add("");
            resources.Add(enUSResource);
            enUSResource.Facts.Add("");

            return resources;
        }
    }
}
