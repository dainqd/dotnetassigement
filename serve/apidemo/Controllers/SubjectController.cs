using apidemo.Hepper;
using apidemo.Models.Subject;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using WebApi.Services;

namespace apidemo.Controllers;

[Route("api/subject")]
[Authorize]
[ApiController]
public class SubjectController : Controller
{
    private ISubjectService _subjectService;
    private IMapper _mapper;
    private readonly AppSettings _appSettings;
    
    public SubjectController(
        ISubjectService subjectService,
        IMapper mapper,
        IOptions<AppSettings> appSettings)
    {
        _subjectService = subjectService;
        _mapper = mapper;
    }
    
    [HttpGet]
    public IActionResult GetAll()
    {
        var users = _subjectService.GetAll();
        return Ok(users);
    }
    
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var user = _subjectService.GetById(id);
        return Ok(user);
    }
    
    // [Authorize]
    [HttpPost]
    public IActionResult Update(UpdateSubject model)
    {
        _subjectService.Create(model);
        return Ok(new { message = "Subject updated!" });
    }

    // [Authorize]
    [HttpPut("update/{id}")]
    public IActionResult Create(int id, CreateSubject model)
    {
        _subjectService.Update(id, model);
        return Ok(new { message = "Subject created!" });
    }

    // [Authorize]
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        _subjectService.Delete(id);
        return Ok(new { message = "Subject deleted" });
    }
}