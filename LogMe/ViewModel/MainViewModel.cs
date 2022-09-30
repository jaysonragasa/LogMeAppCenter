using GalaSoft.MvvmLight.Command;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LogMe.ViewModel
{
    public class MainViewModel
    {
        #region events

        #endregion

        #region vars

        #endregion

        #region properties

        #endregion

        #region commands
        public ICommand Command_ClickMe { get; set; }
        public ICommand Command_LogDate { get; set; }
        public ICommand Command_CrashThisApp { get; set; }
        public ICommand Command_CrashThisAppWithTrap { get; set; }
        #endregion

        #region ctors
        public MainViewModel()
        {
            InitCommands();
        }
        #endregion

        #region command methods
        void Command_ClickMe_Click()
        {
            Analytics.TrackEvent("Clicked!");
        }

        void Command_LogDate_Click()
        {
            Analytics.TrackEvent("DateLog", new Dictionary<string, string>() { { "Date", DateTime.Now.ToString() } });
        }

        void Command_CrashThisApp_Click()
        {
            int x = 1;
            int y = 0;
            int z = 0;
            z = x / y;
        }

        void Command_CrashThisAppWithTrap_Click()
        {
            try
            {
                throw new Exception("Intentionally throw an error");
            }
            catch(Exception ex)
            {
                Crashes.TrackError(ex, new Dictionary<string, string>()
                {
                    { "Command_CrashThisAppWithTrap", "ERRMSG: " + ex.Message  }
                });
            }
        }
        #endregion

        #region methods
        void InitCommands()
        {
            if (Command_ClickMe == null) Command_ClickMe = new RelayCommand(Command_ClickMe_Click);
            if (Command_LogDate == null) Command_LogDate = new RelayCommand(Command_LogDate_Click);
            if (Command_CrashThisApp == null) Command_CrashThisApp = new RelayCommand(Command_CrashThisApp_Click);
            if (Command_CrashThisAppWithTrap == null) Command_CrashThisAppWithTrap = new RelayCommand(Command_CrashThisAppWithTrap_Click);
        }

        void DesignData()
        {

        }

        void RuntimeData()
        {

        }

        public async Task RefreshData()
        {

        }
        #endregion
    }
}
