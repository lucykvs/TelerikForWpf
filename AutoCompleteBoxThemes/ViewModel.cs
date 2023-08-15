using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCompleteBoxThemes {
    public class ViewModel {

        Data source = new Data();

        private ObservableCollection<Contact> _contactsList = new ObservableCollection<Contact>();

        public ObservableCollection<Contact> ContactsList {
            get
            {
                return this._contactsList;
            }
        }

        public ViewModel() {
            foreach(var contact in source.GetContacts())
            {
                ContactsList.Add(contact);
            }
        }
    }
}
