using System;


    class Student
    {
        private static int counter = 0;
        private int id;
        private string fullName;
        private DateTime enrollDate;
        private string highEdIns;
        private string faculty;
        private string department;
        private string formOfEd;

        public int Id { get => id; set => id = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public DateTime EnrollDate { get => enrollDate; set => enrollDate = value; }
        public string HEI { get => highEdIns; set => highEdIns = value; }
        public string Faculty { get => faculty; set => faculty = value; }
        public string Department { get => department; set => department = value; }
        public string FormOfEd { get => formOfEd; set => formOfEd = value; }
        public static int Counter { get => counter; set => counter = value; }

        public Student() 
        {
            counter++;
        }
        public Student(int id)
        {
            this.id = id;
            counter++;
        }
        public Student(int id, string fullName)
        {
            this.id = id;
            this.fullName = fullName;
            counter++;
        }
        public Student(int id, string fullName, DateTime birthDate, string hEF, string faculty, string department, string formOfEd) : this(id, fullName)
        {
            this.enrollDate = birthDate;
            highEdIns = hEF ?? throw new ArgumentNullException(nameof(hEF));
            this.faculty = faculty ?? throw new ArgumentNullException(nameof(faculty));
            this.department = department ?? throw new ArgumentNullException(nameof(department));
            this.formOfEd = formOfEd ?? throw new ArgumentNullException(nameof(formOfEd));
        }
        public override string ToString()
        {
            return id + ", " + fullName + ", " + enrollDate + ", " + highEdIns + ", " + faculty + ", " + department + ", " + formOfEd;
        }
    }
