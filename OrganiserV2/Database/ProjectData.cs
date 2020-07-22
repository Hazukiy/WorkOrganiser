using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrganiserV2.Utils;
using OrganiserV2.Models;
using System.Linq;
using LiteDB;

namespace OrganiserV2.Database
{
    public class ProjectData
    {
        #region Singleton
        private static ProjectData _instance;
        public static ProjectData Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ProjectData();
                }

                return _instance;
            }
        }
        #endregion

        private readonly string CollectionName = "Entries";

        private ProjectData()
        {
        }

        public List<ProjectInfo> GetActiveProjects()
        {
            try
            {
                using (var db = new LiteDatabase(DatabaseSettings.DatabasePath))
                {
                    var col = db.GetCollection<ProjectInfo>(CollectionName);

                    return col.FindAll()
                        .Where(x => x.State == ProjectState.Active)
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.CatchError(ex);
            }

            return null;
        }

        public List<ProjectInfo> GetOldProjects()
        {
            try
            {
                using (var db = new LiteDatabase(DatabaseSettings.DatabasePath))
                {
                    var col = db.GetCollection<ProjectInfo>(CollectionName);

                    return col.FindAll()
                        .Where(x => x.State == ProjectState.Complete)
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.CatchError(ex);
            }

            return null;
        }






    }
}
