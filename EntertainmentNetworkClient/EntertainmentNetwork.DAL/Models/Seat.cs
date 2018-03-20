using EntertainmentNetwork.DAL.Models.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

namespace EntertainmentNetwork.DAL.Models
{
    public class Seat : BaseNotifyPropertyChanged, ISeat
    {
        public Seat() { }

        public Seat(decimal seatId, int seatColumn, int seatNum, int seatRow, int seatType, decimal floorId, bool isActive)
        {
            this.Id = seatId;
            this.SeatColumn = seatColumn;
            this.SeatNum = seatNum;
            this.SeatRow = seatRow;
            this.IsActive = isActive;
            this.SeatType = seatType;
            this.FloorId = floorId;
        }

        public bool IsChanged { get; set; }

        public bool IsNew
        {
            get { return this.Id == 0; }
        }

        public bool IsActive
        {
            get { return this.isActive; }
            set
            {
                this.SetPropertyValue(out this.isActive, this.isActive, value);
            }
        }

        public decimal Id
        {
            get { return this.seatId; }
            set
            {
                this.SetPropertyValue(out this.seatId, this.seatId, value);
            }
        }

        public decimal SeatId
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

        public int SeatColumn
        {
            get { return this.seatColumn; }
            set
            {
                this.SetPropertyValue(out this.seatColumn, this.seatColumn, value);
            }
        }

        public int SeatNum
        {
            get { return this.seatNum; }
            set
            {
                this.SetPropertyValue(out this.seatNum, this.seatNum, value);
            }
        }

        public int SeatRow
        {
            get { return this.seatRow; }
            set
            {
                this.SetPropertyValue(out this.seatRow, this.seatRow, value);
            }
        }

        public int SeatType
        {
            get { return this.seatType; }
            set
            {
                this.SetPropertyValue(out this.seatType, this.seatType, value);
            }
        }

        public decimal FloorId
        {
            get { return this.flrId; }
            set
            {
                this.SetPropertyValue(out this.flrId, this.flrId, value);
            }
        }

        public void Update(IBaseModel model)
        {
            ISeat seat = (ISeat)model;
            this.Id = seat.Id;
            this.SeatColumn = seat.SeatColumn;
            this.SeatNum = seat.SeatNum;
            this.SeatRow = seat.SeatRow;
            this.IsActive = seat.IsActive;           
            this.SeatType = seat.SeatType;
            this.FloorId = seat.FloorId;
        }

        public override bool Equals(object seat)
        {
            ISeat seatToCompare = seat as ISeat;
            return seatToCompare != null && this.Id.Equals(seatToCompare.Id);
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }

        private decimal seatId;
        private int seatColumn;
        private int seatNum;
        private int seatRow;
        private int seatType;
        private decimal flrId;
        private bool isActive;
    }
}
