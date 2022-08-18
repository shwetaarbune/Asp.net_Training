using Application.Entities.Base;
namespace Application.Entities;



public class Department : Entity
{
    public int DeptNo { get; set; }
    public string DeptName { get; set; }
    public string Location { get; set; }
    public int Capacity { get; set; }
}

public class Employee : Entity
{
    public int EmpNo { get; set; }
    public string EmpName { get; set; }
    public string Designation { get; set; }
    public int Salary { get; set; }
    public int DeptNo { get; set; }
}