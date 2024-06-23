//////Generic - Template

////class Program
////{
////    public interface IDemo
////    {
////        void Run();
////    }
////    struct Teacher
////    {

////        public int Id { get; set; }
////        public string Name { get; set; }
////        public Teacher(int id, string name)
////        {
////            Id = id;
////            Name = name;
////        }
////    }

////    class Student:IDemo
////    {

////        public int Id { get; set; }
////        public string Name { get; set; }

////        public Student()
////        {

////        }
////        public Student(int id, string name)
////        {
////            Id = id;
////            Name = name;
////        }

////        public void Run()
////        {
////            throw new NotImplementedException();
////        }
////    }

////    static class Demo
////    {
////        //public static void Foo<Typename>(Typename typename)where Typename : class
////        //{
////        //    Console.WriteLine(typename);
////        //}
////        //public static void Foo<Typename>(Typename typename) where Typename : struct
////        //{
////        //    Console.WriteLine(typename);
////        //}
////        public static void Foo<Typename>(Typename typename) where Typename : IDemo
////        {
////            Console.WriteLine(typename);
////        }
////        //public static void Boo<Typename1, Typename2>(Typename1 t1, Typename2 t2)
////        //{
////        //    Console.WriteLine(Convert.ToSingle(t1) + Convert.ToInt32(t2));
////        //}
////    }


////    static void Main(string[] args)
////    {
////        //Demo.Foo<float>(5.4f);
////        //Demo.Foo<int>(5);
////        //Demo.Boo<float, int>(4.5f, 6);

////        Student student = new(1, "Nazim");
////        //var student1 = new Student(2, "Fazil");
////        //Student student3 = new Student(3, "Razim");
////        Teacher teacher = new Teacher(2, "Fazil");


////        Demo.Foo<Student>(student);

////    }

////}





////class Progmram
////{

////class Demo<Typename>
////{
////    public Typename Id { get; set; }

////}
////static void Main(string[] args)
////{
////    Demo<int> demo = new Demo<int>();
////    demo.Id = 1;

////}

////}




//class Program
//{
//    class Car
//    {


//        public string Model { get; set; }
//        public string Vendor { get; set; }
//        public string Color { get; set; }
//        public Car(string model, string vendor, string color)
//        {
//            Model = model;
//            Vendor = vendor;
//            Color = color;
//        }
//        public override string ToString()
//        => $"Model:{Model}\nVendor{Vendor}\nColor:{Color}";
//    };



//    static void Main(string[] args)
//    {
//        Dictionary<string, object> Dyp = new Dictionary<string, object>();
//        Car car1 = new Car("Vaz", "2107", "Black");
//        Car car2 = new Car("Vaz", "2106", "Ag");
//        Car car3 = new Car("Lada", "Priora", "Black");

//        Dyp.Add("90-NA-147", car1);
//        Dyp.Add("99-GO-999", car2);
//        Dyp.Add("99-DL-802", car3);

//        foreach (var item in Dyp)
//        {
//            Console.WriteLine(item);
//        }


//    }




//}





using System.Collections;

class Program
{
    //Generic collection  List<> Dictionary<>  - verilen tipe gore deyerleri value
    //type type ve ya refernce type kimi saglayacagini evvelceden bilir ve hansina uygundursa
    //ona uygun olaraq saxlayir
    //Non-generic collection  Array  ArrayList - datalari reference type kimi saxliyirlar
    //Boxing Unboxing
    //Boxing - value type in reference type cevrilmesidir
    //Unboxing ise reference type in value type a cevrilmesidir

    static void Main(string[] args)
    {
        List<int> list = new List<int>() { 1, 2, 3, 4, 5 };

        foreach (int i in list)
        {
            Console.WriteLine(i);
        }

        ArrayList arrayList = new ArrayList();
        arrayList.Add(1);//Boxing
        arrayList.Add(2);//Boxing
        arrayList.Add(3);//Boxing

        Console.WriteLine(arrayList[1]);//Unboxing
    }
}
