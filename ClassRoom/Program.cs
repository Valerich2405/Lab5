using System;
using System.Collections.Generic;

namespace ClassRoom
{
    public class ClassRoom
    {
        public readonly List<Pupil> Pupils = new List<Pupil>();

        public ClassRoom(params Pupil[] pupils)
        {
            Pupils.AddRange(pupils);
        }

        public void GetPupilsRead()
        {
            foreach (var pupil in Pupils)
            {
                pupil.Read();
            }
        }

        public void GetPupilsWrite()
        {
            foreach (var pupil in Pupils)
            {
                pupil.Write();
            }
        }
        public void GetPupilsStudy()
        {
            foreach (var pupil in Pupils)
            {
                pupil.Study();
            }
        }
        public void GetPupilsRelax()
        {
            foreach (var pupil in Pupils)
            {
                pupil.Relax();
            }
        }
    }

    public class Pupil
    {
        public string PupilName { get; set; }

        public Pupil(string name)
        {
            PupilName = name;
        }

        private string GetPupilNameAndStatus()
        {
            return String.Format("{0}", PupilName);
        }

        public virtual void Read()
        {
            Console.WriteLine("{0} {1}", GetPupilNameAndStatus(), "Reading is normal");
        }

        public virtual void Write()
        {
            Console.WriteLine("{0} {1}", GetPupilNameAndStatus(), "Writing is normal");
        }

        public virtual void Study()
        {
            Console.WriteLine("{0} {1}", GetPupilNameAndStatus(), "Studying is normal");
        }

        public virtual void Relax()
        {
            Console.WriteLine("{0} {1}", GetPupilNameAndStatus(), "Relaxing is good");
        }       
    }

    public class ExellentPupil : Pupil
    {
        public ExellentPupil(string name) : base(name)
        { }
        public override void Read()
        {
            Console.WriteLine("{0} Reading is excellent", PupilName);
        }
        public override void Write()
        {
            Console.WriteLine("{0} Writing is excellent", PupilName);
        }
        public override void Study()
        {
            Console.WriteLine("{0} Studying is excellent", PupilName);
        }
        public override void Relax()
        {
            Console.WriteLine("{0} Relaxing  is bad", PupilName);
        }
    }

    public class GoodPupil : Pupil
    {
        public GoodPupil(string name) : base(name)
        { }
        public override void Read()
        {
            Console.WriteLine("{0} Reading is good", PupilName);
        }
        public override void Write()
        {
            Console.WriteLine("{0} Writing is good", PupilName);
        }
        public override void Study()
        {
            Console.WriteLine("{0} Studying is good", PupilName);
        }
        public override void Relax()
        {
            Console.WriteLine("{0} Relaxing  is normal", PupilName);
        }
    }

    public class BadPupil : Pupil
    {
        public BadPupil(string name) : base(name)
        { }
        public override void Read()
        {
            Console.WriteLine("{0} Reading is bad", PupilName);
        }
        public override void Write()
        {
            Console.WriteLine("{0} Writing is bad", PupilName);
        }
        public override void Study()
        {
            Console.WriteLine("{0} Studying is bad", PupilName);
        }
        public override void Relax()
        {
            Console.WriteLine("{0} Relaxing  is excellent", PupilName);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pupil tom = new Pupil("Tom");
            Pupil alex = new BadPupil("Alex");
            Pupil jack = new GoodPupil("Jack ");
            Pupil adam = new ExellentPupil("Adam");

            var firstClassRoom = new ClassRoom(tom);
            var secondClassRoom = new ClassRoom(tom, alex);
            var thirdClassRomm = new ClassRoom(tom, alex, jack);
            var forthClassRomm = new ClassRoom(tom, alex, jack, adam);

            Console.WriteLine("Class Room:");
            Console.WriteLine();

            Console.WriteLine("Reading:");
            forthClassRomm.GetPupilsRead();
            Console.WriteLine();

            Console.WriteLine("Writing:");
            forthClassRomm.GetPupilsWrite();
            Console.WriteLine();

            Console.WriteLine("Studying:");
            forthClassRomm.GetPupilsStudy();
            Console.WriteLine();

            Console.WriteLine("Relaxing:");
            forthClassRomm.GetPupilsRelax();

            Console.ReadLine();
        }
    }
}
