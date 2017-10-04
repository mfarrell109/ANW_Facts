using System;
using System.Collections.Generic;
using System.Text;

namespace AlexaANWFacts
{
    public class ANW_FactResource
    {
        public ANW_FactResource(string language)
        {
            this.Language = language;
            this.Facts = new List<string>();
        }
        public string Language { get; set; }
        public string SkillName { get; set; }
        public List<string> Facts { get; set; }
        public string GetFactMessage { get; set; }
        public string HelpMessage { get; set; }
        public string HelpReprompt { get; set; }
        public string StopMessage { get; set; }
    }


    
}
