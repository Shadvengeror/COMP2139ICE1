using System.Security.Cryptography;
using COMP2139_labs.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP2139_labs.Controllers;

public class ProjectController : Controller
{
    
    [HttpGet]
    public IActionResult Index()
    {
        //Retreieve all projects from database
        var projects = new List<Project>()
        {
            new Project { ProjectId = 1, Name = "Project 1", Description = "First Project" }
        };
        return View(projects);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    
    [HttpPost]
    public IActionResult Create(Project project)
    {
        //Database - Persist new project to the database 
        return RedirectToAction("Index");
    }
    
    //CRUD - Create - Read - Update - Delete
    
    [HttpGet]
    public IActionResult Details(int id)
    {
        //Retrieve project from database
        var project = new Project {ProjectId = id, Name = "Project 1", Description = "First Project"};
        return View(project);
    }
}