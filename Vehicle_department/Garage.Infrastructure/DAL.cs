using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Garage.Domain;

namespace Garage.Infrastructure
{
    public class DAL
    {
        public GarageContext db = new GarageContext();

        // remind about technical service
        public void Reminder()
        {
            string temp = "";
            var techServ = db.Vehicles.Where(x => x.NextTechServ < 500);
            foreach (Vehicle serv in techServ)
                temp += serv.Brand + " " + serv.StateNum + " ";

            if (temp.Trim() != "")
                MessageBox.Show("Next Technical Service at the " + temp, "Vehicle Department", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // search current driver
        public Driver CurrentDriver(Guid id)
        {
            Driver driver = db.Drivers.Find(id);
            return driver;
        }
        // search current vehicle
        public Vehicle CurrentVehicle(Guid id)
        {
            Vehicle vehicle = db.Vehicles.Find(id);
            return vehicle;
        }

        // add / edit driver
        public bool AddEditDriver(string name, DateTime birthDate, string category,
            string phoneNum, DateTime medicalCertificate,string id, bool addFlag)
        {
            bool flagResult = false;

            Driver driver = new Driver();
            try
            {
                driver.Name = name;
                driver.BirthDate = birthDate;
                driver.Category = category;
                driver.PhoneNum = phoneNum;
                driver.MedicalCertificate = medicalCertificate;
                driver.Id = Guid.Parse(id);

                if (addFlag)
                    db.Drivers.Add(driver);
                else
                    db.Entry(driver).State = EntityState.Modified;

                db.SaveChanges();

                flagResult = true;
            }
            catch (Exception e)
            {
                flagResult = false;
                MessageBox.Show(e.Message);
            }

            return flagResult;
        }

        // deleting current driver
        public bool DelDriver(Guid id)
        {
            bool flagResult = false;

            var driver = CurrentDriver(id);

            try
            {
                db.Drivers.Remove(driver);
                db.SaveChanges();
                flagResult = true;
            }
            catch (Exception ex)
            {
                flagResult = false;
                MessageBox.Show(ex.Message);
            }

            return flagResult;
        }

        // add / edit vehicle
        public bool AddEditVehicle(string brand, string stateNum, string color, 
            DateTime releaseDate, string vinCode, string mileage, DateTime insurance, 
            string driverId, string id, bool addFlag)
        {
            bool flagResult = false;

            Vehicle vehicle = new Vehicle();
            try
            {
                vehicle.Brand = brand;
                vehicle.StateNum = stateNum;
                vehicle.Color = color;
                vehicle.ReleaseDate = releaseDate;
                vehicle.VinCode = vinCode;
                vehicle.Mileage = Int32.Parse(mileage);
                vehicle.Insurance = insurance;
                vehicle.DriverId = Guid.Parse(driverId);
                vehicle.Id = Guid.Parse(id);

                if (addFlag)
                    db.Vehicles.Add(vehicle);
                else
                    db.Entry(vehicle).State = EntityState.Modified;

                db.SaveChanges();

                flagResult = true;
            }
            catch (Exception e)
            {
                flagResult = false;
                MessageBox.Show(e.Message);
            }

            return flagResult;
        }

        // deleting current vehicle
        public bool DelVehicle(Guid id)
        {
            bool flagResult = false;

            var vehicle = CurrentVehicle(id);

            try
            {
                db.Vehicles.Remove(vehicle);
                db.SaveChanges();
                flagResult = true;
            }
            catch (Exception e)
            {
                flagResult = false;
                MessageBox.Show(e.Message);
            }

            return flagResult;
        }
    }
}
