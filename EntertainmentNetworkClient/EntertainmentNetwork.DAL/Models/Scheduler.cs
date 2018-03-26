using EntertainmentNetwork.DAL.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace EntertainmentNetwork.DAL.Models
{
    public class Scheduler : BaseNotifyPropertyChanged, IScheduler
    {
        public Scheduler() { }

        public Scheduler(decimal schId, string schName, string schDescr, DateTime schTimeFrom, DateTime schTimeTo, decimal hallId, decimal showId)
        {
            this.Id = schId;
            this.SchName = schName;
            this.SchDescr = schDescr;
            this.SchTimeFrom = schTimeFrom;
            this.SchTimeTo = schTimeTo;
            this.HallId = hallId;
            this.ShowId = showId;
        }

        public bool IsNew
        {
            get
            {
                return this.Id == 0;
            }
        }

        public bool IsChanged { get; set; }
        
        public bool IsRemoved { get; set; }

        public decimal Id
        {
            get { return this.schId; }
            set
            {
                this.SetPropertyValue(out this.schId, this.schId, value);
            }
        }

        public decimal SchId
        {
            get
            {
                return this.Id;
            }
            set
            {
                this.Id = value;
            }
        }

        public string SchName
        {
            get { return this.schName; }
            set
            {
                this.SetPropertyValue(out this.schName, this.schName, value);
            }
        }

        public string SchDescr
        {
            get { return this.schDescr; }
            set
            {
                this.SetPropertyValue(out this.schDescr, this.schDescr, value);
            }
        }

        public DateTime SchTimeFrom
        {
            get { return this.schTimeFrom; }
            set
            {
                this.SetPropertyValue(out this.schTimeFrom, this.schTimeFrom, value);
            }
        }

        public DateTime SchTimeTo
        {
            get { return this.schTimeTo; }
            set
            {
                this.SetPropertyValue(out this.schTimeTo, this.schTimeTo, value);
            }
        }

        public decimal HallId
        {
            get { return this.hallId; }
            set
            {
                this.SetPropertyValue(out this.hallId, this.hallId, value);
            }
        }

        public decimal ShowId
        {
            get { return this.showId; }
            set
            {
                this.SetPropertyValue(out this.showId, this.showId, value);
            }
        }

        public void Update(IBaseModel model)
        {
            IScheduler scheduler = (IScheduler)model;
            this.Id = scheduler.SchId;
            this.SchName = scheduler.SchName;
            this.SchDescr = scheduler.SchDescr;  
            this.SchTimeFrom = scheduler.SchTimeFrom;
            this.SchTimeTo = scheduler.SchTimeTo;
            this.HallId = scheduler.HallId;
            this.ShowId = scheduler.ShowId;
        }

        public override bool Equals(object scheduler)
        {
            IScheduler schedulerToCompare = scheduler as IScheduler;
            return schedulerToCompare != null && this.Id.Equals(schedulerToCompare.Id);
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        private decimal schId;
        private string schDescr;
        private string schName;
        private DateTime schTimeFrom;
        private DateTime schTimeTo;
        private decimal hallId;
        private decimal showId;
    }
}
