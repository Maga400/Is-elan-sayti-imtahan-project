using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_elan_sayti_imtahan_project
{
    public class Cv
    {
        public bool GovernmentWork { get; set; }
        public string Specialty { get; set; }
        public string School { get; set; }
        public double AcceptanceScore { get; set; }
        public string Skills { get; set; }
        public string Companies { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public List<Language> Languages { get; set; }
        public bool HonorsDiploma { get; set; }
        public bool GITLINK { get; set; }
        public bool LINKEDIN { get; set; }
        public Cv(bool govertmentWork ,string specialty, string school, double acceptanceScore, string skills, string companies, DateOnly startDate, DateOnly endDate, List<Language> languages, bool honorsDiploma, bool gITLINK, bool lINKEDIN)
        {
            GovernmentWork = govertmentWork;
            Specialty = specialty;
            School = school;

            if (acceptanceScore > 700)
            {
                throw new AcceptanceScoreException();
            }
            else
            {
                AcceptanceScore = acceptanceScore;
            }

            Skills = skills;
            Companies = companies;
            StartDate = startDate;
            EndDate = endDate;
            Languages = languages;
            HonorsDiploma = honorsDiploma;
            GITLINK = gITLINK;
            LINKEDIN = lINKEDIN;
        }
        public override string ToString()
        {

            Console.WriteLine("-----Languages-----");
            for (int i = 0; i < Languages.Count; i++) 
            {
                Console.WriteLine(Languages[i].ToString() + "\n");
            }

            return $"Govermnet work: {GovernmentWork}\nSpecialty: {Specialty}\nAcceptance score: {AcceptanceScore}\nSkills: {Skills}\nCompanies: {Companies}" +
                $"\nStart date: {StartDate}\nEnd date: {EndDate}\nHonors diploma: {HonorsDiploma}\nGITLINK: {GITLINK}\nLINKEDIN: {LINKEDIN}";
        }
    }
}
