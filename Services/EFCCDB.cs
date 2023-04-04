using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCC.Models;
using LiteDB;
namespace EFCC.Services
{
    public class EFCCDB
    {
        private static string DBPath { get; set; } = "EFCC.db";
        private static LiteDatabase EFCCLiteDB = new LiteDatabase(DBPath);
        private static ILiteCollection<CaseFile> Collection { get; set; } = EFCCLiteDB.GetCollection<CaseFile>(nameof(CaseFile));
        private static ILiteCollection<UserLogin> loginCollection { get; set; } = EFCCLiteDB.GetCollection<UserLogin>(nameof(UserLogin));
        public static CaseFile SaveCase(CaseFile caseFile)
        {
            Collection.Upsert(caseFile);
            return caseFile;
        }
        public static List<CaseFile> GetAllCases()
        {
            return Collection.FindAll().ToList();
        }
        public static CaseFile GetByCaseTitle(String caseTitle)
        {
            return Collection.FindOne(caseFile => caseFile.Title == caseTitle);
        }
        #region
        public static UserLogin SignUp(UserLogin userData)
        {
            loginCollection.Upsert(userData);
            return userData;
        }
        public static UserLogin GetLoginData(String userName)
        {
            return loginCollection.FindOne(loginData => loginData.Name.Equals(userName));
        }
        #endregion
    }
}
