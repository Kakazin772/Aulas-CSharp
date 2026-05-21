using System;
using System.Collections.Generic;
using System.Text;

namespace Escola.Entites
{
    internal class Student
    {
        public int Id { get; set; }

        public Student()
        {
        }

        public Student(int id)
        {
            Id = id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Student))
            {
                return false;
            }

            Student student = obj as Student;

            return Id.Equals(student.Id);
        }
    }
}
