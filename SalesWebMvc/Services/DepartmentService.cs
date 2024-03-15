using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context;
        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }
        public List<Department> FinAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();

        }
    }
}
