using EventManagementAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagementAPI.Services.IServices
{
    public interface ILecturerService
    {
        IEnumerable<Lecturer> GetAllLecturers();

        Lecturer GetLecturerById(int id);

        Lecturer AddLecturer(Lecturer l);

        Lecturer UpdateLecturer(Lecturer l);

        Lecturer DeleteLecturer(int id);
    }
}
