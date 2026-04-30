using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class StudentRepo
    {
        StudentMsCSp26Context db;
        public StudentRepo(StudentMsCSp26Context db)
        {
            this.db = db;
        }
        public bool Create(Student d)
        {
            db.Students.Add(d);
            return db.SaveChanges() > 0;

        }
        public Student Get(int id)
        {
            return db.Students.Find(id);
        }
        public bool Delete(int id)
        {
            var exobj = Get(id);
            db.Students.Remove(exobj);
            return db.SaveChanges() > 0;
        }
        public bool Update(Student d)
        {
            var exobj = Get(d.Id);
            db.Entry(exobj).CurrentValues.SetValues(d);
            return db.SaveChanges() > 0;
        }
        public List<Student> Get()
        {
            return db.Students.ToList();
        }
    }
}
