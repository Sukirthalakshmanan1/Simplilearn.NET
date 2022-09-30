using BL;
using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disconnected_assignment
{
    internal class Program
    {
        static int marks1;
        static void Main(string[] args)
        {
            Console.WriteLine("Institute Management System");
            Console.WriteLine("--------------------------------");
            CourseHelper helper = new CourseHelper();
            StudentHelper helper1 = new StudentHelper();
            ExamHelper helper2 = new ExamHelper();
            CourseBAL emp = new CourseBAL();
            Student_BAL emp1 = new Student_BAL();
            Exam_BAL emp2 = new Exam_BAL();
            char ch;
            do
            {
                Console.WriteLine("Enter ur choice:");
                Console.WriteLine("----------------------------");
                Console.WriteLine(" 1. Add New Course \n 2. Update Course \n 3. Find course \n 4. Show All the Course\n 5. Delete the course\n 6. course count \n 7. Add New Student \n 8. Update student \n 9. Find student\n 10. Show All the student \n 11. Delete student \n 12. student count \n 13. student write exam\n");
                int userchoice = Convert.ToInt32(Console.ReadLine());


                switch (userchoice)
                {
                    case 1:

                        Console.WriteLine("Enter coursename:");
                        emp.coursename = Console.ReadLine().Trim();

                        Console.WriteLine("Enter courseid:");
                        emp.courseid = Convert.ToInt32(Console.ReadLine().Trim());
                        Console.WriteLine("Enter deptid:");
                        emp.deptid = Console.ReadLine().Trim();
                        Console.WriteLine("enter duration:");
                        emp.duration = Convert.ToInt32(Console.ReadLine().Trim());

                        bool queryStatus = helper.AddNewcourse(emp);
                        if (queryStatus)
                        {
                            Console.WriteLine("Course added successfully.....");
                        }
                        else
                        {
                            Console.WriteLine("Some error occured...");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter original id:");
                        int empid = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter new course id:");
                        emp.courseid = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter course name:");
                        emp.coursename = Console.ReadLine().Trim();

                        Console.WriteLine("Enter deptid:");
                        emp.deptid = Console.ReadLine().Trim();
                        Console.WriteLine("Enter duration:");
                        emp.duration = Convert.ToInt32(Console.ReadLine().Trim());
                        queryStatus = helper.EditCourseData(empid, emp);
                        if (queryStatus)
                        {
                            Console.WriteLine("Course updated successfully.....");
                        }
                        else
                        {
                            Console.WriteLine("Some error occured...");
                        }

                        break;
                    case 3:
                        Console.WriteLine("Enter  course id:");
                        emp.courseid = Convert.ToInt32(Console.ReadLine());
                        CourseBAL data = helper.Locatecourse(emp.courseid);
                        if (data != null)
                        {
                            Console.WriteLine("Following are the details");
                            Console.WriteLine("Course ID:"+data.courseid);
                            Console.WriteLine("Course name:"+data.coursename);
                            Console.WriteLine("Dept id:"+data.deptid);
                            Console.WriteLine("Duration in hrs:"+data.duration);

                        }
                        else
                        {
                            Console.WriteLine("Invalid course id");
                        }
                        break;
                    case 4:
                        List<CourseBAL> emplist = new List<CourseBAL>();
                        emplist = helper.courseList();
                        Console.WriteLine("courseid" + " " + "coursename" + " " + "deptid" + " " + "duration");
                        foreach (var item in emplist)
                        {
                            Console.WriteLine(item.courseid + "  " + item.coursename + "  " + item.deptid + "  " + item.duration);
                            
                            Console.WriteLine();
                        }



                        break;
                    case 5:
                        Console.WriteLine("Enter  course id:");
                        emp.courseid = Convert.ToInt32(Console.ReadLine());
                        queryStatus = helper.RemovecourseData(emp.courseid);
                        if (queryStatus)
                        {
                            Console.WriteLine("Course Deleted successfully.....");
                        }
                        else
                        {
                            Console.WriteLine("Some error occured...");
                        }


                        break;
                    case 6:
                        int y = helper.RowCountcourse();
                        Console.WriteLine("rows count: " + y);
                        break;
                    case 7:
                        Console.WriteLine("Enter name of the student");
                        emp1.name = Console.ReadLine().Trim();

                        Console.WriteLine("Enter courseid");
                        emp1.crsid = Convert.ToInt32(Console.ReadLine().Trim());

                        Console.WriteLine("enter studentid");
                        emp1.stuid = Convert.ToInt32(Console.ReadLine().Trim());

                        bool queryStatus1 = helper1.AddNewStudent(emp1);
                        if (queryStatus1)
                        {
                            Console.WriteLine("student added successfully.....");
                        }
                        else
                        {
                            Console.WriteLine("Some error occured...");
                        }
                        break;
                    case 8:
                        Console.WriteLine("enter original student id");
                        int empid1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter name of the student");
                        emp1.name = Console.ReadLine().Trim();

                        Console.WriteLine("Enter courseid");
                        emp1.crsid = Convert.ToInt32(Console.ReadLine().Trim());

                        Console.WriteLine("enter studentid");
                        emp1.stuid = Convert.ToInt32(Console.ReadLine().Trim());
                        queryStatus1 = helper1.EditStudentData(empid1, emp1);
                        if (queryStatus1)
                        {
                            Console.WriteLine("student updated successfully.....");
                        }
                        else
                        {
                            Console.WriteLine("Some error occured...");
                        }
                        break;
                    case 9:
                        Console.WriteLine("enter  student id");
                        emp1.stuid = Convert.ToInt32(Console.ReadLine());
                        Student_BAL data1 = helper1.Locatestudent(emp1.stuid);
                        if (data1 != null)
                        {
                            Console.WriteLine("Following are the details");
                            Console.WriteLine(data1.stuid);
                            Console.WriteLine(data1.name);
                            Console.WriteLine(data1.crsid);


                        }
                        else
                        {
                            Console.WriteLine("Invalid student id");
                        }
                        break;
                    case 10:
                        List<Student_BAL> stdlist = new List<Student_BAL>();
                        stdlist = helper1.SList();
                        Console.WriteLine("studentid" + "      " + "nameof the student" + "                  " + "courseid");
                        foreach (var item in stdlist)
                        {
                            Console.WriteLine(item.stuid + "                 " + item.name + "                        " + item.crsid);

                            Console.WriteLine();
                        }

                        break;
                    case 11:
                        Console.WriteLine("enter  student id");
                        emp1.stuid = Convert.ToInt32(Console.ReadLine());
                        queryStatus1 = helper1.RemoveStudentData(emp1.stuid);
                        if (queryStatus1)
                        {
                            Console.WriteLine("student Deleted successfully.....");
                        }
                        else
                        {
                            Console.WriteLine("Some error occured...");
                        }
                        break;
                    case 12:
                        int y1 = helper1.RowCountStudent();
                        Console.WriteLine("student rows count: " + y1);
                        break;
                    case 13:
                        Console.WriteLine("Enter examid of the student");
                        emp2.examid = Convert.ToInt32(Console.ReadLine().Trim());

                        Console.WriteLine("Enter courseid of the student");
                        emp2.crsid = Convert.ToInt32(Console.ReadLine().Trim());

                        Console.WriteLine("enter studentid");
                        emp2.studid = Convert.ToInt32(Console.ReadLine().Trim());
                        Program.marks1 = 0;
                        for (int i = 1; i <= 10; i++)
                        {
                            Console.WriteLine("enter mark for question" + " " + i);
                            int m1 = Convert.ToInt32(Console.ReadLine().Trim());

                            if (m1 >= 55)
                            {
                                Program.marks1++;
                            }
                        }

                        emp2.marks = Program.marks1;
                        queryStatus1 = helper2.AddNewExam(emp2);
                        if (queryStatus1)
                        {
                            Console.WriteLine("marks added successfully.....");
                        }
                        else
                        {
                            Console.WriteLine("Some error occured...");
                        }
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Do u want to continue press y or Y !!");
                ch = Convert.ToChar(Console.ReadLine());

            } while (ch == 'y'||ch=='Y');
            Console.ReadKey();

        }
    }
}
