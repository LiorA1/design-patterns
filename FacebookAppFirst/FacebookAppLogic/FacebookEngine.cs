using System;
using System.Net;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookAppLogic
{
    public class FacebookEngine
    {
        public const string k_AppID = "942981795907048";
        public const string k_PermissionsNeeded = @"user_location, email, user_birthday, user_hometown, user_location, user_likes, user_events, user_photos, user_videos,
                                                        user_friends, user_tagged_places, user_posts, user_gender, user_link, publish_video, 
                                                        groups_access_member_info, public_profile, publish_to_groups, manage_pages, publish_pages ";

        public const string k_LoginFailedMessage = "Login Failed!";
        public const string k_LogoutFailedMessage = "Logout Failed!";

        public LoginResult LoginResult { get; private set; }

        public User CurrentUser { get; private set; }

        public string AccessToken { get; private set; }

        internal FacebookEngineSettings EngineSettings { get; private set; }

        public bool RememberUser { get; set; }
        
        public FacebookEngine()
        {
            AccessToken = string.Empty;
            LoginResult = null;
            CurrentUser = null;
            //// If the file exists - read it, If not provide default values..
            EngineSettings = FacebookEngineSettings.LoadEngineSettingsFromFile();

            if(this.EngineSettings.RememberUser)
            {
                this.RememberUser = this.EngineSettings.RememberUser;
                this.AccessToken = EngineSettings.LastAccessToken;
                this.Connect(this.AccessToken);
            }
        }

        /* Login, Using the Facebook.Login Method from the FacebookGraph API */
        public void Login()
        {
            try
            {
                LoginResult = FacebookService.Login(k_AppID, k_PermissionsNeeded);
                AccessToken = LoginResult.AccessToken;
                
                initializeMembersAfterSuccessfulConnection();
            }
            catch (Exception ex)
            {
                throw new Exception(k_LoginFailedMessage, ex);
            }
        }

        /* Connect to The Facebook Account with the Access Token */
        public void Connect(string i_AccessToken)
        {
            try
            {
                if(!string.IsNullOrEmpty(i_AccessToken))
                {
                    LoginResult = FacebookService.Connect(i_AccessToken);
                    initializeMembersAfterSuccessfulConnection();
                }     
            }
            catch (Exception ex)
            {
                throw new Exception(k_LoginFailedMessage, ex);
            }
        }

        /*Initialize Basic Inofrmation of the engine ( Only of the engine !)*/
        private void initializeMembersAfterSuccessfulConnection()
        {
            CurrentUser = LoginResult.LoggedInUser;
        }
        
        public void PostStatus(string MessageToPost)
        {
            try
            {
                if (!string.IsNullOrEmpty(MessageToPost))
                {
                    CurrentUser.PostStatus(MessageToPost);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }        
        }

        public string GetBirthday()
        {
            return CurrentUser?.Birthday;
        }

        /* Get The Profile Picture URL address, and return it as a String */
        public string GetProfilePictureUrl()
        {
            return CurrentUser.PictureNormalURL.ToString();
        }

        /* Get The Cover Picture URL address, and return it as a String */
        public string GetCoverPictureUrl()
        {
            return CurrentUser.Cover.SourceURL.ToString();
        }

        /* Get the full name of the User(currentUser) and return it as a string */
        public string GetName()
        {
            return CurrentUser.Name;
        }
        
        /* Gets the Education of the User(currentUser), return it as Education[] */
        public string GetEducations()
        {
            string allEducation = string.Empty;
            try
            {
                foreach (Education education in this.CurrentUser.Educations)
                {
                    allEducation += education?.Type;
                    allEducation += Environment.NewLine;
                    allEducation += education?.Degree;
                    allEducation += education?.Year;
                    allEducation += Environment.NewLine;
                    allEducation += education?.School.Name;
                    allEducation += ", ";
                    allEducation += education?.School.Location;
                    allEducation += ", ";
                    allEducation += education?.School.Phone;
                    allEducation += Environment.NewLine;
                }               
            }
            catch
            {
            }

            return allEducation;
        }

        /* Get The pages (of Languages the user liked), return it as Page[] */
        public string GetLanguages()
        {
            string allLanguages = string.Empty;

            foreach(Page page in this.CurrentUser.Languages)
            {
                allLanguages += page.Name + Environment.NewLine;
            }

            return allLanguages;
        }

        /* Get the Gender of the user(Currentuser), and return it as a String */
        public string GetGender()
        {
            return CurrentUser?.Gender?.ToString();
        }

        /* Get the Location and return it as a String */
        public string GetLocation()
        {
            string location = string.Empty;

            if(CurrentUser.Location != null)
            {
                location = CurrentUser.Location.Name;

                if (CurrentUser.Location.Location != null)
                {
                    location += string.Format("{0},{1}", CurrentUser.Location.Location.Street, CurrentUser.Location.Location.Zip);
                }
            }

            return location;
        }

        /* Gets the Email, and return it as an E-Mail */
        public string GetEMail()
        {
            return CurrentUser?.Email;
        }        

        /* Log out from Current User !*/
        public void Logout()
        {
            try
            {
                FacebookService.Logout(resetDataAfterLogout);
                RememberUser = false;
            }
            catch (Exception ex)
            {
                throw new Exception(k_LogoutFailedMessage, ex);
            }
        }

        /* Erase data from the engine after Log out */
        private void resetDataAfterLogout()
        {
            AccessToken = string.Empty;
            CurrentUser = null;
            LoginResult = null;
        }

        /* Get the Education list from facebook API */
        public Education[] FetchUserEducation()
        {
            return CurrentUser?.Educations;
        }

        /* Fetch the Current User Gropus (And return the collection)*/
        public FacebookObjectCollection<Group> FetchUserGroups()
        {    
            return CurrentUser?.Groups;
        }

        /* Fetch the Current User Checkins (And return the collection)*/
        public FacebookObjectCollection<Checkin> FetchUserCheckins()
        {
            return CurrentUser?.Checkins;
        }

        /* Fetch the Current User Photos (And return the collection)*/
        public FacebookObjectCollection<Photo> FetchUserPhotos()
        {
            FacebookObjectCollection<Photo> collectionOfUserPhotos = new FacebookObjectCollection<Photo>();

            foreach (Album album in CurrentUser?.Albums)
            {
                foreach (Photo photo in album.Photos)
                {
                    collectionOfUserPhotos.Add(photo);
                }
            }

            return collectionOfUserPhotos;
        }

        /* Fetch the Current User Friends (And return the collection)*/
        public FacebookObjectCollection<User> FetchUserFriends()
        {
            return CurrentUser?.Friends;
        }

        /* Fetch the Current User Posts (And return the collection)*/
        public FacebookObjectCollection<Post> FetchUserPosts()
        {
            // Thread userPostsFetchThread = new Thread()
            return CurrentUser?.Posts;
        }

        public void OnEngineClosing()
        {
            this.EngineSettings.RememberUser = this.RememberUser;
            this.EngineSettings.LastAccessToken = this.AccessToken;

            this.EngineSettings.SaveEngineSettingsToFile();
        }

        public string DownloadProfilePhoto()
        {
            string pictureName = "ProfilePicture.jpg";
            string ProfilePicturePath = Environment.CurrentDirectory + @"\" + pictureName;

            using (WebClient webClient = new WebClient())
            {
                webClient.DownloadFile(GetProfilePictureUrl(), pictureName);
            }

            return ProfilePicturePath;
        }
    }
}
