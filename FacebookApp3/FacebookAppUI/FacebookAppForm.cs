using System;
using System.Threading;
using System.IO;
using System.Net;
using System.Drawing;
using System.Windows.Forms;
using FacebookAppLogic;

namespace FacebookAppUI
{
    public partial class FormFacebookApp : Form
    {
        private const string k_Error = "Error";
        private const string k_ResumeNotFound = "Resume has not been found";
        private bool m_LoggedIn;
        private FacebookAppSettings m_FormSettings;
        private PdfDocumentFile m_pdf;
        private UserInformationAdapter m_CurrentUserInformation;
        private managedDelayedPost m_delayedPost;
        
        private FormCleaner m_formCleaner;

        public FormFacebookApp()
        {
            InitializeComponent();

            m_formCleaner = new FormCleaner();

            m_formCleaner.AttachAllControls(this); // Add all of the wanted controls to the subject./*Lior*/
            m_formCleaner.AttachLegacyControl(this.nameLabel); // Can add legacy controls individually. 

            StartPosition = FormStartPosition.Manual;

            m_LoggedIn = FacebookEngine.Instance.RememberUser;

            m_FormSettings = FacebookAppSettings.LoadAppSettingsFromFile();

            commandButtonFetchResumeInfo.Command = new FetchResumeInformationCommand { Client = this };

            commandButtonCreateCv.Command = new CreateResumeCommand { Client = this };

            commandButtonSendToMail.Command = new SendResumeToMailCommand { Client = this };

            if (m_FormSettings.RememberUser)
            {
                checkBoxRemember.Checked = m_FormSettings.RememberUser;
                Location = m_FormSettings.LastWindowLocation;
                Size = m_FormSettings.LastWindowSize;

                if (m_LoggedIn)
                {
                    fetchLoggedInUserWrapper();
                }    
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            handleLogin();
        }

        /* Handle Login */
        private void handleLogin()
        {
            try
            {
                m_LoggedIn = true;
                commandButtonCreateCv.Enabled = true;

                FacebookEngine.Instance.Login();
                fetchLoggedInUserWrapper();
            }     
            catch (Exception ex)
            {
                m_LoggedIn = false;
                MessageBox.Show(ex.Message);
            }      
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            m_LoggedIn = false;
            handleLogout();
        }

        private void handleLogout()
        {
            const string logoutTextMessage = "Logged Out!";

            try
            {
                FacebookEngine.Instance.Logout();
                resetUI();
                MessageBox.Show(logoutTextMessage);
                buttonLogin.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fetchLoggedInUserWrapper()
        {
            Thread fetchLoggedInUserThread = new Thread(fetchLoggedInUser);

            fetchLoggedInUserThread.Start();
        }

        private void fetchLoggedInUser()
        {
            try
            {
                populateProfilePicture();
                
                populatePosts();

                populatePhotos();

                populateGroups();

                populateFriends();

                populateIntro();

                this.Invoke(new Action(() => this.Refresh()));               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        /* populate the basic (Intro) listBox */ 
        private void populateIntro()
        {
            try
            {
                if (FacebookEngine.Instance.CurrentUser != null)
                {
                    listBoxIntro.Invoke(new Action(() => listBoxIntro.Items.Add(FacebookEngine.Instance.GetName())));
                   listBoxIntro.Invoke(new Action(() => listBoxIntro.Items.Add(FacebookEngine.Instance.GetGender())));
                    listBoxIntro.Invoke(new Action(() => listBoxIntro.Items.Add(FacebookEngine.Instance.GetBirthday())));
                }     
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void populateProfilePicture()
        {
            try
            {
                if (!string.IsNullOrEmpty(FacebookEngine.Instance.GetProfilePictureUrl()))
                {
                    pictureBoxProfilePicture.Invoke(new Action(
                        () => pictureBoxProfilePicture.Load(FacebookEngine.Instance.GetProfilePictureUrl())));
                }
                else
                {
                    pictureBoxProfilePicture.Image = pictureBoxProfilePicture.ErrorImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void populateCoverPicture()
        {
            try
            {
                if (!string.IsNullOrEmpty(FacebookEngine.Instance.GetCoverPictureUrl()))
                {
                    pictureBoxCoverPicture.LoadAsync(FacebookEngine.Instance.GetCoverPictureUrl());
                }
                else
                {
                    pictureBoxCoverPicture.Image = pictureBoxCoverPicture.ErrorImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /* populate Friends listbox with user friend's */
        private void populateFriends()
        {
            const string displayMemberTitle = "Name";

            const string noFriendsText = "No Friends to retrieve :((";

            try
            {
                this.listBoxFriends.Invoke(new Action(() => this.listBoxFriends.DisplayMember = displayMemberTitle));
                if (FacebookEngine.Instance.FetchUserFriends().Count == 0)
                {
                    this.listBoxFriends.Invoke(new Action(() => this.listBoxFriends.Items.Add(noFriendsText)));
                }
                else
                {
                    foreach (FacebookWrapper.ObjectModel.User friend in FacebookEngine.Instance.FetchUserFriends())
                    {
                        this.listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Add(friend)));

                        friend.ReFetch(FacebookWrapper.ObjectModel.DynamicWrapper.eLoadOptions.Full);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /* populate all user Posts in listBoxPosts*/
        private void populatePosts()
        {
            const string noPostText = "No Posts to retrieve :(";

            try
            {
                if (FacebookEngine.Instance.FetchUserPosts().Count == 0)
                {
                    listBoxPosts.Items.Add(noPostText);
                }
                else
                {
                    foreach (FacebookWrapper.ObjectModel.Post post in FacebookEngine.Instance.FetchUserPosts())
                    {
                        if (post.Message != null)
                        {
                            listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.Message)));
                        }
                        else if (post.Caption != null)
                        {
                            listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.Caption)));
                        }
                        else
                        {
                            listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(string.Format("[{0}]", post.Type))));
                            //// maybe link ?
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add("Failed to retrieve Posts :(")));
            }
        }

        /* populate all user Photos in panelPictures */
        private void populatePhotos()
        {
            try
            {
                Size smallSize = new Size(50, 50);

                if (FacebookEngine.Instance.FetchUserPhotos().Count == 0)
                {
                    this.flowLayoutPanelPictures.Controls.Add(new Control("No Images Found"));
                }
                else
                {
                    foreach (FacebookWrapper.ObjectModel.Photo photo in FacebookEngine.Instance.FetchUserPhotos())
                    {
                        extendedPictureBox pic = new extendedPictureBox();

                        pic.Name = photo.Name + photo.Id;
                        pic.Load(photo.PictureNormalURL);
                        pic.Size = smallSize;
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;

                        IDecoratedPictureBox pic2 = new DecoratedPictureBox(new DecoratorMargin(new CorePictureBox(pic), new Padding(1)));
                        IDecoratedPictureBox pic3 = new DecoratorBackColor(pic2, this.BackColor);
                        IDecoratedPictureBox pic4 = new DecoratorPadding(pic3, new Padding(2));
                        this.flowLayoutPanelPictures.Invoke(new Action(() => flowLayoutPanelPictures.Controls.Add(pic4.getPictureBoxItem())));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }
       
        // populate the group listbox
        private void populateGroups()
        {
            try
            {
                if (FacebookEngine.Instance.FetchUserGroups().Count == 0)
                {
                    this.listBoxGroups.Invoke(new Action(() => this.listBoxGroups.Items.Add("No Groups to retrieve :(")));
                }
                else
                {
                    foreach (FacebookWrapper.ObjectModel.Group group in FacebookEngine.Instance.FetchUserGroups())
                    {
                        this.listBoxGroups.Invoke(new Action(() => this.listBoxGroups.Items.Add(group.Name.ToString())));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.listBoxGroups.Invoke(new Action(() => this.listBoxGroups.Items.Add("Failed to retrieve Groups  :(")));
            }
        }

        /* Clean the Form from data */
        private void resetUI()
        {
            try
            {
                m_formCleaner.NotifyClear(); // Clears all fields in the Form.

                m_CurrentUserInformation.ClearAll();
                userInformationBindingSource.DataSource = m_CurrentUserInformation;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

        private void buttonPostPublish_Click(object sender, EventArgs e)
        {
            const string noPostMessage = "No Post detcted !";

            try
            {
                if (!string.IsNullOrEmpty(this.textBoxPost.Text))
                {
                    FacebookEngine.Instance.PostStatus(this.textBoxPost.Text);
                }
                else
                {
                    MessageBox.Show(noPostMessage, k_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
   
        private void updateUserInformationBindingSource()
        {
            if (m_LoggedIn)
            {
                try
                {
                    if (m_CurrentUserInformation == null)
                    {
                        m_CurrentUserInformation = new UserInformationAdapter();
                    }

                    userInformationBindingSource.DataSource = m_CurrentUserInformation;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private string createFilePath()
        {
            string savePath = string.Empty;
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = "Resume";
                saveFile.Filter = "Pdf Files| *.pdf";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    savePath = Path.GetFullPath(saveFile.FileName);
                }
                else
                {
                    savePath = Environment.CurrentDirectory;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return savePath;
        }

        private void checkBoxRemember_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.checkBoxRemember.Checked)
                {
                    this.m_FormSettings.RememberUser = this.checkBoxRemember.Checked;

                    if (this.m_LoggedIn)
                    {
                        FacebookEngine.Instance.RememberUser = true; /* Attention : Only If logged with some user !*/
                    }
                    else
                    {
                        FacebookEngine.Instance.RememberUser = false; /* Attention : Only If logged with some user !*/
                    }
                }
                else
                {
                    this.m_FormSettings.RememberUser = false;
                    FacebookEngine.Instance.RememberUser = false; /* Attention : Only If logged with some user !*/
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /* Manage The Form just beofre closing  */
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            try
            {
                if (this.checkBoxRemember.Checked)
                {
                    this.m_FormSettings.LastWindowLocation = this.Location;
                    this.m_FormSettings.LastWindowSize = this.Size;
                    this.m_FormSettings.RememberUser = this.checkBoxRemember.Checked;

                    if (this.m_LoggedIn)
                    {
                        FacebookEngine.Instance.RememberUser = this.checkBoxRemember.Checked;
                    }

                    FacebookEngine.Instance.OnEngineClosing();
                }
                else
                {
                    this.handleLogout();

                    if (!this.m_LoggedIn)
                    {
                        FacebookEngine.Instance.RememberUser = this.m_LoggedIn;
                        FacebookEngine.Instance.OnEngineClosing();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.m_FormSettings.SaveAppSettingsToFile();
            }            
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedFriend();
        }

        /* Display the Picture of the selected friend */
        private void displaySelectedFriend()
        {
            if (listBoxFriends.SelectedItems.Count > 0)
            {
                FacebookWrapper.ObjectModel.User selectedFriend = listBoxFriends.SelectedItem as FacebookWrapper.ObjectModel.User;
                if (selectedFriend.PictureNormalURL != null)
                {
                    this.pictureBoxOfSelectedFriend.LoadAsync(selectedFriend.PictureNormalURL);
                }
                else
                {
                    this.pictureBoxOfSelectedFriend.Image = this.pictureBoxOfSelectedFriend.ErrorImage;
                }
            }
        }

        private void buttonFetchResumeInformationFromFacebook_Click(object sender, EventArgs e)
        {
            updateUserInformationBindingSource();
        }

        /* Send Delayed post */
        private void buttonSendAsyncPost_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dateToPublishPost = this.dateTimePickerStatusPost.Value;
                const string noDelayedPostMassege = "No Delayed Post detcted !";
                const string invalidDateMessage = "Choosen date as passed, Please choose Another Date";

                if (dateToPublishPost > DateTime.Now)
                {
                    if (!string.IsNullOrEmpty(this.textBoxAsyncPost.Text))
                    {
                        this.m_delayedPost = new managedDelayedPost(dateToPublishPost, this.textBoxAsyncPost.Text);

                        if (this.m_delayedPost.InnerException != null)
                        {
                            //// inner exception exists.
                            MessageBox.Show(this.m_delayedPost.InnerException.Message, k_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            this.buttonSendDelayedPost.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show(noDelayedPostMassege, k_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(invalidDateMessage, k_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, k_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* Refresh the button's possible to push */
        private void buttonRefreshDelayedPost_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.m_delayedPost.OperateTime >= DateTime.Now)
                {
                    //// Operate time has not passed
                    if (this.m_delayedPost.InnerException != null)
                    {
                        //// Exception.
                        MessageBox.Show(this.m_delayedPost.InnerException.Message, k_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.m_delayedPost = null;
                        this.buttonSendDelayedPost.Enabled = true;
                        this.buttonCancelDelayedPost.Enabled = false;
                    }
                    else
                    {
                        this.buttonCancelDelayedPost.Enabled = true;
                    }
                }
                else
                {
                    //// Operate time has passed
                    //// Check if any error has occurd .
                    if (this.m_delayedPost.InnerException == null)
                    {
                        //// No exception occurd.
                        this.m_delayedPost = null;
                        this.buttonCancelDelayedPost.Enabled = false;
                        this.buttonSendDelayedPost.Enabled = true;
                    }
                    else
                    {
                        this.buttonCancelDelayedPost.Enabled = false;
                        this.buttonSendDelayedPost.Enabled = true;
                        //// Exception occurd.
                        MessageBox.Show(this.m_delayedPost.InnerException.Message, k_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, k_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        /* Cancel the Delayed Post */
        private void buttonCancelDelayedPost_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.m_delayedPost != null)
                {
                    this.m_delayedPost.AbortDelayedPostStatus();

                    if (this.m_delayedPost.InnerException != null)
                    {
                        // inner exception exists.
                        MessageBox.Show(this.m_delayedPost.InnerException.Message, k_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.buttonCancelDelayedPost.Enabled = false;
                        this.buttonSendDelayedPost.Enabled = true;
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, k_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }

        private void buttonPicturesDownload_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control picture in this.flowLayoutPanelPictures.Controls)
                {
                    if (picture is extendedPictureBox)
                    {
                        if (picture.BackColor == System.Drawing.Color.BlueViolet)
                        {
                            (picture as extendedPictureBox).Image.Save(picture.Name);
                        }

                        /*
                        if ((picture as extendedPictureBox).DownloadWanted)
                        {
                            using (WebClient client = new WebClient())
                            {
                                (picture as extendedPictureBox).Image.Save(picture.Name);
                                //client.DownloadFileAsync(((extendedPictureBox)picture).URI, picture.Name);
                            }
                        }
                        */
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, k_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void createResume()
        {
            try
            {
                if (m_LoggedIn)
                {
                    string resumePath = createFilePath();
                    string profilePicturePath = FacebookEngine.Instance.DownloadProfilePhoto();
                    this.commandButtonCreateCv.Enabled = false;
                    m_pdf = new PdfDocumentFile(profilePicturePath, resumePath, m_CurrentUserInformation);
                    commandButtonCreateCv.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sendCVToEmail()
        {
            try
            {
                commandButtonSendToMail.Enabled = false;

                if (m_pdf != null)
                {
                    m_pdf.SendPdfToEmail();                   
                }
                else
                {
                    MessageBox.Show(k_ResumeNotFound, k_Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, k_Error);
            }

            commandButtonSendToMail.Enabled = true;
        }

        public class FetchResumeInformationCommand : FormFacebookAppCommand
        {
            public override void Execute()
            {
                Client.updateUserInformationBindingSource();
            }
        }

        public class SendResumeToMailCommand : FormFacebookAppCommand
        {
            public override void Execute()
            {
                Client.sendCVToEmail();
            }
        }

        public class CreateResumeCommand : FormFacebookAppCommand
        {
            public override void Execute()
            {
                Client.createResume();
            }
        }
    }
}
