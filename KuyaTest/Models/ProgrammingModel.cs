using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KuyaTest.Models
{
    public class ProgrammingModel
    {
        [Required]
        public string SelectedProgrammingLanguage { get; set; }
        public List<string> ProgrammingLanguages { get { return languages; } set { languages = value; } }

        private List<string> languages = initializeLanguages();

        private static List<string> initializeLanguages()
        {
            List<string> l = new List<string>();
            l.Add("Python");
            l.Add("Ruby");
            l.Add("C#");
            l.Add("Java");
            return l;
        }
    }
}