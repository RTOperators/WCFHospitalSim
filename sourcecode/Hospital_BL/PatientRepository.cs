﻿using SharedLibray;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_BL
{
    /// <summary>
    /// 
    /// </summary>
    public class PatientRepository
    {
        HospitalDBEntities dBEntities;

        /// <summary>
        /// 
        /// </summary>
        public PatientRepository()
        {
            dBEntities = new HospitalDBEntities();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="patient"></param>
        /// <returns></returns>
        public bool Update(SharedLibray.Patient patient)
        {           
            try
            {
                PatientInfo patient2DB = dBEntities.PatientInfoes.First(r => r.ID == (int) patient.ID);

                patient2DB.Name = patient.name;
                patient2DB.Age = patient.age;

                dBEntities.SaveChanges();

                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="patient"></param>
        /// <returns></returns>
        public bool Delete(SharedLibray.Patient patient)
        {
            try
            {
                PatientInfo patient2DB = dBEntities.PatientInfoes.First(r => r.ID == (int)patient.ID);

                dBEntities.PatientInfoes.Remove(patient2DB);
                dBEntities.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public SharedLibray.Patient Read(ulong ID)
        {
            try
            {
                PatientInfo patient2DB = dBEntities.PatientInfoes.First(r => r.ID == (int)ID);

                Patient patient = new Patient
                {
                    ID = (ulong)patient2DB.ID,
                    age = patient2DB.Age,
                    name = patient2DB.Name
                };

                return patient;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SharedLibray.Patient Create()
        {
            try
            {
                PatientInfo patient = new PatientInfo()
                {
                    Age = 0,
                    Name = string.Empty
                };

                dBEntities.PatientInfoes.Add(patient);
                dBEntities.SaveChanges();

                Patient newPatient = new Patient()
                {
                    age = patient.Age,
                    name = patient.Name,
                    ID = (ulong) patient.ID
                };

                return newPatient;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<SharedLibray.Patient> GetPatients()
        {
            try
            {
                List<PatientInfo> patientList = dBEntities.PatientInfoes.ToList();
                List<Patient> patients = new List<Patient>();

                foreach(PatientInfo info in patientList)
                {
                    Patient newPatient = new Patient
                    {
                        ID = (ulong)info.ID,
                        age = info.Age,
                        name = info.Name
                    };

                    patients.Add(newPatient);
                }
                
                return patients;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
