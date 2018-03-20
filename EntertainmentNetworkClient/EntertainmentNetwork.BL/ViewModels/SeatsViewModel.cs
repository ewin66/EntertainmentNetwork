using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using EntertainmentNetwork.BL.Commands;
using EntertainmentNetwork.BL.Interfaces;
using EntertainmentNetwork.DAL;
using EntertainmentNetwork.DAL.Models.Interfaces;

namespace EntertainmentNetwork.BL.ViewModels
{
    public class SeatsViewModel : BaseViewModel<ISeatService, ISeat>, ISeatViewModel
    {
        public event EventHandler SeatsMapGenerated;

        public SeatsViewModel(ISeatService dataService) : base(dataService)
        {
            this.SeatsMap = new DataTable();
            this.GenerateCommand = new GenerateCommand(this);
        }

        public DataTable SeatsMap { get; private set; }

        public ICommand GenerateCommand {get; private set;}

        public async Task Generate(object parameter)
        {
            foreach (var item in this.Models)
            {
                await this.DataService.Remove(item.Id);
            }

            this.Models.Clear();

            Tuple<decimal, int, int> args = parameter as Tuple<decimal, int, int>;
            if (args != null)
	        {
                await this.DataService.GenerateSeats(args.Item1, args.Item2, args.Item3);
	        }
        }

        public override async Task LoadData(Func<ISeat, bool> filter)
        {
            this.Models.ListChanged -= ViewCollection_ListChanged;      
            this.Models.Clear();
            this.SeatsMap.Clear();
            this.SeatsMap.Columns.Clear();

            var task = await this.DataService.GetAll();

            foreach (ISeat item in task.Where(filter))
            {
                this.Models.Add(item);
            }

            for (int i = 0; i < this.Models.GroupBy(x => x.SeatColumn).Count(); i++)
			{
                this.SeatsMap.Columns.Add(i.ToString(), typeof(ISeat));
			}

            foreach (var rowGroup in this.Models.GroupBy(x => x.SeatRow))
            {
                var cells = rowGroup.OrderBy(x => x.SeatColumn);
                this.SeatsMap.Rows.Add(cells.ToArray());                                             
            }

            if (this.SeatsMapGenerated != null)
            {
                this.SeatsMapGenerated(this, new EventArgs());
            }
     
            this.IsDataLoaded = true;
            this.Models.ListChanged += ViewCollection_ListChanged;
        }
    }
}
