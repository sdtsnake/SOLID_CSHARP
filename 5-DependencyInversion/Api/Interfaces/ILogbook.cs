using Microsoft.AspNetCore.Mvc;

namespace DependencyInversion.Controllers;

public interface ILogbook
{
    public void Add(String description);
    
}
