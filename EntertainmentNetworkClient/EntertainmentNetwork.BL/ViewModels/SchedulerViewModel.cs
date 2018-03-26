using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using EntertainmentNetwork.BL.Commands;
using EntertainmentNetwork.BL.Interfaces;
using EntertainmentNetwork.DAL;
using EntertainmentNetwork.DAL.Models.Interfaces;
using EntertainmentNetwork.DAL.SchedulerService;
using EntertainmentNetwork.DAL.Logging;

namespace EntertainmentNetwork.BL.ViewModels
{
    public class SchedulerViewModel : BaseViewModel<IBaseService<IScheduler>, IScheduler>
    {
        public SchedulerViewModel(IBaseService<IScheduler> dataService) : base(dataService)
        {
        }

        public override async Task Remove(object parameter)
        {
            await Logger.ExecuteAndLog<Task>(() => this.DataService.Remove((decimal)parameter));            
        }
    }
}
