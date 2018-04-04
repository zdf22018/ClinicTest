using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DAL
{
    public class CRUD
    { public clinicEntities entitiesContext = new clinicEntities();

        

        public List<doctor> DisplayDoctorById(int id)
        {
            List<doctor> list = new List<doctor>();
            var doctor = entitiesContext.doctors
                       .Where(d => d.Id == id)
                       .FirstOrDefault<doctor>();
            list.Add(doctor);
            return list;
        }

        public int GetDoctorIdByUserName(string userName)
        {
            int doctorId = 0;
            List<doctor> objDoctor = entitiesContext.doctors.ToList<doctor>();
            foreach (doctor d in objDoctor) {
                if (d.UserName == userName)
                { doctorId = d.Id; }
            }
            return doctorId;
        }

        public doctor GetDoctorById(int id)
        {
            doctor findD = null;
            List<doctor> objDoctor = entitiesContext.doctors.ToList<doctor>();
            foreach (doctor d in objDoctor) {
                if (d.Id == id)
                {
                    findD = d;
                }
                else { MessageBox.Show("this Id: {0} cannot be found", id.ToString()); }

            }
            return findD;
        }

        public List<patient> GetAllPatient()
        {
            List<patient> patients = entitiesContext.patients.ToList<patient>();
            return patients;
        }
        public List<patient> GetPatientByName(string name)
        {
            List<patient> patients = entitiesContext.patients.ToList<patient>();
            foreach (patient p in patients)
            {
                if (p.FirstName == name || p.LastName == name)
                {
                    patients.Add(p);
                }
               
            }
            return patients;
        }

        public void AddAvailableTime(availability av)
        {
            entitiesContext.availabilities.Add(av);
            entitiesContext.SaveChanges();
            
        }
        //public appointment List<appointment> GetAppointments()
        //{
        //    //DateTime today = DateTime.Today;
        //    List<appointment> objApp = entitiesContext.appointments.ToList<appointment>();

        //}

    }
}
