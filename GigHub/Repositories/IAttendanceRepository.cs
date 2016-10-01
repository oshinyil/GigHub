using GigHub.Models;
using System.Collections.Generic;

namespace GigHub.Repositories
{
    public interface IAttendanceRepository
    {
        IEnumerable<Attendance> GetFutureAttendances(string userId);

        Attendance GetAttendance(int gigId, string userId);
    }
}