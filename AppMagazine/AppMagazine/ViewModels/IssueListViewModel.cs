using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Threading.Tasks;


using Xamarin.Forms;
using MvvmHelpers;
using AppMagazine.Models;

namespace AppMagazine.ViewModels
{
    public class IssueListViewModel : ViewModelBase 
    {

        public ObservableRangeCollection<Issue> Issues { get; set; }
        public IssueListViewModel()
        {
            Title = "Issues";
            LogoCulturally = "LogoCulturally";

            Issues = new ObservableRangeCollection<Issue>();
            
            Issues.Add(new Issue
            {
                Name = "Issue 01",
                Date = "June 2021",
                ImageUrl = "JuneCover"

            });
        }

        
    }
}