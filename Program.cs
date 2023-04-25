


using InterfaceDemo;




Student student = new Student();
student.Test();


Person1 person1;
person1 = student;
person1.Test();



Employee employee = new Employee();
//employee.Test();

InterfaceDemo1 InterfaceDemo1;
InterfaceDemo1 = employee;
InterfaceDemo1.Test();


InterfaceDemo2 InterfaceDemo2;
InterfaceDemo2 = employee;
InterfaceDemo2.Test();


Doctor doctor = new Doctor();
IDoctor iDoctor;
iDoctor = doctor;
iDoctor.GetData();
iDoctor.PutData();

