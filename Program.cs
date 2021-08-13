using System;
//using System.Collections;
using System.Collections.Generic;

class ArrayListProgram
{
    static void Main(string[] args)
    {
        List<string> lst = new List<string>(100);
        lst.Add("S1");
        lst.Add("S2");
        lst.Add("S3");
        lst.Add("S4");
        lst.Add("S5");
        lst.AddRange(new string[] { "A1", "A2", "A3" });
        lst.Insert(2, "I1");
        lst.Remove("S4");
        lst.RemoveAt(4);
        lst.Sort();
        lst.Reverse();
        lst.TrimExcess();
        string str = lst[2];
        foreach (string s in lst)
            Console.WriteLine(s);
        Console.WriteLine(lst.Capacity + " " + lst.Count);
        string[] ar = lst.ToArray();
    }
}

class Employee //: IComparable<Employee>
{
    public int Id;
    public string Name;
    public override string ToString()
    {
        return Id + " " + Name;
    }
    //public int CompareTo(object obj)
    //{
    //    Employee other = (Employee)obj;
    //    if (this.Id < other.Id)
    //        return -1;
    //    else if (this.Id > other.Id)
    //        return 1;
    //    else
    //        return 0;
    //}

    public int CompareTo(Employee other)
    {
        if (this.Id < other.Id)
            return -1;
        else if (this.Id > other.Id)
            return 1;
        else
            return 0;
    }
}

class EmployeeComparer : IComparer<Employee>
{
    public int Compare(Employee x, Employee y)
    {
        //Employee first = (Employee)x;
        //Employee second = (Employee)y;
        return x.Id - y.Id;
    }
}

class EmployeeCollectionProgram
{
    static void Main(string[] args)
    {
        List<Employee> lstEmp = new List<Employee>();
        lstEmp.Add(new Employee() { Id = 5, Name = "E4" });
        lstEmp.Add(new Employee() { Id = 1, Name = "E1" });
        lstEmp.Add(new Employee() { Id = 4, Name = "E3" });
        lstEmp.Add(new Employee() { Id = 2, Name = "E2" });
        lstEmp.Add(new Employee() { Id = 3, Name = "E2" });

        EmployeeComparer ec = new EmployeeComparer();
        lstEmp.Sort(ec);
        //lstEmp.Sort();
       // lstEmp.Reverse();

        foreach (Employee emp in lstEmp)
        {
            Console.WriteLine(emp.ToString());
        }
        IEnumerable<Employee> enEmp = lstEmp;
        IEnumerator<Employee> en = enEmp.GetEnumerator();
        while (en.MoveNext())
        {
            Employee e = en.Current;
            Console.WriteLine(e);
        }
    }
}

class DictionaryProgram
{
    static void Main(string[] args)
    {
        //Hashtable ht = new Hashtable();
        Dictionary<int, string> dic = new Dictionary<int, string>();
        dic.Add(101, "S1");
        dic.Add(102, "S2");
        dic.Add(103, "S3");
        dic.Add(104, "S4");
        dic.Add(105, "S5");
        dic.Remove(103);
        string value1 = dic[102].ToString();
        Console.WriteLine(value1);
        foreach (KeyValuePair<int,string> de in dic)
        {
            int key = de.Key;
            string value = de.Value;
            Console.WriteLine(key + " " + value);
        }
    }
}

class SortedListProgram
{
    static void Main(string[] args)
    {
        SortedList<int, string> sl = new SortedList<int, string>();
        sl.Add(105, "S5");
        sl.Add(101, "S1");
        sl.Add(103, "S3");
        sl.Add(102, "S2");
        sl.Add(104, "S4");
        sl.Remove(103);
        string value1 = sl[102];
        Console.WriteLine(value1);
        foreach (KeyValuePair<int,string> de in sl)
        {
            int key = de.Key;
            string value = de.Value;
            Console.WriteLine(key + " " + value);
        }
        string v = (string)sl.Values[2];
       
    }
}