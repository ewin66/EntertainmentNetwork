using EntertainmentNetwork.DAL.Models.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

namespace EntertainmentNetwork.DAL.Models
{
    public class Seat : BaseNotifyPropertyChanged, ISeat
    {
        public Seat() { }

        public Seat(decimal seatId, int seatNum, int seatRow, int seatFloor, int seatType, decimal hallId)
        {
            this.SeatId = seatId;
            this.SeatNum = seatNum;
            this.SeatRow = seatRow;
            this.SeatFloor = seatFloor;
            this.SeatType = seatType;
            this.HallId = hallId;
        }

        public bool IsChanged { get; set; }

        public bool IsNew
        {
            get { return this.SeatId == 0; }
        }

        public decimal SeatId
        {
            get { return this.seatId; }
            set
            {
                this.SetPropertyValue(out this.seatId, this.seatId, value);
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

        public int SeatFloor
        {
            get { return this.seatFloor; }
            set
            {
                this.SetPropertyValue(out this.seatFloor, this.seatFloor, value);
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

        public decimal HallId
        {
            get { return this.hallId; }
            set
            {
                this.SetPropertyValue(out this.hallId, this.hallId, value);
            }
        }

        public void Update(ISeat seat)
        {
            this.SeatId = seat.SeatId;
            this.SeatNum = seat.SeatNum;
            this.SeatRow = seat.SeatRow;
            this.SeatFloor = seat.SeatFloor;
            this.SeatType = seat.SeatType;
            this.HallId = seat.HallId;
        }

        public override bool Equals(object seat)
        {
            ISeat seatToCompare = seat as ISeat;
            return seatToCompare != null && this.SeatId.Equals(seatToCompare.SeatId);
        }

        public override int GetHashCode()
        {
            return this.SeatId.GetHashCode();
        }

        private decimal seatId;
        private int seatNum;
        private int seatRow;
        private int seatFloor;
        private int seatType;
        private decimal hallId;
    }
}
