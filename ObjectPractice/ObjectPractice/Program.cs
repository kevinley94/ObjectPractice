using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an instance of the course class
            Course course1 = new Course();
            Course course2 = new Course("SeedPaths", "A");

            course1.DisplayCourseInfo();
            course2.DisplayCourseInfo();
            Console.ReadKey();
        }
    }
    public class Course
    {
        //1. Define its properties
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        //creating a read only property
        private int _gradePoints;
        public int GradePoints
        {
            get { return _gradePoints; }
            //for a read only, just don't make a set
            //for a write only, just don't make a get
        }
        private string _letterGrade;
        public string LetterGrade
        {
            get { return _letterGrade; }
            set
            {
                _letterGrade = value.ToUpper();
                //also change the value
                //of the grade points
                switch (_letterGrade)
                {
                    case "A":
                        _gradePoints = 4;
                        break;
                    case "B":
                        _gradePoints = 3;
                        break;
                    case "C":
                        _gradePoints = 2;
                        break;
                    case "D":
                        _gradePoints = 1;
                        break;
                    default:
                        _gradePoints = 0;
                        break;
                }
            }
        }

        //2. Constructors
        public Course()
        {
            //Parameter list constructor
            this.Name = "Undefined";
            this.LetterGrade = "F";

        }

        //overload
        public Course(string courseName, string letterGrade)
        {
            this.Name = courseName;
            this.LetterGrade = letterGrade;
            //step 3. Creating its methods
        }
            public void DisplayCourseInfo()
            {
                Console.WriteLine("{0}: {1}", this.Name, this.LetterGrade);
            }
        }
        

    }

