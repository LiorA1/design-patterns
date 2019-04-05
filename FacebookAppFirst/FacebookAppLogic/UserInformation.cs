namespace FacebookAppLogic
{
    public class UserInformation
    {
        public string Name { get; set; }

        public string Gender { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string Languages { get; set; }

        public string Educations { get; set; }

        public string Work { get; set; }

        public UserInformation(FacebookEngine i_FacebookEngine)
        {
            try
            {
                Work = string.Empty;
                Name = i_FacebookEngine.GetName();
                Gender = i_FacebookEngine.GetGender();
                Email = i_FacebookEngine.GetEMail();
                Address = i_FacebookEngine.GetLocation();
                Educations = i_FacebookEngine.GetEducations(); /* FACEBOOK API HAS CHANCED*/
                Languages = i_FacebookEngine.GetLanguages(); 
            }
            catch
            {
            }
        }
    }
}
