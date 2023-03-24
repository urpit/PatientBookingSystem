using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment2_0_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public ValidationHelper _validation = new ValidationHelper();
        public Office _office = new Office();

        /// <summary>
        /// ValidationHelper is a class which validate the fields like name,email,postalcode
        /// </summary>
        public class ValidationHelper
        {
            /// <summary>
            /// Regex for validation
            /// </summary>
            private Regex validEmail = new Regex(@"^([A-z]+\d*)?\@[A-z]+\.[A-z]+$");
            private Regex validNumber = new Regex(@"^\d{10}$");
            private Regex validPostalCode = new Regex(@"^[A-Z]\d[A-Z]\s\d[A-Z]\d$");
            private Regex validName = new Regex(@"^[A-z]+\s[A-z]+$");
            private DateTime dateTime = DateTime.Now;

            /// <summary>
            /// Method for Validating birtDate
            /// </summary>
            /// <param name="birthDate"></param>
            /// <returns></returns>
            public Boolean IsValideBirthDate(DateTime birthDate)
            {
                DateTime dt_18 = birthDate.AddYears(18);

                if (dt_18.Date > dateTime.Date)
                    return true;
                else
                    return false;

            }
            /// <summary>
            /// Method for Validating Name
            /// </summary>
            /// <param name="name"></param>
            /// <returns></returns>
            public Boolean IsValideName(string name)
            {
                if (!validName.IsMatch(name))
                    return true;
                else
                    return false;
            }
            /// <summary>
            /// Method for Validating Email
            /// </summary>
            /// <param name="email"></param>
            /// <returns></returns>
            public Boolean IsValideEmail(string email)
            {
                if (!validEmail.IsMatch(email))
                    return true;
                else
                    return false;
            }
            /// <summary>
            /// Method for Validating Phone Number
            /// </summary>
            /// <param name="number"></param>
            /// <returns></returns>
            public Boolean IsValideNumber(string number)
            {
                if (!validNumber.IsMatch(number))
                    return true;
                else
                    return false;
            }
            /// <summary>
            /// Method for Validating Postalcode
            /// </summary>
            /// <param name="postalCode"></param>
            /// <returns></returns>
            public Boolean IsValidePostalCode(string postalCode)
            {
                if (!validPostalCode.IsMatch(postalCode))
                    return true;
                else
                    return false;
            }

        }
        /// <summary>
        /// Office class 
        /// </summary>
        public class Office
        {
            private Office appointments;
            /// <summary>
            /// list for validating the appointment time
            /// </summary>
            private List<DateTime> dates = new List<DateTime>();
            private DateTime VDate;
            /// <summary>
            /// Appointmnet list
            /// </summary>
            public List<Appointment> Patients = new List<Appointment>();

            /// <summary>
            /// Method for adding patient information into the List
            /// </summary>
            /// <param name="appointment"></param>
            public void AddAppointment(Appointment appointment)
            {
                Patients.Add(appointment);
            }

            /// <summary>
            /// Method for validating the appointment time
            /// </summary>
            /// <param name="dt"></param>
            /// <returns></returns>

            public Boolean BookAppointment(DateTime dt)
            {

                for (int i = 0; i < Patients.Count; i++)
                {
                    if (Patients[i].GetDuration() == "15min")
                    {
                        VDate = Patients[i].GetAppointmentTime().AddMinutes(15.00);
                        dates.Add(VDate);
                        if (dt <= dates[i] && dt >= Patients[i].GetAppointmentTime())
                        {

                            MessageBox.Show("Please choose another time for appointment,this time slot is already booked by someone else");
                            return true;
                        }
                       
                    }
                    else if (Patients[i].GetDuration() == "30min")
                    {
                        VDate = Patients[i].GetAppointmentTime().AddMinutes(30.00);
                        dates.Add(VDate);
                        if (dt <= dates[i] && dt >= Patients[i].GetAppointmentTime())
                        {

                            MessageBox.Show("Please choose another time for appointment,this time slot is already booked by someone else");

                            return true;
                        }
                        
                    }
                    else if (Patients[i].GetDuration() == "45min")
                    {
                        VDate = Patients[i].GetAppointmentTime().AddMinutes(45.00);
                        dates.Add(VDate);
                        if (dt <= dates[i] && dt >= Patients[i].GetAppointmentTime())
                        {

                            MessageBox.Show("Please choose another time for appointment,this time slot is already booked by someone else");

                            return true;
                        }
                       

                    }
                    else if (Patients[i].GetDuration() == "1hr")
                    {
                        VDate = Patients[i].GetAppointmentTime().AddMinutes(60.00);
                        dates.Add(VDate);
                        if (dt <= dates[i] && dt >= Patients[i].GetAppointmentTime())
                        {

                            MessageBox.Show("Please choose another time for appointment,this time slot is already booked by someone else");

                            return true;

                        }
                       
                    }
                }
                return false;
            }
        }

        /// <summary>
        /// Appointment class for all user input
        /// </summary>
        public class Appointment
        {

            private string pName { get; set; }
            private string pBirthDate { get; set; }
            private string pAddress { get; set; }
            private string pCity { get; set; }
            private string pProvince { get; set; }
            private string pPostalCode { get; set; }
            private string pPhoneNumber { get; set; }
            private string pEmail { get; set; }
            private DateTime pAppintmentTime { get; set; }
            private string pDuration { get; set; }
            private string pPurpose { get; set; }
            public Appointment(string pName, string pBirthDate, string pAddress, string pCity, string pProvince, string pPostalCode, string pPhoneNumber, string pEmail, DateTime pAppintmentTime, string pDuration, string pPurpose)
            {
                this.pName = pName;
                this.pBirthDate = pBirthDate;
                this.pAddress = pAddress;
                this.pCity = pCity;
                this.pProvince = pProvince;
                this.pPostalCode = pPostalCode;
                this.pPhoneNumber = pPhoneNumber;
                this.pEmail = pEmail;
                this.pAppintmentTime = pAppintmentTime;
                this.pDuration = pDuration;
                this.pPurpose = pPurpose;
            }

            /// <summary>
            /// All Get methods for accessing the patient information from the list
            /// </summary>
            /// <returns></returns>
            public string GetName()
            {
                return this.pName;
            }
            public string GetBirth()
            {
                return this.pBirthDate;
            }
            public string GetAddress()
            {
                return this.pAddress;
            }
            public string GetCity()
            {
                return this.pCity;
            }
            public string GetProvince()
            {
                return this.pProvince;
            }
            public string GetPostal()
            {
                return this.pPostalCode;
            }
            public string GetPhoneNumber()
            {
                return this.pPhoneNumber;
            }
            public string GetEmail()
            {
                return this.pEmail;
            }
            public DateTime GetAppointmentTime()
            {
                return this.pAppintmentTime;
            }
            public string GetDuration()
            {
                return this.pDuration;
            }
            public string GetPurpose()
            {
                return this.pPurpose;
            }

            /// <summary>
            /// Override method for printing the Appointment class
            /// </summary>
            /// <returns></returns>
            public override string ToString()
            {
                return $"Patient Name: {pName} Patient BirthDate: {pBirthDate} Address: {pAddress} City: {pCity} Province: {pProvince} PostalCode: {pPostalCode} PhoneNumber: {pPhoneNumber} Email: {pEmail} Appointment Time: {pAppintmentTime.ToString()} Duration: {pDuration} Purpose: {pPurpose}";
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {

                ///Creating folder and text file
                
                string filePath = @"c:\Patient";
                Directory.CreateDirectory(filePath);
                string fileName = "Appointment.txt";
                filePath = Path.Combine(filePath, fileName);

                if (_office.Patients.Count != 0)
                {
                    if (!File.Exists(filePath))
                    {
                        for (int i = 0; i < _office.Patients.Count; i++)
                        {
                            ///Using appendtext method for creating new file
                            File.AppendAllText(filePath, $"Patient Name: {_office.Patients[i].GetName()}\nAge: {_office.Patients[i].GetBirth()}\nAddress: {_office.Patients[i].GetAddress()}\nCity: {_office.Patients[i].GetCity()}\nProvince: {_office.Patients[i].GetProvince()}\nPostal Code: {_office.Patients[i].GetPostal()}\nPhone Number: {_office.Patients[i].GetPhoneNumber()}\nEmail: {_office.Patients[i].GetEmail()}\n\n\nAppointment Time: {_office.Patients[i].GetAppointmentTime().ToString()}\nDuration: {_office.Patients[i].GetDuration()}\nPurpose: {_office.Patients[i].GetPurpose()}\n----------------------------------------\n--------------------------------------\n");
                        }

                    }
                    else
                    {
                        ///if file exists, it will delete and creat new file
                        File.Delete(filePath);
                        for (int i = 0; i < _office.Patients.Count; i++)
                        {
                            File.AppendAllText(filePath, $"Patient Name: {_office.Patients[i].GetName()}\nAge: {_office.Patients[i].GetBirth()}\nAddress: {_office.Patients[i].GetAddress()}\nCity: {_office.Patients[i].GetCity()}\nProvince: {_office.Patients[i].GetProvince()}\nPostal Code: {_office.Patients[i].GetPostal()}\nPhone Number: {_office.Patients[i].GetPhoneNumber()}\nEmail: {_office.Patients[i].GetEmail()}\n\n\nAppointment Time: {_office.Patients[i].GetAppointmentTime().ToString()}\nDuration: {_office.Patients[i].GetDuration()}\nPurpose: {_office.Patients[i].GetPurpose()}\n----------------------------------------\n--------------------------------------\n");
                        }
                    }
                    MessageBox.Show($"successfully Printed {_office.Patients.Count()} appointments to \"Appointment.txt\" ");
                }
                else
                {
                    MessageBox.Show("There is no appointment to print");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }

        private void dtpDateofBirth_ValueChanged(object sender, EventArgs e)
        {

            if (_validation.IsValideBirthDate(dtpDateofBirth.Value))
            {
                lblErrorAge.Visible = true;
                btnBookAppointment.Enabled = false;
                return;
            }
            lblErrorAge.Visible = false;
            btnBookAppointment.Enabled = true;

        }

        private void txtPatientName_TextChanged(object sender, EventArgs e)
        {
            if (_validation.IsValideName(txtPatientName.Text))
            {
                lblErrorName.Visible = true;
                btnBookAppointment.Enabled = false;
                return;
            }
            lblErrorName.Visible = false;
            btnBookAppointment.Enabled = true;

        }

        private void txtPostalCode_TextChanged(object sender, EventArgs e)
        {
            if (_validation.IsValidePostalCode(txtPostalCode.Text))
            {
                lblErrorPostalCode.Visible = true;
                btnBookAppointment.Enabled = false;
                return;
            }
            lblErrorPostalCode.Visible = false;
            btnBookAppointment.Enabled = true;
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (_validation.IsValideNumber(txtPhoneNumber.Text))
            {
                lblErrorPhoneNumber.Visible = true;
                btnBookAppointment.Enabled = false;
                return;
            }
            lblErrorPhoneNumber.Visible = false;
            btnBookAppointment.Enabled = true;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (_validation.IsValideEmail(txtEmail.Text))
            {
                lblErrorEmail.Visible = true;
                btnBookAppointment.Enabled = false;
                return;
            }
            lblErrorEmail.Visible = false;
            btnBookAppointment.Enabled = true;
        }

        private void btnBookAppointment_Click(object sender, EventArgs e)
        {
            try
            {
                string patientName = txtPatientName.Text;
                DateTime birthDate = dtpDateofBirth.Value;
                string nBirth = (DateTime.Now.Year - birthDate.Year).ToString();
                string address = txtAddress.Text;
                string city = txtCity.Text;
                string province = txtprovince.Text;
                string postalCode = txtPostalCode.Text;
                string phoneNumber = txtPhoneNumber.Text;
                string email = txtEmail.Text;
                DateTime appointment = dtpAppointment.Value;
                ///Checking that user have selected any duration time or not
                if (cmbDuration.SelectedItem == null)
                {
                    MessageBox.Show("Please Select a Duration");
                    return;
                }
                string duration = cmbDuration.SelectedItem.ToString();
                string purpose = rtxtPurpose.Text;

                ///Checking that nofield must be empty
                ///
                if (string.IsNullOrEmpty(address) || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(province) || string.IsNullOrEmpty(purpose))
                {
                    MessageBox.Show("One or More fields are empty");
                    return;
                }

                if (appointment <= DateTime.Now)
                {
                    MessageBox.Show("Please select a time in future");
                    return;
                }

                ///creating instance 
                Appointment appointment1 = new Appointment(patientName, nBirth, address, city, province, postalCode, phoneNumber, email, appointment, duration, purpose);

                ///calling bookappointment method
                if (_office.BookAppointment(appointment))
                {
                    return;
                }

                _office.AddAppointment(appointment1);
                MessageBox.Show("succesfully booked patient information");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void dtpAppointment_ValueChanged(object sender, EventArgs e)
        {


        }

        private void btnResetField_Click(object sender, EventArgs e)
        {
            try
            {
                txtPatientName.Text = "";
                txtAddress.Text = "";
                txtCity.Text = "";
                txtEmail.Text = "";
                txtPhoneNumber.Text = "";
                dtpAppointment.Value = DateTime.Now;
                dtpDateofBirth.Value = DateTime.Now;
                txtPostalCode.Text = "";
                txtprovince.Text = "";
                rtxtPurpose.Text = "";
                cmbDuration.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void btnPreField_Click(object sender, EventArgs e)
        {
            try
            {
                txtPatientName.Text = "Urpit Patel";
                txtAddress.Text = "565 Belmont Avenue";
                txtCity.Text = "Kitchener";
                txtEmail.Text = "Someone@gmail.com";
                txtPhoneNumber.Text = "7832345678";
                dtpAppointment.Value = new DateTime(2023, 5, 1, 12, 0, 0);
                dtpDateofBirth.Value = new DateTime(2002, 11, 20);
                txtPostalCode.Text = "N2M 5E7";
                txtprovince.Text = "ontario";
                rtxtPurpose.Text = "just testing...";
                cmbDuration.SelectedIndex = 2;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
    }
}
