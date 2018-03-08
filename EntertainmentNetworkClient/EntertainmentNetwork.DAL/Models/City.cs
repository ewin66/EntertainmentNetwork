using EntertainmentNetwork.DAL.Models.Interfaces;

namespace EntertainmentNetwork.DAL.Models
{
    public class City : BaseNotifyPropertyChanged, ICity
    {
        public City() { }

        public City(decimal citId, string citName, string citCountry)
        {
            this.CitId = citId;
            this.CitName = citName;
            this.CitCountry = citCountry;
        }

        public bool IsNew
        {
            get
            {
                return this.CitId == 0;
            }
        }

        public bool IsChanged { get; set; }

        public decimal CitId
        {
            get { return this.citId; }
            set
            {
                this.SetPropertyValue(out this.citId, this.citId, value);
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

        public void Update(ICity city)
        {
            this.CitId = city.CitId;
            this.CitName = city.CitName;
            this.CitCountry = city.CitCountry;
        }

        public override bool Equals(object city)
        {
            ICity cityToCompare = city as ICity;
            return cityToCompare != null && this.CitId.Equals(cityToCompare.CitId);
        }

        public override int GetHashCode()
        {
            return this.CitId.GetHashCode();
        }

        private decimal citId;
        private string citName;
        private string citCountry;
    }
}
