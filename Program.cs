// See https://aka.ms/new-console-template for more information
using malawi_digital_health_passport;

Console.WriteLine("Hello, World!");
User user = new User("Darlingson","admin1","123456789","dmakuwila");
Console.WriteLine("name :" +  user.Name);
//create a patient
Patient patient = new Patient();
patient.setPatientName = "Darlingson";
