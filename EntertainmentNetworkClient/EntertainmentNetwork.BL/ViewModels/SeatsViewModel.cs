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
    public class SeatsViewModel : BaseNotifyPropertyChanged, ISeatViewModel
    {
        public event EventHandler SeatsMapGenerated;

        public SeatsViewModel(ISeatService dataService)
        {
            this.seatService = dataService;
            this.seatsViewCollection = new BindingList<ISeat>();
            this.seatsMap = new DataTable();
            this.addUpdateCommand = new AddUpdateCommand<ISeat>(this);
            this.removeCommand = new RemoveCommand<ISeat>(this);
            this.generateCommand = new GenerateCommand(this);
        }

        public BindingList<ISeat> Models 
        { 
            get 
            {
                return this.seatsViewCollection; 
            } 
        }

        public DataTable SeatsMap
        {
            get
            {
                return this.seatsMap;
            }
        }

        public bool IsDataLoaded { get; private set; }
        public ISeat Selected { get; set; }

        public ICommand AddUpdateCommand
        {
            get
            {
                return this.addUpdateCommand;
            }
        }

        public ICommand GenerateCommand
        {
            get
            {
                return this.generateCommand;
            }
        }

        public ICommand RemoveCommand
        {
            get
            {
                return this.removeCommand;
            }
        }

        public async Task AddUpdate()
        {
            foreach (var item in this.Models.Where(x => x.IsNew || x.IsChanged))
            {
                var seat = await this.seatService.MergeSeat(item);
                item.Update(seat);
            }
        }

        public async Task Generate(object parameter)
        {
            foreach (var item in this.Models)
            {
                await this.seatService.RemoveSeatAsync(item.SeatId);
            }

            this.Models.Clear();

            Tuple<decimal, int, int> args = parameter as Tuple<decimal, int, int>;
            if (args != null)
	        {
                await this.seatService.GenerateSeats(args.Item1, args.Item2, args.Item3);
	        }
        }

        public async Task LoadData(Func<ISeat, bool> filter)
        {
            this.Models.ListChanged -= SeatsViewCollection_ListChanged;      
            this.Models.Clear();
            this.SeatsMap.Clear();
            this.SeatsMap.Columns.Clear();

            var task = await this.seatService.GetSeats();

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
            this.Models.ListChanged += SeatsViewCollection_ListChanged;
        }

        public async Task Remove()
        {
            await this.seatService.RemoveSeatAsync(this.Selected.SeatId);
            this.Models.Remove(this.Selected);
        }

        private ISeat GetSeat(decimal seatId)
        {
            return this.Models.FirstOrDefault(x => x.SeatId == seatId);
        }

        private void SeatsViewCollection_ListChanged(object sender, ListChangedEventArgs e)
        {
            var changedList = sender as BindingList<ISeat>;
            if (changedList != null && e.ListChangedType != ListChangedType.ItemDeleted && e.NewIndex > -1)
            {
                changedList[e.NewIndex].IsChanged = true;
            } 
        }

        private readonly ICommand addUpdateCommand;
        private readonly ICommand removeCommand;
        private readonly ICommand generateCommand;
        private BindingList<ISeat> seatsViewCollection;
        private DataTable seatsMap;
        private ISeatService seatService;
        public const string SELECTED_SEAT_PROPERRTY_NAME = "SelectedSeat";
    }
}
