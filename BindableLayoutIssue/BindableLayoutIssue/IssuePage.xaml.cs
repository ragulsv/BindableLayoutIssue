using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BindableLayoutIssue
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IssuePage : ContentPage
    {
        public IssuePage()
        {
            InitializeComponent();
        }
    }

    public class Model : INotifyPropertyChanged
    {
        public ObservableCollection<string> colors;
        public ObservableCollection<string> Colors
        {
            get
            {
                return colors;
            }

            set
            {
                colors = value;
                OnPropertyChanged("Colors");
            }
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion


    }

    public class ViewModel
    {
        public Model Model { get; set; }

        public ViewModel()
        {
            Model = new Model
            {
                Colors = new ObservableCollection<string>()
                {
                    "Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", 
                    "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow",
                    "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange",
                    "Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", 
                    "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow",
                    "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange",
                    "Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", 
                    "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", 
                    "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange",
                    "Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", 
                    "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow",
                    "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange",
                    "Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", 
                    "Yellow","Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", 
                    "Orange", "Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange", 
                    "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", 
                    "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange",
                    "Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", 
                    "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", 
                    "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange",
                    "Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", 
                    "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", 
                    "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange",
                    "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange",
                    "Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan",
                    "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow",
                    "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange",
                    "Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan",
                    "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow",
                    "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange","Cyan", "Yellow", "Orange",
                }
            };
        }
    }
}