using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab202
{
    class Course
    {
        private string name;
        private string courseID;
        private string lecturer;
        private int maxStudents;
        private int numStudents;

        public Course()
        {
            name = "Patraporn";
            courseID = "Stat";
            numStudents = 0;
            lecturer = "staff";
            maxStudents = 30;
        }
      
        public Course(string name, string courseID)
        {
            this.name = name;
            this.courseID = courseID;
            lecturer = "staff";
            maxStudents = 30;
            numStudents = 0;
        }
        public Course(string name, string courseID, string lecturer)
        {
            this.name = name;
            this.courseID = courseID;
            this.lecturer = lecturer;
            maxStudents = 30;
            numStudents = 0;
        }
        public Course(string name, string courseID, string lecturer, int MaxStudent)
        {
            this.name = name;
            this.courseID = courseID;
            this.lecturer = lecturer;
            this.MaxStudents = MaxStudents;
            numStudents = 0;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string CourseID
        {
            get
            {
                return courseID;
            }
            set
            {
                if (value.Length > 6)
                {
                    Console.WriteLine("{0}: error try setting invalid CourseID!", courseID);
                }
                else
                {
                    if (value.Length == 6)
                    {
                        int y = 0;
                        for (int x = 0; x < 6; x++)
                        {
                            if (char.IsDigit(value[x]))
                            {
                                y = y + 1;
                            }
                        }
                        if (y == 6)
                        {
                            courseID = value;
                        }
                        else
                        {
                            Console.WriteLine("{0}: error try setting invalid CourseID!", courseID);
                        }
                    }
                    else
                    {
                        Console.WriteLine("{0}: error try setting invalid CourseID!", courseID);
                    }             

                }
            }
        }

        public string Lecturer
        {
            get
            {
                return lecturer;
            }
            set
            {
                lecturer = value;
            }
        }

        public int MaxStudents
        {
            get
            {
                return maxStudents;
            }
            set
            {
                int a = maxStudents;
                maxStudents = value;

                if ( maxStudents < numStudents)
                {
                    Console.WriteLine(courseID + ": error try setting invalid Max No. Students!");
                }
            }
        }
        public int NumStudents
        {
            get
            {
                return numStudents;
            }
            set
            {
                int temp = numStudents;
                numStudents = value;

                if ( (numStudents > MaxStudents) || (numStudents < 0) )
                {
                    Console.WriteLine(courseID + ": error try setting invalid No. Students!!");
                    numStudents = temp;
                }
            }
        }

        public override string ToString()
        {
            return "[Course: " + name + " (" + courseID + "), Lecturer=" + lecturer + ", has = " + numStudents + " students, max=" + MaxStudents + "]";
        }
    }
}

