using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_TimeSheet
    {
        private int TimeSheetID;
        private int EmployeeID;
        private DateTime CheckIn;
        private DateTime CheckOut;
        private bool Ischeckin;
        private DateTime RealTimeCheckIn;


        public DTO_TimeSheet() { }
        public DTO_TimeSheet(int timeSheetID, int employeeID, DateTime checkIn, DateTime checkOut, bool ischeckin, DateTime realTimeCheckIn)
        {
            TimeSheetID = timeSheetID;
            EmployeeID = employeeID;
            CheckIn = checkIn;
            CheckOut = checkOut;
            Ischeckin = ischeckin;
            RealTimeCheckIn = realTimeCheckIn;
        }
        public DTO_TimeSheet(int employeeID, DateTime checkIn, DateTime checkOut, bool ischeckin, DateTime realTimeCheckIn)
        {
            EmployeeID = employeeID;
            CheckIn = checkIn;
            CheckOut = checkOut;
            Ischeckin = ischeckin;
            RealTimeCheckIn = realTimeCheckIn;
        }

        public int TimeSheetID1 { get => TimeSheetID; set => TimeSheetID = value; }
        public int EmployeeID1 { get => EmployeeID; set => EmployeeID = value; }
        public DateTime CheckIn1 { get => CheckIn; set => CheckIn = value; }
        public DateTime CheckOut1 { get => CheckOut; set => CheckOut = value; }
        public bool Ischeckin1 { get => Ischeckin; set => Ischeckin = value; }
        public DateTime RealTimeCheckIn1 { get => RealTimeCheckIn; set => RealTimeCheckIn = value; }
    }
}
