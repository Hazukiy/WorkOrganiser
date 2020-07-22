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
        private readonly string _systemCollectionName = "System";
        private static string _databasePath;
        private static string _databaseFile;
        private static string _fullPath;
        private static string _backupPath;
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

        public string BackupLocation
        {
            get
            {
                if (string.IsNullOrEmpty(_backupPath))
                {
                    _backupPath = Path.Combine(_databasePath, "Backups", $"{DateTime.Now.ToString("dd-MM-yyyy")}");
                }

                return _backupPath;
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

            //Set config values
            _databasePath = ConfigurationManager.AppSettings["DatabasePath"].ToString();
            _databaseFile = ConfigurationManager.AppSettings["DatabaseFile"].ToString();
        }

        public bool ProcessDatabaseBackup()
        {
            var retVal = false;
            try
            {
                using (var db = new LiteDatabase(DatabaseConnection))
                {
                    var col = db.GetCollection<SystemEntry>(_systemCollectionName);

                    var record = col.FindOne(x => x.Id == 1);
                    if (record != null)
                    {
                        if (record.LastDatabaseUpdate < DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy")))
                        {
                            //Update last update time
                            record.LastDatabaseUpdate = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy"));
                            col.Update(record);
                            retVal = true;
                        }
                        else
                        {
                            retVal = false;
                        }
                    }
                    else
                    {
                        var newRecord = new SystemEntry()
                        {
                            Id = 1,
                            LastDatabaseUpdate = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy"))
                        };
                        col.Insert(newRecord);
                        retVal = true;
                    }
                }

                //Begin backup of the main database
                if (retVal)
                {
                    //Firstly create directory
                    if (!Directory.Exists(BackupLocation))
                    {
                        Directory.CreateDirectory(BackupLocation);
                    }

                    //Copy across main db to new backup path
                    File.Copy(DatabaseConnection, $"{BackupLocation}/{_databaseFile}");
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ThrowError(ex);
            }

            return retVal;
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
                ErrorHandler.ThrowError(ex);
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
                    retVal = col.ToList();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ThrowError(ex);
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
                ErrorHandler.ThrowError(ex);
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
                ErrorHandler.ThrowError(ex);
            }
        }
    }
}
