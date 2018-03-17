using EntertainmentNetwork.DAL.Models.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

namespace EntertainmentNetwork.DAL.Models
{
    public class Floor : BaseNotifyPropertyChanged, IFloor
    {
        public Floor() { }

        public Floor(decimal floorId, string floorName, decimal hallId)
        {
            this.FloorId = floorId;
            this.FloorName = floorName;
            this.HallId = hallId;
        }

        public bool IsNew
        {
            get
            {
                return this.FloorId == 0;
            }
        }

        public bool IsChanged { get; set; }

        public decimal FloorId
        {
            get { return this.floorId; }
            set
            {
                this.SetPropertyValue(out this.floorId, this.floorId, value);
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

        public string FloorName
        {
            get { return this.floorName; }
            set
            {
                this.SetPropertyValue(out this.floorName, this.floorName, value);
            }
        }

        public void Update(IFloor floor)
        {
            this.FloorId = floor.FloorId;
            this.FloorName = floor.FloorName;
            this.HallId = floor.HallId;
        }

        public override bool Equals(object floor)
        {
            IFloor floorToCompare = floor as IFloor;
            return floorToCompare != null && this.FloorId.Equals(floorToCompare.FloorId);
        }

        public override int GetHashCode()
        {
            return this.FloorId.GetHashCode();
        }

        private decimal floorId;
        private decimal hallId;
        private string floorName;
    }
}
