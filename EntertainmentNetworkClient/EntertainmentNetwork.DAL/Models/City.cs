using System;
using EntertainmentNetwork.DAL.Models.Interfaces;

namespace EntertainmentNetwork.DAL.Models
{
    public class City : BaseNotifyPropertyChanged, ICity
    {
        public City() { }

        public City(decimal citId, string citName, string citCountry)
        {
            this.Id = citId;
            this.CitName = citName;
            this.CitCountry = citCountry;
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
            get { return this.citId; }
            set
            {
                this.SetPropertyValue(out this.citId, this.citId, value);
            }
        }

        public decimal CitId
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

        public string CitName
        {
            get { return this.citName; }
            set
            {
                this.SetPropertyValue(out this.citName, this.citName, value);
            }
        }

        public string CitCountry
        {
            get { return this.citCountry; }
            set
            {
                this.SetPropertyValue(out this.citCountry, this.citCountry, value);
            }
        }

        public void Update(IBaseModel model)
        {
            ICity city = (ICity)model;
            this.Id = city.Id;
            this.CitName = city.CitName;
            this.CitCountry = city.CitCountry;
        }

        public override bool Equals(object city)
        {
            ICity cityToCompare = city as ICity;
            return cityToCompare != null && this.Id.Equals(cityToCompare.Id);
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        private decimal citId;
        private string citName;
        private string citCountry;
    }
}
