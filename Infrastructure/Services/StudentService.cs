﻿using Domain;

namespace Infrastructure;

public class StudentService
{
public List<Student> _students=new List<Student>();

public List<Student> GetStudent()
{
    return _students;
}

public void AddStudent(Student student)
{
    _students.Add(student);
}


public void UpdateStudent(Student student)
{
    foreach (var item in _students)
    {
        if (item.Id==student.Id)
        {
            item.FirstName=student.FirstName;
            item.LastName=student.LastName;
            item.BirthDate=student.BirthDate;
            item.Address=student.Address;
            break;
        }
    }
}

public void DeleteStudent(int id)
{
    foreach (var item in _students)
    {
        if (item.Id==id)
        {
            _students.Remove(item);
        break;
        }
    }
}



}
