using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EntertainmentNetwork.DAL
{
    public class BaseNotifyPropertyChanged : INotifyPropertyChanged
    {     
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
            {
                handler.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        protected void SetPropertyValue<TProperty>(out TProperty result, TProperty oldValue, TProperty newValue, [CallerMemberName] string propertyName = null)
        {
            result = oldValue;

            if (!Equals(oldValue, newValue))
            {
                result = newValue;
                this.OnPropertyChanged(propertyName);
            }
        }        
    }
}
