using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using OrganiserV2.Models;
using OrganiserV2.Utils;

namespace OrganiserV2.Database
{
    public class NotesData
    {
        private readonly string CollectionName = "NotesCollection";

        #region Singleton
        private static NotesData _instance;
        public static NotesData Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new NotesData();
                }

                return _instance;
            }
        }
        #endregion

        private NotesData()
        {
        }

        public NotesInfo GetYesterdaysNote()
        {
            try
            {
                using (var db = new LiteDatabase(DatabaseSettings.DatabasePath))
                {
                    var col = db.GetCollection<NotesInfo>(CollectionName);

                    var yesterdayDate = DateTime.Parse(DateTime.Now.ToString("d")).AddDays(-1);

                    return col.FindOne(x => x.Date.Equals(yesterdayDate));
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.CatchError(ex);
            }

            return null;
        }

        public NotesInfo GetTodaysNote()
        {
            try
            {
                using (var db = new LiteDatabase(DatabaseSettings.DatabasePath))
                {
                    var col = db.GetCollection<NotesInfo>(CollectionName);

                    var today = DateTime.Parse(DateTime.Now.ToString("d"));

                    return col.FindOne(x => x.Date.Equals(today));
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.CatchError(ex);
            }

            return null;
        }

        public bool UpdateTodaysNote(NotesInfo note)
        {
            try
            {
                using (var db = new LiteDatabase(DatabaseSettings.DatabasePath))
                {
                    var col = db.GetCollection<NotesInfo>(CollectionName);

                    return col.Upsert(note);
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.CatchError(ex);
            }

            return false;
        }
    }
}
