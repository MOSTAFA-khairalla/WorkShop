using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Core.Entities;
using Web.Core.Interfaces;
using Web.Infrastrcture.ViewModel;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public EmployeeController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult GetEmployee()
       {
            IEnumerable<Employee> types = _unitOfWork.Employee.GetAll();
            return Ok(types);

        }

        [HttpPost]

        public IActionResult AddEmployee( EmployeeViewModel vm )
        {
            if (vm == null)
            {
                return BadRequest();
            }
            var employee =   _mapper.Map<Employee>(vm);
            _unitOfWork.Employee.Add(employee);
            _unitOfWork.Complete();
            return Ok();

        }
    }
}
