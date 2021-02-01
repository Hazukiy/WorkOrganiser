using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Organiser.Models;
using LiteDB;

namespace Organiser.Database
{
    public class DataAccess
    {
        #region Fields
        private static DataAccess _instance;
        private readonly string _collectionName = "Entries";
        private readonly string _notesCollection = "Notes";
        private readonly string _systemCollectionName = "System";
        #endregion

        #region Properties
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

        private DataAccess()
        {
        }

        public bool ProcessDatabaseBackup()
        {
            var retVal = false;
            try
            {
                using (var db = new LiteDatabase(Constants.DatabaseConnection))
                {
                    var col = db.GetCollection<SystemEntry>(_systemCollectionName);

                    var record = col.FindOne(x => x.Id == 1);
                    if (record != null)
                    {
                        if (record.LastDatabaseUpdate < DateTime.Parse(DateTime.Now.ToString(Constants.StandardDateTimeFormat)))
                        {
                            //Update last update time
                            record.LastDatabaseUpdate = DateTime.Parse(DateTime.Now.ToString(Constants.StandardDateTimeFormat));
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
                            LastDatabaseUpdate = DateTime.Parse(DateTime.Now.ToString(Constants.StandardDateTimeFormat))
                        };
                        col.Insert(newRecord);
                        retVal = true;
                    }
                }

                //Begin backup of the main database
                if (retVal)
                {
                    //Firstly create directory
                    if (!Directory.Exists(Constants.BackupLocation))
                    {
                        Directory.CreateDirectory(Constants.BackupLocation);
                    }

                    //Copy across main db to new backup path
                    File.Copy(Constants.DatabaseConnection, $"{Constants.BackupLocation}/{Constants.DatabaseName}");
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
                using (var db = new LiteDatabase(Constants.DatabaseConnection))
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
                using (var db = new LiteDatabase(Constants.DatabaseConnection))
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
                using (var db = new LiteDatabase(Constants.DatabaseConnection))
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
                using (var db = new LiteDatabase(Constants.DatabaseConnection))
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

        public void UpsertNote(ProjectNotes entry)
        {
            try
            {
                using (var db = new LiteDatabase(Constants.DatabaseConnection))
                {
                    var col = db.GetCollection<ProjectNotes>(_notesCollection);
                    col.Upsert(entry);

                    Trace.WriteLine($"Entry: {entry.Id} Updated/Inserted");
                }

            }
            catch (Exception ex)
            {
                ErrorHandler.ThrowError(ex);
            }
        }

        public List<ProjectNotes> GetHistoryNotes()
        {
            List<ProjectNotes> retVal = null;
            try
            {
                using (var db = new LiteDatabase(Constants.DatabaseConnection))
                {
                    var today = DateTime.Parse(DateTime.Now.ToString(Constants.StandardDateTimeFormat));
                    var col = db.GetCollection<ProjectNotes>(_notesCollection).FindAll();
                    retVal = col.Where(x => x.Created != today).ToList();

                    Trace.WriteLine($"Retrieved {retVal.Count} Notes");
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ThrowError(ex);
            }
            return retVal;
        }

        public ProjectNotes GetTodaysNotes()
        {
            ProjectNotes retVal = null;
            try
            {
                using (var db = new LiteDatabase(Constants.DatabaseConnection))
                {
                    var today = DateTime.Parse(DateTime.Now.ToString(Constants.StandardDateTimeFormat));
                    var col = db.GetCollection<ProjectNotes>(_notesCollection).FindOne(x => x.Created == today);
                    retVal = col;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ThrowError(ex);
            }
            return retVal;
        }

        public void DeleteCollection()
        {
            try
            {
                using (var db = new LiteDatabase(Constants.DatabaseConnection))
                {
                    var today = DateTime.Parse(DateTime.Now.ToString(Constants.StandardDateTimeFormat));
                    var col = db.GetCollection<ProjectNotes>(_notesCollection);
                    var ret = col.DeleteMany(x => x.Id > 0);

                    Trace.WriteLine($"Return val: {ret}");
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ThrowError(ex);
            }
        }

    }
}
