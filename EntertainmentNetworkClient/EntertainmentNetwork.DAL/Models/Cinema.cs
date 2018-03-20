using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntertainmentNetwork.DAL.Models.Interfaces;

namespace EntertainmentNetwork.DAL.Models
{
    public class Cinema : BaseNotifyPropertyChanged, ICinema
    {
        public Cinema() { }

        public Cinema(decimal cinId, decimal cityId, string cinName, string cinAddress, byte[] cinIcon)
        {
            this.Id = cinId;
            this.CityId = cityId;
            this.CinName = cinName;
            this.CinAddress = cinAddress;
            this.CinIcon = cinIcon;     
        }

        public bool IsChanged { get; set; }

        public bool IsNew
        {
            get { return this.Id == 0; }
        }

        public decimal Id
        {
            get { return this.cinId; }
            set
            {
                this.SetPropertyValue(out this.cinId, this.cinId, value);
            }
        }

        public decimal CinId
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

        public string CinName
        {
            get { return this.cinName; }
            set
            {
                this.SetPropertyValue(out this.cinName, this.cinName, value);
            }
        }

        public string CinAddress
        {
            get { return this.cinAddress; }
            set
            {
                this.SetPropertyValue(out this.cinAddress, this.cinAddress, value);
            }
        }

        public byte[] CinIcon
        {
            get { return this.cinIcon; }
            set
            {
                this.SetPropertyValue(out this.cinIcon, this.cinIcon, value);
            }
        }

        public decimal CityId
        {
            get { return this.cityId; }
            set
            {
                this.SetPropertyValue(out this.cityId, this.cityId, value);
            }
        }

        public void Update(IBaseModel model)
        {
            ICinema cinema = (ICinema)model;
            this.Id = cinema.Id;
            this.CityId = cinema.CityId;
            this.CinName = cinema.CinName;
            this.CinAddress = cinema.CinAddress;
            this.CinIcon = cinema.CinIcon;
        }

        public override bool Equals(object city)
        {
            ICinema cinemaToCompare = city as ICinema;
            return cinemaToCompare != null && this.Id.Equals(cinemaToCompare.Id);
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        private decimal cinId;
        private string cinName;
        private byte[] cinIcon;
        private string cinAddress;
        private decimal cityId;
    }
}
