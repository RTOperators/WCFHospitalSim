﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hospital_BL;
using SharedLibray;
using System.Collections.Generic;

namespace Hospital_BLUnitTest
{
    /// <summary>
    /// 
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void CreatePatientTest()
        {
            PatientRepository repository = new PatientRepository();
            Patient newPatient = repository.Create();

            Assert.AreNotEqual(0, newPatient.ID);

            repository.Delete(newPatient);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void ReadPatientTest()
        {
            PatientRepository repository = new PatientRepository();

            Patient newPatient = repository.Create();

            Patient readPatient = repository.Read(newPatient.ID);

            Assert.IsNotNull(readPatient);
            Assert.AreNotEqual(0, readPatient.ID);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void UpdatePatientTest()
        {
            PatientRepository repository = new PatientRepository();

            Patient newPatient = repository.Create();

            Patient patient2Updated = repository.Read(newPatient.ID);
            patient2Updated.Name = "Ricardo";
            patient2Updated.Age = 32;

            Assert.AreEqual(true, repository.Update(patient2Updated));

            Patient patientUpdated = repository.Read(newPatient.ID);

            Assert.AreEqual(patient2Updated.ID, patientUpdated.ID);
            Assert.AreEqual(patient2Updated.Age, patientUpdated.Age);
            Assert.AreEqual(patient2Updated.Name, patientUpdated.Name);

            repository.Delete(newPatient);
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void DeletePatientTest()
        {
            PatientRepository repository = new PatientRepository();
            Patient newPatient = repository.Create();

            Assert.AreEqual(true,repository.Delete(newPatient));

            Assert.IsNull(repository.Read(newPatient.ID));
        }

        /// <summary>
        /// 
        /// </summary>
        [TestMethod]
        public void GetListPatientsTest()
        {
            PatientRepository repository = new PatientRepository();

            var patients2DB = new List<Patient>();
            Patient newPatient1 = repository.Create();
            patients2DB.Add(newPatient1);
            Patient newPatient2 = repository.Create();
            patients2DB.Add(newPatient2);

            var patients = repository.GetPatients();

            CollectionAssert.AreEqual(patients2DB, patients,new PatientComparer());

            patients2DB.ForEach(r => repository.Delete(r));
        }

        public class PatientComparer : Comparer<Patient>
        {
            public override int Compare(Patient x, Patient y)
            {
                if (x.Name.Equals(y.Name) && x.ID == y.ID && x.Age == y.Age)
                    return 0;
                else
                    return -1;
            }
        }
    }
}
