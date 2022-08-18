using System;

namespace mbaspnetcore6.Repositories
{
    /// <summary>
    /// A Department Repository class that will be having a Business Logic
    /// for Performing Operations for Department
    /// This will be registered in Dependency Container
    /// This will be Injected with Data Access layer for Department
    /// </summary>
    public class EmployeeRepository : IServiceRepository<Employee, int>
    {
        // Define a Dependency
        IDataAccess<Employee, int> deptDataAccess;

        /// <summary>
        /// Inject the Dependency 
        /// </summary>
        public EmployeeRepository(IDataAccess<Employee, int> dataAccess)
        {
            deptDataAccess = dataAccess;
        }

        public ResponseStatus<Employee> CreateRecord(Employee entity)
        {
            ResponseStatus<Employee> response = new ResponseStatus<Employee>();
            try
            {
                response.Record = deptDataAccess.Create(entity);
                response.Message = "Record is created successfully";
                response.StatusCode = 201;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        public ResponseStatus<Employee> DeleteRecord(int id)
        {
            ResponseStatus<Employee> response = new ResponseStatus<Employee>();
            try
            {
                response.Record = deptDataAccess.Delete(id);
                response.Message = "Record is delete successfully";
                response.StatusCode = 203;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        public ResponseStatus<Employee> GetRecord(int id)
        {
            ResponseStatus<Employee> response = new ResponseStatus<Employee>();
            try
            {
                response.Record = deptDataAccess.Get(id);
                response.Message = "Record is read successfully";
                response.StatusCode = 200;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        public ResponseStatus<Employee> GetRecords()
        {
            ResponseStatus<Employee> response = new ResponseStatus<Employee>();
            try
            {
                response.Records = deptDataAccess.Get();
                response.Message = "Records are read successfully";
                response.StatusCode = 200;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        public ResponseStatus<Employee> UpdateRecord(int id, Employee entity)
        {
            ResponseStatus<Employee> response = new ResponseStatus<Employee>();
            try
            {
                response.Record = deptDataAccess.Update(id, entity);
                response.Message = "Record is updated successfully";
                response.StatusCode = 204;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }
    }
}

