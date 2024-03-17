using System;

namespace Lab_Report_SadhanaKhadka
 {
        public interface college
        {
            void Affileted();
            void FacultyMember();
        }
        public abstract class HimalayanCOllege : college
        {
            public void Affileted()
            {
                Console.WriteLine("Himalayan College is affileted by purbanchal University");
            }
            public abstract void FacultyMember();
        }
        public class ApexCollege : college
        {
            public void Affileted()
            {
                Console.WriteLine("Apex College is affileted by Tribhuban University");
            }
            public void FacultyMember()
            {
                Console.WriteLine("Apex College consists Humanities and Management faculty members ");
            }
        }

        class InterfaceDemo
        {
            static void Main(string[] args)
            {
                college c1;
                c1 = new ApexCollege();
                c1.Affileted();
                c1.FacultyMember();
                Console.WriteLine("\n Lab NO :7'b'");
                Console.WriteLine(" Name : Sadhana Khadka");
                Console.WriteLine(" Roll No:20");
        }

        }
}
