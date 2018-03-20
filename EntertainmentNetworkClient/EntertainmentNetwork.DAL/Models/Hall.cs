using EntertainmentNetwork.DAL.Models.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

namespace EntertainmentNetwork.DAL.Models
{
    public class Hall : BaseNotifyPropertyChanged, IHall
    {
        public Hall() { }

        public Hall(decimal halId, string halName, decimal halSitscount, decimal cinemaId)
        {
            this.Id = halId;
            this.HalName = halName;
            this.HalSitscount = halSitscount;
            this.CinemaId = cinemaId;
        }

        public bool IsNew
        {
            get
            {
                return this.Id == 0;
            }
        }

        public bool IsChanged { get; set; }

        public decimal Id
        {
            get { return this.halId; }
            set
            {
                this.SetPropertyValue(out this.halId, this.halId, value);
            }
        }

        public decimal HalId
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

        public string HalName
        {
            get { return this.halName; }
            set
            {
                this.SetPropertyValue(out this.halName, this.halName, value);
            }
        }

        public decimal HalSitscount
        {
            get { return this.halSitscount; }
            set
            {
                this.SetPropertyValue(out this.halSitscount, this.halSitscount, value);
            }
        }

        public decimal CinemaId
        {
            get { return this.cinemaId; }
            set
            {
                this.SetPropertyValue(out this.cinemaId, this.cinemaId, value);
            }
        }

        public void Update(IBaseModel model)
        {
            IHall hall = (IHall)model;
            this.Id = hall.Id;
            this.HalName = hall.HalName;
            this.HalSitscount = hall.HalSitscount;
            this.CinemaId = hall.CinemaId;
        }

        public override bool Equals(object hall)
        {
            IHall hallToCompare = hall as IHall;
            return hallToCompare != null && this.Id.Equals(hallToCompare.Id);
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        private decimal cinemaId;
        private decimal halId;
        private string halName;
        private decimal halSitscount;
    }
}
