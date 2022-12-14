using apidemo.Entities;
using apidemo.Models.Subject;
using apidemo.Context;
using AutoMapper;

namespace WebApi.Services;

public interface ISubjectService
{
    IEnumerable<Subject> GetAll();
    Subject GetById(int id);
    void Update(int id, CreateSubject model);
    void Delete(int id);
    public void Create(UpdateSubject model);
}


public class SubjectService : ISubjectService
{
    private MySQLDBContext _context;
    private readonly IMapper _mapper;
    
    public SubjectService(
        MySQLDBContext context,
        IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    
    public IEnumerable<Subject> GetAll()
    {
        return _context.Subject;
    }

    public Subject GetById(int id)
    {
        return getSubject(id);
    }

    public void Update(int id, CreateSubject model)
    {
        var subject = getSubject(id);
        
        if(model.Name == null)
            throw new AppException("Name invalid!");
        
        _mapper.Map(model, subject);
        _context.Subject.Update(subject);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var subject = getSubject(id);
        _context.Subject.Remove(subject);
        _context.SaveChanges();
    }

    public void Create(UpdateSubject model)
    {
        var subject = _mapper.Map<Subject>(model);
        _context.Subject.Add(subject);
        _context.SaveChanges();
    }
    
    private Subject getSubject(int id)
    {
        var subject = _context.Subject.Find(id);
        if (subject == null) throw new KeyNotFoundException("Subject not found");
        return subject;
    }
}