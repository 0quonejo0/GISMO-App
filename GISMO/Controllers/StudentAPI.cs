//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Infrastructure;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Update;
//using Newtonsoft.Json;
//using GISMO.Data;
//using GISMO.Data.Entities;

//namespace GISMO.Contollers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class StudentsController : ControllerBase
//    {
//        //private readonly IStudentService _studentService;
//        //private readonly ITherapySessionService _therapySessionService;
//        //private readonly IScheduleService _scheduleService;

//        //public StudentsController(ApplicationDbContext context, IStudentService studentService, ITherapySessionService therapySessionService, IScheduleService scheduleService)
//        //{
//        //    _context = context;
//        //    _studentService = studentService;
//        //    _therapySessionService = therapySessionService;
//        //    _scheduleService = scheduleService;
//        //}

//        // GET: api/Students
//        [HttpGet]
//        public async Task<ActionResult<StudentVM>> GetStudent()
//        {
//            var students = await _studentService.GetAll();
//            return Ok(students);
//        }

//        // GET: api/Students/5
//        [HttpGet("{id}")]
//        public async Task<ActionResult<Student>> GetStudent(int id)
//        {
//            var student = await _context.Student.FindAsync(id);

//            if (student == null)
//            {
//                return NotFound();
//            }

//            return student;
//        }

//        [HttpGet("services/{studentid}")]
//        public async Task<ActionResult<List<Models.StudentScheduleVM>>> GetServices(int studentid)
//        {
//            var list = await _studentService.GetSchedules(studentid);
//            string result = "{\"headers\": [ \"ID\", \"Service Type\", \"Therapist\" ]," + System.Environment.NewLine;
//            result += "\"rows\": [" + System.Environment.NewLine;
//            int ctr = 0;
//            foreach (var service in list)
//            {
//                result += "[ " + service.Id.ToString() + ",  \"" + service.ServiceTypeName + "\", \"" + service.TherapistName + "\" ]";
//                ctr += 1;
//                if (ctr < list.Count) result += ",";
//                result += System.Environment.NewLine;
//            }
//            result += "]}";
//            return Ok(result);
//        }

//        [HttpGet("services/test/{studentid}")]
//        public async Task<IActionResult> GetServicesTest(int studentid)
//        {
//            var list = await _studentService.GetSchedules(studentid);
//            return Ok(list);
//        }

//        [HttpGet("schedules/sessions/{scheduleid}")]
//        public async Task<IActionResult> GetSessions(int scheduleid)
//        {
//            try
//            {
//                var list = await _therapySessionService.GetBySchedule(scheduleid);
//                string result = "{\"headers\": [ \"Id\", \"Date\", \"Clock-On\", \"Clock-Off\" ]," + System.Environment.NewLine;
//                result += "\"rows\": [" + System.Environment.NewLine;
//                int ctr = 0;
//                foreach (var session in list)
//                {
//                    result += "[ " + session.Id.ToString() + ",  \"" + session.SessionDate.ToString("MM/dd/yyyy") + "\", \""
//                        + session.StartTime.ToString("h:mm tt") + "\", \"" + session.EndTime.ToString("h:mm tt") + "\" ]";
//                    ctr += 1;
//                    if (ctr < list.Count) result += ",";
//                    result += System.Environment.NewLine;
//                }
//                result += "]}";

//                return Ok(result);
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(ex.Message);
//            }

//        }

//        [HttpGet("schedules/{scheduleid}")]
//        public async Task<IActionResult> GetSchedule(int scheduleid)
//        {
//            var result = await _scheduleService.GetByScheduleId(scheduleid);
//            return Ok(result);
//        }
//    }

//}
