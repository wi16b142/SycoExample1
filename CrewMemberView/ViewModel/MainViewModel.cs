using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using static System.Net.Mime.MediaTypeNames;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using CrewMemberView.Model;

namespace CrewMemberView.ViewModel
{
    public class MainViewModel : ViewModelBase
    {

        public MainViewModel()
        {
            if (IsInDesignMode)
            {
                //design mode
            }
            else
            {
                //real life
            }
        }
    }

    #region cheatsheet
    /*
             private Service_CrewMemberClient client = new Service_CrewMemberClient();
        private string selectedTask;
        private string selectedType;

        public string SelectedType
        {
            get { return selectedType; }
            set
            {
                selectedType = value;
                Refresh();
            }
        }

        public string SelectedTask
        {
            get { return selectedTask; }
            set
            {
                selectedTask = value;
                RefreshTypes();
            }
        }

        public ObservableCollection<kvCrewMember> CrewMembers { get; set; }
        public List<string> Tasks { get; set; }
        public List<string> Types { get; set; }

        public MainViewModel()
        {
            Tasks = new List<string>() { "All" };
            foreach (var item in client.QueryAllTasks())
            {
                Tasks.Add(item.Description);
            }
            RefreshTypes();            
        }

        private void RefreshTypes()
        {
            Types = null;
            Types = new List<string>() { "All" };
            foreach (var item in client.QueryAllTypes(SelectedTask))
            {
                Types.Add(item.Description);
            }
            RaisePropertyChanged("Types");
            Refresh();
        }

        private void Refresh()
        {
            if (SelectedTask == "All" && SelectedType == "All")
            {
                CrewMembers = new ObservableCollection<kvCrewMember>(client.QueryCrewMembers(null, null));
            }
            else if (SelectedTask == "All")
            {
                CrewMembers = new ObservableCollection<kvCrewMember>(client.QueryCrewMembers(null, SelectedType));
            }
            else if (SelectedType == "All")
            {
                CrewMembers = new ObservableCollection<kvCrewMember>(client.QueryCrewMembers(SelectedTask, null));
            }
            else
            {
                CrewMembers = new ObservableCollection<kvCrewMember>(client.QueryCrewMembers(SelectedTask, SelectedType));
            }
            RaisePropertyChanged("CrewMembers");
        }
     */
    #endregion
}