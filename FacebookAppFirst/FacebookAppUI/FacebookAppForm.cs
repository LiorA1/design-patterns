using System;
using System.Threading;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using FacebookAppLogic;

namespace FacebookAppUI
{
    public partial class FormFacebookApp : Form
    {
        private const string k_Error = "Eror";
        private bool m_LoggedIn;
        private FacebookEngine m_FacebookAppEngine;
        private FacebookAppSettings m_FormSettings;
        private PdfDocumentFile m_pdf;
        private UserInformation m_CurrentUserInformation;
        private managedDelayedPost m_delayedPost;

        public FormFacebookApp()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.Manual;

            m_FacebookAppEngine = new FacebookEngine();

            m_LoggedIn = m_FacebookAppEngine.RememberUser;

            m_FormSettings = FacebookAppSettings.LoadAppSettingsFromFile();

            if (m_FormSettings.RememberUser)
            {
                checkBoxRemember.Checked = m_FormSettings.RememberUser;
                Location = m_FormSettings.LastWindowLocation;
                Size = m_FormSettings.LastWindowSize;

                if(m_LoggedIn)
                {
                    fetchLoggedInUser(); 
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
                ButtonResume.Enabled = true;

                m_FacebookAppEngine.Login();
                fetchLoggedInUser();
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
                m_FacebookAppEngine.Logout();
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
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        /* populate the basic (Intro) listBox */ 
        private void populateIntro()
        {
            try
            {
                if (m_FacebookAppEngine.CurrentUser != null)
                {
                   listBoxIntro.Items.Add(this.m_FacebookAppEngine.GetName());
                   listBoxIntro.Items.Add(this.m_FacebookAppEngine.GetGender());
                   listBoxIntro.Items.Add(this.m_FacebookAppEngine.GetBirthday());
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
                if (!string.IsNullOrEmpty(m_FacebookAppEngine.GetProfilePictureUrl()))
                {
                    this.pictureBoxProfilePicture.LoadAsync(this.m_FacebookAppEngine.GetProfilePictureUrl());
                }
                else
                {
                    pictureBoxProfilePicture.Image = pictureBoxProfilePicture.ErrorImage;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        private void populateCoverPicture()
        {
            try
            {
                if (!string.IsNullOrEmpty(m_FacebookAppEngine.GetCoverPictureUrl()))
                {
                    pictureBoxCoverPicture.LoadAsync(this.m_FacebookAppEngine.GetCoverPictureUrl());
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
                this.listBoxFriends.DisplayMember = displayMemberTitle;
                if (this.m_FacebookAppEngine.FetchUserFriends().Count == 0)
                {
                    this.listBoxFriends.Items.Add(noFriendsText);
                }
                else
                {
                    foreach (FacebookWrapper.ObjectModel.User friend in this.m_FacebookAppEngine.FetchUserFriends())
                    {
                        this.listBoxFriends.Items.Add(friend);
                        friend.ReFetch(FacebookWrapper.ObjectModel.DynamicWrapper.eLoadOptions.Full);
                    }
                }
            }
            catch(Exception ex)
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
                if (m_FacebookAppEngine.FetchUserPosts().Count == 0)
                {
                    listBoxPosts.Items.Add(noPostText);
                }
                else
                {
                    foreach (FacebookWrapper.ObjectModel.Post post in m_FacebookAppEngine.FetchUserPosts())
                    {
                        if (post.Message != null)
                        {
                            listBoxPosts.Items.Add(post.Message);
                        }
                        else if (post.Caption != null)
                        {
                            listBoxPosts.Items.Add(post.Caption);
                        }
                        else
                        {
                            listBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                            //// maybe link ?
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                listBoxPosts.Items.Add("Failed to retrieve Posts :(");
            }
        }

        /* populate all user Photos in panelPictures */
        private void populatePhotos()
        {
            try
            {
                int xCord = 12;
                int yCord = 12;
                Size smallSize = new Size(50, 50);
                Point stratPoint = new Point(xCord, yCord);

                if (m_FacebookAppEngine.FetchUserPhotos().Count == 0)
                {
                    this.flowLayoutPanelPictures.Controls.Add(new Control("No Images Found"));
                }
                else
                {
                    foreach (FacebookWrapper.ObjectModel.Photo photo in m_FacebookAppEngine.FetchUserPhotos())
                    {
                        PictureBox pic = new PictureBox();
                        pic.LoadAsync(photo.PictureNormalURL);
                        pic.Size = smallSize;
                        pic.Location = stratPoint;
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;

                        this.flowLayoutPanelPictures.Controls.Add(pic);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }

        /* populate the group listbox */
        private void populateGroups()
        {
            try
            {
                if (m_FacebookAppEngine.FetchUserGroups().Count == 0)
                {
                    this.listBoxGroups.Items.Add("No Groups to retrieve :(");
                }
                else
                {
                    foreach (FacebookWrapper.ObjectModel.Group group in m_FacebookAppEngine.FetchUserGroups())
                    {
                        listBoxGroups.Items.Add(group.Name.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.listBoxGroups.Items.Add("Failed to retrieve Groups  :(");
            }
        }

        /* Clean the Form from data */
        private void resetUI()
        {
            try
            {
                pictureBoxProfilePicture.Image = null;
                pictureBoxCoverPicture.Image = null;
                flowLayoutPanelPictures.Controls.Clear();
                pictureBoxProfilePicture.Image = null;
                pictureBoxCoverPicture.Image = null;
                this.listBoxPosts.Items.Clear();
                this.listBoxGroups.Items.Clear();

                this.listBoxFriends.Items.Clear();
                this.listBoxIntro.Items.Clear();
                this.pictureBoxOfSelectedFriend.Image = null;

                this.textBoxBasicInformation.Text = string.Empty;
                this.textBoxEducation.Text = string.Empty;
                this.textBoxLanguages.Text = string.Empty;
                this.textBoxWork.Text = string.Empty;
            }
            catch(Exception ex)
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
                    this.m_FacebookAppEngine.PostStatus(this.textBoxPost.Text);
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
   
        private void resumeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_LoggedIn)
                {
                    string resumePath = createFilePath();
                    string profilePicturePath = m_FacebookAppEngine.DownloadProfilePhoto();

                    this.ButtonResume.Enabled = false;
                    m_pdf = new PdfDocumentFile();
                    m_pdf.CreateResume(profilePicturePath, resumePath, m_CurrentUserInformation);
                    buttonSendToMail.Enabled = true;
                    ButtonResume.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                        this.m_FacebookAppEngine.RememberUser = true; /* Attention : Only If logged with some user !*/
                    }
                    else
                    {
                        this.m_FacebookAppEngine.RememberUser = false; /* Attention : Only If logged with some user !*/
                    }
                }
                else
                {
                    this.m_FormSettings.RememberUser = false;
                    this.m_FacebookAppEngine.RememberUser = false; /* Attention : Only If logged with some user !*/
                }
            }
            catch(Exception ex)
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
                        this.m_FacebookAppEngine.RememberUser = this.checkBoxRemember.Checked;
                    }

                    this.m_FacebookAppEngine.OnEngineClosing();
                }
                else
                {
                    this.handleLogout();

                    if (!this.m_LoggedIn)
                    {
                        this.m_FacebookAppEngine.RememberUser = this.m_LoggedIn;
                        this.m_FacebookAppEngine.OnEngineClosing();
                    }
                }
            }
            catch(Exception ex)
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

        private void tableLayoutPanelResume_Paint(object sender, PaintEventArgs e)
        {
        }

        private void buttonSendToMail_Click(object sender, EventArgs e)
        {
            buttonSendToMail.Enabled = false;
            m_pdf.SendPdfToEmail();
        }

        private void flowLayoutPanelPictures_Paint(object sender, PaintEventArgs e)
        {
        }

        private void buttonFetchResumeInformationFromFacebook_Click(object sender, EventArgs e)
        {
            if (m_LoggedIn)
            {
                m_CurrentUserInformation = new UserInformation(m_FacebookAppEngine);
                try
                {
                    this.textBoxBasicInformation.Text = m_CurrentUserInformation.Name + Environment.NewLine + m_CurrentUserInformation.Gender
                    + Environment.NewLine + m_CurrentUserInformation.Address + Environment.NewLine + m_CurrentUserInformation.Email;
                    this.textBoxLanguages.Text = m_CurrentUserInformation.Languages;
                    this.textBoxEducation.Text = m_CurrentUserInformation.Educations;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBoxLanguages_TextChanged(object sender, EventArgs e)
        {
            m_CurrentUserInformation.Languages = textBoxLanguages.Text;
        }

        private void textBoxEducation_TextChanged(object sender, EventArgs e)
        {
            m_CurrentUserInformation.Educations = textBoxEducation.Text;
        }

        private void textBoxWork_TextChanged(object sender, EventArgs e)
        {
            m_CurrentUserInformation.Work = textBoxWork.Text;
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
                        this.m_delayedPost = new managedDelayedPost(this.m_FacebookAppEngine, dateToPublishPost, this.textBoxAsyncPost.Text);

                        if(this.m_delayedPost.InnerException != null)
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
            catch(Exception ex)
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
                    if(this.m_delayedPost.InnerException != null)
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, k_Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }
    }
}
