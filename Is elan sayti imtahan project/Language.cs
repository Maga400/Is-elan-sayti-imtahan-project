using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_elan_sayti_imtahan_project
{
    public class Language
    {
        public string? LanguageName { get; set; }
        public string? LanguageLevel { get;set; }

        public Language(string? languageName, string? languageLevel)
        {
            LanguageName = languageName;
            LanguageLevel = languageLevel;
        }

        public override string ToString()
        {
            return $"Language name: {LanguageName}\nLanguage level: {LanguageLevel}";
        }
    }
}
