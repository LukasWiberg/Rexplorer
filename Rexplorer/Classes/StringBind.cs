using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Rexplorer.Classes {
    public class StringBind: INotifyPropertyChanged {
        private string value;
        public string Value { 
            get {
                return this.value;
            } 
            set { 
                this.value = value;
                NotifyPropertyChanged();
            } 
        }


        public StringBind(string val) {
            Value = val;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
