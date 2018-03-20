using EntertainmentNetwork.DAL.Models;
using EntertainmentNetwork.DAL.SeatService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces = EntertainmentNetwork.DAL.Models.Interfaces;

namespace EntertainmentNetwork.DAL
{
    public class SeatServiceAdapter : Interfaces.ISeatService
    {
        #region ISeatService

        public async Task Add(Interfaces.ISeat seat)
        {
           await this.seatService.addSeatAsync(new addSeatRequest
            {
                flrId = seat.FloorId,
                flrIdSpecified = true,
                seatColumn = seat.SeatColumn,
                seatNum = seat.SeatNum,
                seatRow = seat.SeatRow,
                seatIsactive = seat.IsActive,
                seatType = seat.SeatType
            });
        }

        public async Task<Interfaces.ISeat> FindById(decimal id)
        {
            var result = await this.seatService.findSeatByIdAsync(id);
            return this.ToSeat(result.@return);
        }

        public async Task GenerateSeats(decimal flrId, int seatRows, int seatColumns)
        {
            await this.seatService.generateSeatsAsync(new generateSeatRequest
            {
                flrId = flrId,
                flrIdSpecified = true,
                seatRows = seatRows,
                seatColumns = seatColumns
            });
        }

        public async Task<List<Interfaces.ISeat>> GetAll()
        {
            var result = await this.seatService.getSeatsAsync();
            var seats = result.@return;
            return seats == null ? new List<Interfaces.ISeat>() : seats.Select(x => this.ToSeat(x)).ToList();
        }

        public async Task<Interfaces.ISeat> Merge(Interfaces.ISeat seat)
        {
            var result = await this.seatService.mergeSeatAsync(new mergeSeatRequest
            {
                seatId = seat.Id,
                seatIdSpecified = true,
                flrId = seat.FloorId,
                flrIdSpecified = true,
                seatColumn = seat.SeatColumn,
                seatNum = seat.SeatNum,
                seatRow = seat.SeatRow,
                seatIsactive = seat.IsActive,
                seatType = seat.SeatType
            });

            return this.ToSeat(result.@return);        
        }

        public async Task Remove(decimal id)
        {
            await this.seatService.removeSeatAsync(id);
        }

        #endregion

        private Interfaces.ISeat ToSeat(seat seat)
        {
            return new Seat(seat.seatId, seat.seatColumn, seat.seatNum, seat.seatRow, seat.seatType, seat.floorId, seat.seatIsactive);
        }

        private readonly SeatServiceClient seatService = new SeatServiceClient();
    }
}
