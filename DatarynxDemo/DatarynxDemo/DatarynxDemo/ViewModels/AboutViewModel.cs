using DatarynxDemo.Models;
using DatarynxDemo.Views;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Dynamic;
using System.IO;
using System.Reflection;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DatarynxDemo.ViewModels
{
    public class AboutViewModel : INotifyPropertyChanged
    {
        #region Fields

        private dynamic dynamicJsonCollection;
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Properties

        public dynamic DynamicJsonCollection
        {
            get
            {
                return dynamicJsonCollection;
            }
            set
            {
                this.dynamicJsonCollection = value;
                this.RaisepropertyChanged("DynamicJsonCollection");
            }
        }
        private void RaisepropertyChanged(string v)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
        }
        #endregion

        #region Constructor
        public AboutViewModel()
        {


            var assembly = typeof(AboutPage).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("DatarynxDemo.Data.Data.json");
            using (StreamReader sr = new StreamReader(stream))
            {
                var jsonText = sr.ReadToEnd();
                DynamicJsonCollection = JsonConvert.DeserializeObject<dynamic>(jsonText);
            }
        }
    }
    #endregion
}