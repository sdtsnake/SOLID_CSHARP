using Microsoft.AspNetCore.Mvc;

namespace DependencyInversion.Controllers;

public interface IStudent
{
    public IEnumerable<Student> GetAll();
    public void Add(Student student);
    
}
