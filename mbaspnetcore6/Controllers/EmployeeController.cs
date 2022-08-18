using Microsoft.AspNetCore.Mvc;

namespace mbaspnetcore6.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IServiceRepository<Employee, int> empRepo;

        public EmployeeController(IServiceRepository<Employee, int> repo)
        {
            empRepo = repo;
        }
        public IActionResult Index()
        {
            var response = empRepo.GetRecords();
            return View(response.Records);
        }
        /// <summary>
        /// Method to Create a new Department
        /// </summary>
        /// <returns></returns>
        public IActionResult Create()
        {
            var emp = new Employee();
            // return an EMpty View for Department 
            return View(emp);
        }


        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            try
            {
                var response = empRepo.CreateRecord(emp);
                // If the Add is successful then Redirect to the 'Idnex' Action Method
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(emp);
            }
        }

        public IActionResult Edit(int id)
        {
            var respose = empRepo.GetRecord(id);
            // returna View with the data toi be edited
            return View(respose.Record);
        }

        [HttpPost]
        public IActionResult Edit(int id, Employee emp)
        {
            try
            {
                var response = empRepo.UpdateRecord(id, emp);
                // If the Add is successful then Redirect to the 'Idnex' Action Method
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(emp);
            }
        }

        public IActionResult Delete(int id)
        {
            var respose = empRepo.DeleteRecord(id);
            // returna View with the data toi be edited
            return RedirectToAction("Index");
        }
    }
}

