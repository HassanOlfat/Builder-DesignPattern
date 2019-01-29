namespace Builder
{
   public  class StudentBuilder
   {
       private Student student;

        public StudentBuilder(int SudentID)
        {
            student = new Student(SudentID);
        }

        public StudentBuilder Setname(string name)
        {
            student.Name = name;
            return this;
        }
        public StudentBuilder Setfamiy(string family)
        {
            student.Family = family;
            return this;
        }
        public StudentBuilder Setage(string age)
        {
            student.Age = age;
            return this;
        }
        public StudentBuilder Setphone(string phone)
        {
            student.Phone = phone;
            return this;
        }
        public StudentBuilder Setmobileame(string mobile)
        {
            student.Mobile = mobile;
            return this;
        }

        public Student build()
        {
            return student;
        }
    }
}
