using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Organiser.Database;
using Organiser.Models;
using Organiser.Models.Enums;

namespace Organiser
{
    public partial class MainWindow : Form
    {
        private static BindingList<ProjectEntry> _entries = new BindingList<ProjectEntry>();
        private bool _hasEditOpen;

        public MainWindow()
        {
            InitializeComponent();

            Text = $"Project Organiser v{Assembly.GetExecutingAssembly().GetName().Version}";

            foreach(var item in DataAccess.Instance.LoadRecords())
            {
                _entries.Add(item);
            }

            //Set data sources
            listBoxOutput.DataSource = _entries
                .OrderByDescending(x => x.State == ProjectState.Active)
                .OrderByDescending(x => x.State == ProjectState.Validation)
                .ToList();

            ddlState.DataSource = Enum.GetValues(typeof(ProjectState));
            ddlFilter.DataSource = Enum.GetValues(typeof(ProjectState));
            ddlState.SelectedIndex = 0;
            ddlFilter.SelectedIndex = -1;
            HideCompleted.Checked = true;

            //Backup database
            var result = DataAccess.Instance.ProcessDatabaseBackup();
            if (result)
            {
                DisplayDialog($"Database has been backed up to: {Constants.BackupLocation}");
            }
        }

        #region Control Events
        private void HideCompleted_CheckedChanged(object sender, EventArgs e)
        {
            if (HideCompleted.Checked)
            {
                listBoxOutput.DataSource = _entries
                    .Where(x => x.State != ProjectState.Complete)
                    .OrderByDescending(x => x.State == ProjectState.Active)
                    .OrderByDescending(x => x.State == ProjectState.Validation)
                    .ToList();
            }
            else
            {
                RefreshOutput();
            }
        }

        private void btn_InsertRecord_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    var connectionDetails = new ConnectionDetails()
                    {
                        Username = txtBoxUsername.Text,
                        Password = txtBoxPassword.Text,
                        ExtraValue = txtBoxExtraValue.Text
                    };


                    var hostDetails = !string.IsNullOrEmpty(txtBoxHostPort.Text) ? txtBoxHostPort.Text.Split(':') : new string[] { };
                    if(hostDetails.Length > 0)
                    {
                        connectionDetails.Host = hostDetails[0];
                        connectionDetails.Port = hostDetails[1];
                    }
                    else
                    {
                        connectionDetails.Host = string.Empty;
                        connectionDetails.Port = string.Empty;
                    }

                    //Construct new project object
                    var projectEntry = new ProjectEntry()
                    {
                        Title = txtBoxTitle.Text,
                        URL = txtBoxLink.Text,
                        Comments = txtBoxComments.Text,
                        State = (ProjectState)ddlState.SelectedItem,
                        DateCreated = DateTime.Now,
                        Details = connectionDetails
                    };

                    _entries.Add(projectEntry);

                    DataAccess.Instance.InsertNewRecord(projectEntry);

                    CleanupForm();

