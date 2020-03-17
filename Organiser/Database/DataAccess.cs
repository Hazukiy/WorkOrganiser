using LiteDB;
using Organiser.Models;
using Organiser.Models.Enums;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Organiser.Database
{
    public class DataAccess
    {
        #region Singleton
        private static DataAccess _instance;
        public static DataAccess Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DataAccess();
                }
                return _instance;
            }
        }
        #endregion

        #region Private Methods
        private readonly string _collectionName = "Entries";
        private static string _databasePath;
        private static string _databaseFile;
        private static string _fullPath;
        private static bool _hideCompleted;
        #endregion

        private string DatabaseConnection
        {
            get
            {
                if(string.IsNullOrEmpty(_fullPath))
                {
                    _fullPath = Path.Combine(_databasePath, _databaseFile);
                }
                return _fullPath;
            }
        }

        private DataAccess()
        {
            //Read in config values
            if(string.IsNullOrEmpty(ConfigurationManager.AppSettings["DatabasePath"]))
            {
                ConfigurationManager.AppSettings["DatabasePath"] = @"D:\";
                Trace.WriteLine($"DatabasePath config value is empty; setting default to: {ConfigurationManager.AppSettings["DatabasePath"]}");
            }

            if(string.IsNullOrEmpty(ConfigurationManager.AppSettings["DatabaseFile"]))
            {
                ConfigurationManager.AppSettings["DatabaseFile"] = "ProjectOrganiser.db";
                Trace.WriteLine($"DatabaseFile config value is empty; setting default to: {ConfigurationManager.AppSettings["DatabaseFile"]}");
            }

            if(!bool.TryParse(ConfigurationManager.AppSettings["HideCompleted"], out bool hideCompletedResult))
            {
                hideCompletedResult = true;
                Trace.WriteLine($"Failed to parse config value HideCompleted; setting default to: true");
            }

            //Set config values
            _databasePath = ConfigurationManager.AppSettings["DatabasePath"].ToString();
            _databaseFile = ConfigurationManager.AppSettings["DatabaseFile"].ToString();
            _hideCompleted = hideCompletedResult;
        }

        public void InsertNewRecord(ProjectEntry entry)
        {
            try
            {
                using (var db = new LiteDatabase(DatabaseConnection))
                {
                    var col = db.GetCollection<ProjectEntry>(_collectionName);
                    col.Insert(entry);

                    Trace.WriteLine($"New entry: [{entry.Title}] added.");
                }
            }
            catch(Exception ex)
            {
                Trace.WriteLine(ex);
            }
        }

        public List<ProjectEntry> LoadRecords()
        {
            List<ProjectEntry> retVal = null;
            try
            {
                using (var db = new LiteDatabase(DatabaseConnection))
                {
                    var col = db.GetCollection<ProjectEntry>(_collectionName).FindAll();

                    if(_hideCompleted)
                    {
                        retVal = col.Where(x => x.State != ProjectState.Complete).ToList();
                    }
                    else
                    {
                        retVal = col.ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex);
            }
            return retVal;
        }


        public void DeleteRecord(ProjectEntry record)
        {
            try
            {
                using (var db = new LiteDatabase(DatabaseConnection))
                {
                    var col = db.GetCollection<ProjectEntry>(_collectionName);
                    col.Delete(record.Id);

                    Trace.WriteLine($"Entry: {record} deleted.");
                }
            }
            catch(Exception ex)
            {
                Trace.WriteLine(ex);
            }
        }

        public void UpdateRecord(ProjectEntry record)
        {
            try
            {
                using (var db = new LiteDatabase(DatabaseConnection))
                {
                    var col = db.GetCollection<ProjectEntry>(_collectionName);
                    col.Update(record);

                    Trace.WriteLine($"Entry: {record} updated.");
                }
            }
            catch(Exception ex)
            {
                Trace.WriteLine(ex);
            }
        }
    }
}
