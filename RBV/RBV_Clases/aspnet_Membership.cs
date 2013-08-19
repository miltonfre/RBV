using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Security;
using System.Collections;


namespace RBV_Clases
{
    class aspnet_Membership 
    {
        #region Fields
        private aspnet_Users user;
        private int id;
        private string password;
        private int passwordFormat;
        private string passwordSalt;
        private string email;
        private string loweredEmail;
        private string passwordQuestion;
        private string passwordAnswer;
        private string comments;
        private bool isApproved;
        private bool isLockedOut = false;
        private DateTime creationDate = DateTime.Now;
        private DateTime lastActivityDate = DateTime.Now;
        private DateTime lastLoginDate = DateTime.Now;
        private DateTime lastLockedOutDate = DateTime.Now;
        private DateTime lastPasswordChangeDate = DateTime.Now;
        private int failedPasswordAttemptCount = 0;
        private DateTime failedPasswordAttemptWindowStart = DateTime.Now;
        private int failedPasswordAnswerAttemptCount = 0;
        private DateTime failedPasswordAnswerAttemptWindowStart = DateTime.Now;
        private IList applications = new ArrayList();
        private bool licencia;
        #endregion Fields

        #region Properties
        public aspnet_Users User
        {
            get { return user; }
            set { user= value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public int PasswordFormat
        {
            get { return passwordFormat; }
            set { passwordFormat = value; }
        }
        public string PasswordSalt
        {
            get { return passwordSalt; }
            set { passwordSalt = value; }
        }
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                LoweredEmail = value.ToLower();
            }
        }
        public string LoweredEmail
        {
            get { return loweredEmail; }
            set { loweredEmail = value; }
        }
        public string PasswordQuestion
        {
            get { return passwordQuestion; }
            set { passwordQuestion = value; }
        }
        public string PasswordAnswer
        {
            get { return passwordAnswer; }
            set { passwordAnswer = value; }
        }
        public string Comments
        {
            get { return comments; }
            set { comments = value; }
        }
        public bool IsApproved
        {
            get { return isApproved; }
            set { isApproved = value; }
        }
        public bool IsLockedOut
        {
            get { return isLockedOut; }
            set { isLockedOut = value; }
        }
        public DateTime CreationDate
        {
            get { return creationDate; }
            set { creationDate = value; }
        }
        public DateTime LastActivityDate
        {
            get { return lastActivityDate; }
            set { lastActivityDate = value; }
        }
        public DateTime LastLoginDate
        {
            get { return lastLoginDate; }
            set { lastLoginDate = value; }
        }
        public DateTime LastLockedOutDate
        {
            get { return lastLockedOutDate; }
            set { lastLockedOutDate = value; }
        }
        public DateTime LastPasswordChangeDate
        {
            get { return lastPasswordChangeDate; }
            set { lastPasswordChangeDate = value; }
        }
        public int FailedPasswordAttemptCount
        {
            get { return failedPasswordAttemptCount; }
            set { failedPasswordAttemptCount = value; }
        }
        public DateTime FailedPasswordAttemptWindowStart
        {
            get { return failedPasswordAttemptWindowStart; }
            set { failedPasswordAttemptWindowStart = value; }
        }
        public int FailedPasswordAnswerAttemptCount
        {
            get { return failedPasswordAnswerAttemptCount; }
            set { failedPasswordAnswerAttemptCount = value; }
        }
        public DateTime FailedPasswordAnswerAttemptWindowStart
        {
            get { return failedPasswordAnswerAttemptWindowStart; }
            set { failedPasswordAnswerAttemptWindowStart = value; }
        }
        public IList Applications
        {
            get { return applications; }
            set { applications = value; }
        }
        public bool Licencia
        {
            get { return licencia; }
            set { licencia = value; }
        }
       
        #endregion Properties

         #region Initialization
        public aspnet_Membership() : base()
        {
        }
        public aspnet_Membership(int id)
            : base()
        {
            Id = id;
        }
        public aspnet_Membership(string name)
           
        {
        }
        #endregion Initialization

    
    }
}
