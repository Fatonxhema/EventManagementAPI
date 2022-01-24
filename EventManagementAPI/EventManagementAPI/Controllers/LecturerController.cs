using EventManagementAPI.Models;
using EventManagementAPI.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LecturerController : ControllerBase
    {
        private readonly ILecturerService _lecturerService;

        public LecturerController(ILecturerService lecturerService)
        {
            _lecturerService = lecturerService;
        }

        [HttpGet("getall")]
        public IEnumerable<Lecturer> GetAllLecturers()
        {
            return _lecturerService.GetAllLecturers();
        }

        [HttpGet("get/{id}")]
        public Lecturer GetLecturerById(int id)
        {
            return _lecturerService.GetLecturerById(id);
        }

        [HttpPost("add")]
        public Lecturer AddLecturer(Lecturer l)
        {
            return _lecturerService.AddLecturer(l);
        }

        [HttpPut("edit")]
        public Lecturer UpdateLecturer(Lecturer l)
        {
            return _lecturerService.UpdateLecturer(l);
        }

        [HttpDelete("delete/{id}")]
        public Lecturer DeleteLecturer(int id)
        {
            return _lecturerService.DeleteLecturer(id);
        }
    }
}
