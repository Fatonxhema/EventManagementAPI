using EventManagementAPI.Data;
using EventManagementAPI.Models;
using EventManagementAPI.Services.IServices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagementAPI.Services
{
    public class LecturerService : ILecturerService
    {
        private readonly DataContext _context;

        public LecturerService(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Lecturer> GetAllLecturers()
        {
            var records = _context.Lecturer.ToList();
            return records;
        }

        public Lecturer GetLecturerById(int id)
        {
            var record = _context.Lecturer.FirstOrDefault(x => x.Id == id);
            return record;
        }

        public Lecturer AddLecturer(Lecturer l)
        {
            if (l != null)
            {
                _context.Lecturer.Add(l);
                _context.SaveChanges();
                return l;
            }
            return null;
        }

        public Lecturer UpdateLecturer(Lecturer l)
        {
            _context.Entry(l).State = EntityState.Modified;
            _context.SaveChanges();
            return l;
        }

        public Lecturer DeleteLecturer(int id)
        {
            var record = _context.Lecturer.FirstOrDefault(x => x.Id == id);
            _context.Entry(record).State = EntityState.Deleted;
            _context.SaveChanges();
            return record;
        }
    }
}
