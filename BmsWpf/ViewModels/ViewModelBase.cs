﻿namespace BmsWpf.ViewModels
{
    using System.ComponentModel;

    public abstract class ViewModelBase:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

    
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this,new PropertyChangedEventArgs(propertyName));
            }
         
        }
    }
}
