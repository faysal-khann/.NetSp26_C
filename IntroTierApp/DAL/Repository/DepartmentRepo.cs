using DAL.EF;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repository
{
    public class DepartmentRepo
    {
        StudentMsCSp26Context db;
        public DepartmentRepo(StudentMsCSp26Context db) { 
            this.db = db;
        }
        public bool Create(Department d) { 
            db.Departments.Add(d);    
            return db.SaveChanges()> 0;
           
        }
        public Department Get(int id) {
            return db.Departments.Find(id);
        }
        public bool Delete(int id) {
            var exobj = Get(id);
            db.Departments.Remove(exobj);
            return db.SaveChanges() > 0;
        }
        public bool Update(Department d)
        {
            var exobj = Get(d.Id);
            db.Entry(exobj).CurrentValues.SetValues(d);
            return db.SaveChanges() > 0;    
        }
        public List<Department> Get() { 
            return db.Departments.ToList();
        }
    }
}