                    RefreshOutput();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.ThrowError(ex);
            }
        }

        private void listBoxOutput_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                var selected = listBoxOutput.SelectedItem as ProjectEntry;
                if (selected != null)
                {
                    if (!_hasEditOpen)
                    {
                        //Open quick edit window
                        EditWindow edit = new EditWindow(selected);
                        edit.Text = selected.Title;
                        edit.StartPosition = FormStartPosition.CenterScreen;
                        edit.FormClosed += Edit_FormClosed;
                        edit.ChangesMade += EntryChangesCallback;
                        edit.RecordDeleted += RecordDeletedCallback;
                        edit.Show();
                        _hasEditOpen = true;
                    }
                }
            }
            catch(Exception ex)
            {
                ErrorHandler.ThrowError(ex);
            }
        }

        private void Edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            _hasEditOpen = false;
        }

        private void ddlFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ddlFilter.SelectedIndex != -1)
                {
                    var selected = (ProjectState)ddlFilter.SelectedItem;
                    if(selected == ProjectState.None)
                    {
                        RefreshOutput();
                    }
                    else
                    {
                        listBoxOutput.DataSource = _entries.Where(x => x.State == selected).ToList();
                    }
                }
            }
            catch(Exception ex)
            {
                ErrorHandler.ThrowError(ex);
            }
        }

        private void listBoxOutput_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            var item = ((ListBox)sender).Items[e.Index];
            var data = (ProjectEntry)((ListBox)sender).Items[e.Index];

            Brush itemColor = Brushes.White;
            switch (data.State)
            {
                case ProjectState.Active:
                    itemColor = Constants.ActiveItem;
                    break;
                case ProjectState.Blocked:
                    itemColor = Constants.BlockedItem;
                    break;
                case ProjectState.Complete:
                    itemColor = Constants.CompletedItem;
                    break;
                case ProjectState.Validation:
                    itemColor = Constants.ValidationItem;
                    break;
            }

            //Draw item
            e.Graphics.DrawString(item.ToString(), e.Font, itemColor, e.Bounds, StringFormat.GenericDefault);

            e.DrawFocusRectangle();
            listBoxOutput.SelectedIndex = -1;
        }

        private void txtBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxSearch.Text))
            {
                SearchEntry(txtBoxSearch.Text.ToLower().Trim());
            }
            else
            {
                RefreshOutput();
            }
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxSearch.Text))
            {
                RefreshOutput();
            }
        }
        #endregion

        private List<ProjectEntry> GetProjects()
        {
            if(HideCompleted.Checked)
            {
                return _entries
                    .Where(x => x.State != ProjectState.Complete)
                    .OrderByDescending(x => x.State == ProjectState.Active)
                    .OrderByDescending(x => x.State == ProjectState.Validation)
                    .ToList();
            }
            else
            {
                return _entries
                    .OrderByDescending(x => x.State == ProjectState.Active)
                    .OrderByDescending(x => x.State == ProjectState.Validation)
                    .ToList();
            }                   
        }

        /// <summary>
        /// Validates that the form data needed is there
        /// </summary>
        /// <returns></returns>
        private bool ValidateForm()
        {
            if (string.IsNullOrEmpty(txtBoxTitle.Text))
            {
                DisplayDialog("Title is empty.");
                return false;
            }

            if (string.IsNullOrEmpty(txtBoxLink.Text))
            {
                DisplayDialog("Link is empty.");
                return false;
            }

            if (ddlState.SelectedIndex <= -1)
            {
                DisplayDialog("Select a state.");
                return false;
            }

            if(!string.IsNullOrEmpty(txtBoxHostPort.Text))
            {
                if (!txtBoxHostPort.Text.Contains(':'))
                {
                    DisplayDialog("Host/Port format: 1.1.1.1:80. Include : ");
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Refreshes the output window
        /// </summary>
        private void RefreshOutput()
        {
            try
            {
                //Clear filter
                ddlFilter.SelectedIndex = -1;
                txtBoxSearch.Text = string.Empty;

                //Clear output
                listBoxOutput.DataSource = null;
                listBoxOutput.Items.Clear();

                //Then sort & reassign values
                listBoxOutput.DataSource = GetProjects();
                listBoxOutput.Refresh();
            }
            catch(Exception ex)
            {
                ErrorHandler.ThrowError(ex);
            }
        }

        /// <summary>
        /// Filters entries 
        /// </summary>
        /// <param name="filter"></param>
        private void SearchEntry(string filter)
        {
            //Clear filter
            ddlFilter.SelectedIndex = -1;

            //Clear output
            listBoxOutput.DataSource = null;
            listBoxOutput.Items.Clear();

            //Then sort & reassign values
            listBoxOutput.DataSource = _entries
                .Where(x => x.Title.ToLower().Contains(filter))
                .ToList();
        }

        /// <summary>
        /// Cleans up form after insert use
        /// </summary>
        private void CleanupForm()
        {
            txtBoxTitle.Text = string.Empty;
            txtBoxLink.Text = string.Empty;
            txtBoxComments.Text = string.Empty;
            txtBoxSearch.Text = string.Empty;
            txtBoxHostPort.Text = string.Empty;
            txtBoxUsername.Text = string.Empty;
            txtBoxPassword.Text = string.Empty;
            txtBoxExtraValue.Text = string.Empty;
            ddlState.SelectedIndex = 0;
        }

        /// <summary>
        /// Displays a dialog
        /// </summary>
        /// <param name="content"></param>
        /// <param name="isError"></param>
        private void DisplayDialog(string content, bool isError = false)
        {
            try
            {
                var caption = isError ? "Error" : "Warning";
                var icon = isError ? MessageBoxIcon.Error : MessageBoxIcon.Warning;
                MessageBox.Show(content, caption, MessageBoxButtons.OK, icon);
            }
            catch (Exception ex)
            {
                ErrorHandler.ThrowError(ex);
            }
        }

        private void RecordDeletedCallback(object sender, ProjectEntry entry)
        {
            try
            {
                if (entry != null)
                {
                    var result = _entries.Remove(entry);
                    if (result)
                    {
                        MessageBox.Show($"Deleted entry [{entry.Title}]", "Deleted Record", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    //Refresh
                    RefreshOutput();
                }
            }
            catch(Exception ex)
            {
                ErrorHandler.ThrowError(ex);
            }
        }

        private void EntryChangesCallback(object sender, ProjectEntry e)
        {
            try
            {
                //Update record
                DataAccess.Instance.UpdateRecord(e);

                //Refresh output
                RefreshOutput();
            }
            catch(Exception ex)
            {
                ErrorHandler.ThrowError(ex);
            }
        }
    }
}
