using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Linq;

namespace NotSoCrud
{
    public class StaffController : Controller
    {
        private List<Staff> databaseListOfStaff = new List<Staff>();

        [HttpGet]
        [Route("staff")]
        public List<Staff> GetStaff()
        {
            var context = new TeamContext();

            databaseListOfStaff = context.Staff_Members.ToList();

            return databaseListOfStaff;
        }

        [HttpGet]
        [Route("staff/{staffId}")]
        public Staff GetSpecificStaff(int staffId)
        {
            var context = new TeamContext();

            Staff routedStaff = context.Staff_Members.Where(s => s.StaffId == staffId).FirstOrDefault();
            return routedStaff;
        }


        [HttpPut]
        [Route("staff/{staffId}")]
        public void UpdateStaffMember(int staffId, [FromBodyAttribute] Staff newStaff)
        {
            var context = new TeamContext();

            context.Update(newStaff);
            context.SaveChanges();
        }

        [HttpPost]
        [Route("/staff/add-staff_Member")]
        public void AddStaffMember([FromBodyAttribute] Staff staff_Member) 
        {
            var context = new TeamContext();

            context.Staff_Members.Add(staff_Member);
            context.SaveChanges();
        }

        [HttpDelete]
        [Route("staff/delete/{staffId}")]
        public void DeleteStaffMember(int staffId)
        {
            var context = new TeamContext();

            context.Remove(context.Staff_Members.SingleOrDefault(a => a.StaffId == staffId));
            context.SaveChanges();
            
        }
    }
}