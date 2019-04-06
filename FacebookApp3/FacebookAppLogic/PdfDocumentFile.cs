﻿using System;
using System.IO;
using System.Reflection;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.Rendering;

namespace FacebookAppLogic
{
    public class PdfDocumentFile
    {
        public enum eTitlesLocation
        {
            BasicInformation
        }

        private Document m_Document;
        private UserInformationAdapter m_UI;
        private string m_PdfPath;
        private string m_PicturePath;

        public PdfDocumentFile(string i_PicturePath, string io_PdfPath, UserInformationAdapter i_User)
        {
            const string title = "My Resume";
            string Subject = string.Format("The resume of: {0}", i_User.Name);

            try
            {
                m_UI = i_User;
                m_PdfPath = io_PdfPath;
                m_PicturePath = i_PicturePath;
                m_Document = new Document();
                m_Document.Info.Title = title;
                m_Document.Info.Subject = Subject;
                m_Document.Info.Author = i_User.Name;
                DefineStyles();
                createPage();
                savePdf();
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }

        private void savePdf()
        {
            bool isUnicode = true;
            bool closeStream = true;
            PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(!isUnicode);
            pdfRenderer.Document = m_Document;
            pdfRenderer.RenderDocument();
            Stream stream = null;

            using (stream = new FileStream(m_PdfPath, FileMode.Create))
            {
                pdfRenderer.PdfDocument.Save(stream, closeStream);
            }
        }

        public void SendPdfToEmail()
        {
            try
            {
                MailDelivery one = new MailDelivery(m_UI.Email);
                one.AddAttachment(m_PdfPath);
                one.Send();                
            }
            catch (Exception ex)
            {
                throw ex;
            }           
        }

        private void DefineStyles()
        {
            const string font = "Calibri";
            const string tab = "12cm";

            Style style = m_Document.Styles[StyleNames.Normal];
            style.Font.Name = font;
            style.ParagraphFormat.AddTabStop(tab, TabAlignment.Left);
        }

        private void populateInformation(Section o_section)
        {
            AddUserInformationParagraphs(o_section);            
        }

        private void AddUserInformationParagraphs(Section io_section)
        {
            const string dateFormat = "d/M/yyyy";
            const string space = "0.5cm";
            const int fontSize = 12;
            const int titleFontSize = 14;
            Color red = Color.FromRgb(139, 0, 0);
            const char colon = ':';

            try
            {
                Type typeOfMe = m_UI.GetType();
                FormattedText baseInformationTitleStyle = null;
                string date = DateTime.Now.ToString(dateFormat);
                Paragraph UserInformationParagraph = io_section.AddParagraph(date);

                foreach (PropertyInfo propInfo in typeOfMe.GetProperties())
                {
                    UserInformationParagraph = io_section.AddParagraph();
                    UserInformationParagraph.Format.SpaceBefore = space;
                    UserInformationParagraph.Format.Font.Size = fontSize;
                    object fieldValue = propInfo.GetValue(m_UI, null);
                    string fieldName = propInfo.Name;

                    baseInformationTitleStyle = UserInformationParagraph.AddFormattedText(fieldName, TextFormat.Underline);
                    baseInformationTitleStyle.Color = red;
                    baseInformationTitleStyle.Size = titleFontSize;
                    baseInformationTitleStyle.AddChar(colon);
                    UserInformationParagraph.AddLineBreak();
                    UserInformationParagraph.AddFormattedText(fieldValue as string, TextFormat.Bold);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }     
        }

        private void createPage()
        {
            Section section = m_Document.AddSection();
            setProfilePhoto(section);
            populateInformation(section);
        }

        private void setProfilePhoto(Section i_Section)
        {
            const string height = "2.5cm";
            const string Width = "2.5cm";

            Paragraph paragraph = i_Section.AddParagraph();
            paragraph.Format.Alignment = ParagraphAlignment.Right;
            Image image = paragraph.AddImage(m_PicturePath);
            image.Height = height;
            image.Width = Width;
        }
    }
}
