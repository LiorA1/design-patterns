using System;
using FacebookWrapper.ObjectModel;

namespace FacebookAppLogic
{
    public class UserInformationAdapter
    {
        public string Name { get; set; }

        public string Gender { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string Languages { get; set; }

        public string Education { get; set; }

        public string Work { get; set; }

        public UserInformationAdapter()
        {
            try
            {
                Name = FacebookEngine.Instance.GetName();
                Gender = FacebookEngine.Instance.GetGender();
                Email = FacebookEngine.Instance.GetEMail();
                createAddressIntoString();
                createEducationHistoryIntoString();
                createLanguagesListIntoString();
                Work = string.Empty;
            }
            catch
            {
            }
        }

        public void ClearAll()
        {
            Work = string.Empty;
            Name = string.Empty;
            Gender = string.Empty;
            Email = string.Empty;
            Address = string.Empty;
            Education = string.Empty; /* FACEBOOK API HAS CHANCED*/
            Languages = string.Empty;
        }

        private void createAddressIntoString()
        {
            City location = FacebookEngine.Instance.GetLocation();

            if (location != null)
            {
                Address = location.Name;                                       
            }
            else
            {
                Address = "Country:" + Environment.NewLine + "City:" + Environment.NewLine + "Street:" + Environment.NewLine + "House Number:";
            }
        }

        private void createEducationHistoryIntoString()
        {
            Education[] educationHistory = FacebookEngine.Instance.GetEducations();
            if (educationHistory != null)
            {
                try
                {
                    foreach (Education education in educationHistory)
                    {
                        Education += education?.Type;
                        Education += Environment.NewLine;
                        Education += education?.Degree;
                        Education += education?.Year;
                        Education += Environment.NewLine;
                        Education += education?.School.Name;
                        Education += ", ";
                        Education += education?.School.Location;
                        Education += ", ";
                        Education += education?.School.Phone;
                        Education += Environment.NewLine;
                    }
                }
                catch
                {
                }
            }
            else
            {
                Education = 
                    "Primary School:" 
                    + Environment.NewLine 
                    + "Year:[start]-[End]"
                    + Environment.NewLine
                    + "High School:"
                    + Environment.NewLine
                    + "Year:[start]-[End]"
                    + Environment.NewLine
                    + "college:"
                    + Environment.NewLine
                    + "Year:[start]-[End]"
                    + Environment.NewLine
                    + "Degree:";
            }
        }

       private void createLanguagesListIntoString()
        {
            Page[] languagesList = FacebookEngine.Instance.GetLanguages();

            try
            {
                foreach (Page page in languagesList)
                {
                    Languages += page.Name + Environment.NewLine;
                }
            }
            catch
            {
            }
        }
    }
}
