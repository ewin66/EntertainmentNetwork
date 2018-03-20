using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using EntertainmentNetwork.BL.Commands;
using EntertainmentNetwork.BL.Interfaces;
using EntertainmentNetwork.DAL;
using EntertainmentNetwork.DAL.Models.Interfaces;
using EntertainmentNetwork.DAL.Logging;

namespace EntertainmentNetwork.BL.ViewModels
{
    public class BaseViewModel<S, M> : BaseNotifyPropertyChanged, IViewModel<M>
        where S : IBaseService<M>
        where M : IBaseModel
    {
        public BaseViewModel(S dataService)
        {
            this.DataService = dataService;
            this.Models = new BindingList<M>();
            this.AddUpdateCommand = new AddUpdateCommand<M>(this);
            this.RemoveCommand = new RemoveCommand<M>(this);
        }

        public BindingList<M> Models { get; private set; }

        public ICommand AddUpdateCommand { get; private set; }

        public ICommand RemoveCommand { get; private set; }

        public bool IsDataLoaded { get; protected set; }

        public M Selected { get; set; }

        protected S DataService { get; set; }

        public virtual async Task AddUpdate()
        {
            foreach (var item in this.Models.Where(x => x.IsNew || x.IsChanged))
            {
                var mergedModel = await Logger.ExecuteAndLog<Task<M>>(() => this.DataService.Merge(item));
                item.Update(mergedModel);
            }
        }

        public virtual async Task LoadData(Func<M, bool> filter)
        {
            this.Models.ListChanged -= ViewCollection_ListChanged;      
            this.Models.Clear();
            var task = await Logger.ExecuteAndLog<Task<List<M>>>(() => this.DataService.GetAll());            
            
            foreach (M item in task.Where(filter))
            {
                this.Models.Add(item);
            }

            this.IsDataLoaded = true;
            this.Models.ListChanged += ViewCollection_ListChanged;
        }

        public virtual async Task Remove()
        {
            await Logger.ExecuteAndLog<Task>(() => this.DataService.Remove(this.Selected.Id));
            this.Models.Remove(this.Selected);
        }

        protected void ViewCollection_ListChanged(object sender, ListChangedEventArgs e)
        {
            var changedList = sender as BindingList<M>;
            if (changedList != null && e.ListChangedType != ListChangedType.ItemDeleted && e.NewIndex > -1)
            {
                changedList[e.NewIndex].IsChanged = true;
            }
        }

        private M Get(decimal id)
        {
            return this.Models.FirstOrDefault(x => x.Id == id);
        }
    }
}
