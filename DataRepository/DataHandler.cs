using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository
{
    public class DataHandler
    {
    }

    #region cheatsheet

    /*
     
        public List<kvTask> QueryAllTasks()
        {
            return db.wi16b141_Task.Select(x => new kvTask()
            {
                Description = x.Description,
                Duration = (int)x.Duration,
                Priority = (int)x.Priority
            }).ToList();
        }

        public List<kvType> QueryAllTypes(string ta)
        {
            if (ta != null)
            {
                var query = from x in db.wi16b141_Type
                            from y in x.wi16b141_Task
                            where y.Description.Equals(ta)
                            select new kvType()
                            {
                                Description = x.Description
                            };
                return query.ToList();
            }
            return db.wi16b141_Type.Select(x => new kvType()
            {
                Description = x.Description
            }).ToList();
        }

        public List<kvCrewMember> QueryCrewMembers(string taskDescription, string typeDescription)
        {
            if (taskDescription == null && typeDescription == null)
            {
                var query = from x in db.wi16b141_CrewMember
                            from y in x.wi16b141_Task
                            select new kvCrewMember()
                            {
                                Name = x.Name,
                                LicenseNumber = x.LicenceNumber,
                                TaskDescription = y.Description,
                                TypeDescription = y.wi16b141_Type.Description
                            };
                return query.ToList();
            }
            else if (typeDescription == null)
            {
                var query2 = from x in db.wi16b141_CrewMember
                             from y in x.wi16b141_Task
                             where y.Description.Equals(taskDescription)
                             select new kvCrewMember()
                             {
                                 Name = x.Name,
                                 LicenseNumber = x.LicenceNumber,
                                 TaskDescription = y.Description,
                                 TypeDescription = y.wi16b141_Type.Description
                             };
                return query2.ToList();
            }
            else if (taskDescription == null)
            { 
                var query3 = from x in db.wi16b141_CrewMember
                             from y in x.wi16b141_Task
                             where y.wi16b141_Type.Description.Equals(typeDescription)
                             select new kvCrewMember()
                             {
                                 Name = x.Name,
                                 LicenseNumber = x.LicenceNumber,
                                 TaskDescription = y.Description,
                                 TypeDescription = y.wi16b141_Type.Description
                             };
                return query3.ToList();
            }
            var query4 = from x in db.wi16b141_CrewMember
                         from y in x.wi16b141_Task
                         where y.wi16b141_Type.Description.Equals(typeDescription)
                            && y.Description.Equals(taskDescription)
                         select new kvCrewMember()
                         {
                             Name = x.Name,
                             LicenseNumber = x.LicenceNumber,
                             TaskDescription = y.Description,
                             TypeDescription = y.wi16b141_Type.Description
                         };
            return query4.ToList();
        }


        //Example 4

        public List<kvTask> QueryAllTasksByDuration(int minDuration)
        {
            return db.wi16b141_Task.Where(x => x.Duration > minDuration).Select(x => new kvTask()
            {
                Description = x.Description,
                Duration = (int)x.Duration,
                Priority = (int)x.Priority
            }).ToList();
        }

        public List<kvType> QueryAllTypesByDurationAndPriority(int minDuration, int minPriority)
        {
            var query = from x in db.wi16b141_Type
                        from y in x.wi16b141_Task
                        where y.Duration > minDuration
                           && y.Priority > minPriority
                        select new kvType()
                        {
                            Description = x.Description
                        };
            return query.ToList();
        }

        public List<kvTask> QueryAllTasksByTypeDescription(string typeDescription)
        {
            return db.wi16b141_Task.Where(x => x.wi16b141_Type.Description.Equals(typeDescription)).Select(x => new kvTask()
            {
                Description = x.Description,
                Duration = (int)x.Duration,
                Priority = (int)x.Priority
            }).ToList();
        }

        public int AddNewTaskAndType(kvTask ta, kvType ty)
        {
            db.wi16b141_Type.Add(new wi16b141_Type()
            {
                Id = Guid.NewGuid(),
                Description = ty.Description
            });
            db.SaveChanges();
            db.wi16b141_Task.Add(new wi16b141_Task()
            {
                Id = Guid.NewGuid(),
                Description = ta.Description,
                Duration = ta.Duration,
                Priority = ta.Priority,
                FK_Type = db.wi16b141_Type.Where(x => x.Description.Equals(ty.Description)).SingleOrDefault().Id
            });
            return db.SaveChanges();
        }

        public int AddNewTaskToTypeViaId(kvTask ta, Guid id)
        {
            db.wi16b141_Task.Add(new wi16b141_Task()
            {
                Id = Guid.NewGuid(),
                Description = ta.Description,
                Duration = ta.Duration,
                Priority = ta.Priority,
                FK_Type = id
            });
            return db.SaveChanges();
        }

        public int AddNewTaskToTypeViaDescription(kvTask ta, string description)
        {
            db.wi16b141_Task.Add(new wi16b141_Task()
            {
                Id = Guid.NewGuid(),
                Description = ta.Description,
                Duration = ta.Duration,
                Priority = ta.Priority,
                FK_Type = db.wi16b141_Type.Where(x => x.Description.Equals(description)).SingleOrDefault().Id
            });
            return db.SaveChanges();
        }
    }
     */

    #endregion

}
