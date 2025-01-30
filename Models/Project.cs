using System.ComponentModel.DataAnnotations;
namespace COMP2139_labs.Models;

public class Project
{
    /// <summary>
    /// This is the primary key for projects
    /// </summary>
    public int ProjectId { get; set; }
    
    /// <summary>
    /// The name of the project
    /// [Required]: Ensures this property must be set it must have a project name
    /// </summary>
    [Required]
    public required string Name { get; set; }
    
    /// <summary>
    /// Details of the project
    /// string? may have data or be empty
    /// </summary>
    public string? Description { get; set; }
    
    [DataType(DataType.Date)]
    public DateTime StartDate { get; set; }
    
    [DataType(DataType.Date)]
    public DateTime EndDate { get; set; }
    
    public string? Status { get; set; }
    
}