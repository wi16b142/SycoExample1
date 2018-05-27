using CrewMemberView.SR_Crew;
using GalaSoft.MvvmLight;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CrewMemberView.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        Service_CrewClient client = new Service_CrewClient();
        private string _selectedTask;
        private string _selectedType;

        public string SelectedTask
        {
            get => _selectedTask; set
            {
                _selectedTask = value;
                ReloadTypes();
            }
        }

        public string SelectedType
        {
            get => _selectedType; set
            {
                _selectedType = value;
                Reload();
            }
        }

        public ObservableCollection<MyCrewMember> Crew { get; set; }
        public List<string> Tasks { get; set; }
        public List<string> Types { get; set; }

        public MainViewModel()
        {
            Tasks = new List<string>() { "All" };
            foreach (var item in client.QueryAllTasks())
            {
                Tasks.Add(item.Description);
            }
            ReloadTypes();
        }

        private void Reload()
        {
            if(SelectedTask == "All" && SelectedType == "All")
            {
                Crew = new ObservableCollection<MyCrewMember>(client.QueryCrewMembers(null, null));
            }else if (SelectedTask == "All")
            {
                Crew = new ObservableCollection<MyCrewMember>(client.QueryCrewMembers(null, SelectedType));
            }
            else if (SelectedType == "All")
            {
                Crew = new ObservableCollection<MyCrewMember>(client.QueryCrewMembers(SelectedTask, null));
            }else
            {
                Crew = new ObservableCollection<MyCrewMember>(client.QueryCrewMembers(SelectedTask, SelectedType));
            }
            RaisePropertyChanged("Crew");

        }

        private void ReloadTypes()
        {
            Types = null;
            Types = new List<string>() { "All" };
            foreach (var item in client.QueryAllTypes(SelectedTask))
            {
                Types.Add(item.Description);
            }RaisePropertyChanged("Types");
            Reload();
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