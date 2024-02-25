using Domain;

namespace Infrastructure;

public class TeacherService
{
public List<Teacher> _teachers=new List<Teacher>();

public List<Teacher> GetTeacher()
{
    return _teachers;
}

public void AddTeacher(Teacher teacher)
{
    _teachers.Add(teacher);
}


public void UpdateTeacher(Teacher teacher)
{
    foreach (var item in _teachers)
    {
        if (item.Id==teacher.Id)
        {
            item.FirstName=teacher.FirstName;
            item.LastName=teacher.LastName;
            item.Position=teacher.Position;
            item.ExperienceAmount=teacher.ExperienceAmount;
            break;
        }
    }
}

public void DeleteTeacher(int id)
{
    foreach (var item in _teachers)
    {
        if (item.Id==id)
        {
            _teachers.Remove(item);
        break;
        }
    }
}



}

