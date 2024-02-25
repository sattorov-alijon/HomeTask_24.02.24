using Domain;

namespace Infrastructure;

public class CourseService
{
public List<Course> _courses=new List<Course>();

public List<Course> GetCourse()
{
    return _courses;
}

public void AddCourse(Course course)
{
    _courses.Add(course);
}


public void UpdateCourse(Course course)
{
    foreach (var item in _courses)
    {
        if (item.Id==course.Id)
        {
            item.Title=course.Title;
            item.Description=course.Description;
            item.Fee=course.Fee;
            item.HasDiscount=course.HasDiscount;
            break;
        }
    }
}

public void DeleteCourse(int id)
{
    foreach (var item in _courses)
    {
        if (item.Id==id)
        {
            _courses.Remove(item);
        break;
        }
    }
}



}

