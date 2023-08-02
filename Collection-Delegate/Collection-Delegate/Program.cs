

using Collection_Delegate;
using System.Collections;

//ArrayList arrayList = new ArrayList();

//arrayList.Add(5);
//arrayList.Add("Salam");

//foreach(var item in arrayList)
//{
//    Console.WriteLine(item);
//}

//Hashtable hastable = new Hashtable();

//hastable.Add(1, "SAmir");
//hastable.Add(2, "Fidan");
//hastable.Add(3, "Kubra");

//foreach(DictionaryEntry item in hastable)
//{
//    Console.WriteLine(item.Key);
//}

//SortedList sortedList = new SortedList();

//sortedList.Add(5, "Salam5");
//sortedList.Add(3, "Salam3");
//sortedList.Add(1, "Salam1");

//foreach (DictionaryEntry item in sortedList)
//{
//    Console.WriteLine(item.Key);
//}


//SortedList sortedList2 = new SortedList();

//sortedList2.Add("Az", "Salam5");
//sortedList2.Add("Ca", "Salam3");
//sortedList2.Add("Ba", "Salam1");


//foreach (DictionaryEntry item in sortedList2)
//{
//    Console.WriteLine(item.Key);
//} 


//SortedList<int,string> genericSortList = new SortedList<int,string>();


//genericSortList.Add(1, "sd");
//genericSortList.Add(2, "ssdsdad");

//foreach (KeyValuePair<int,string> item in genericSortList)
//{
//    Console.WriteLine(item.Value);
//}


//Dictionary<int, int> dictionary = new Dictionary<int, int>();


//dictionary.Add(1, 2);
//dictionary.Add(2, 5);


//foreach (KeyValuePair <int, int> item in dictionary)
//{
//    Console.WriteLine(item.Value);
//}


//Dictionary<string, string> users = new Dictionary<string, string>();

//users.Add("admin", "Cahangir");
//users.Add("superAdmin", "Sheref");
//users.Add("member", "Pervin");


//foreach (KeyValuePair<string, string> item in users)
//{
//    if (item.Key == "admin")
//    Console.WriteLine(item.Key);
//}



//Stack<int> stack = new Stack<int>();

//stack.Push(1);
//stack.Push(10);
//stack.Push(4);

//foreach (var item in stack)
//{
//    Console.WriteLine(item);
//}



//Queue<int> queue = new Queue<int>();

//queue.Enqueue(1);
//queue.Enqueue(10);
//queue.Enqueue(4);

//foreach (var item in queue)
//{
//    Console.WriteLine(item);
//}



//List<int> nums = new List<int>();

//nums.Add(1);
//nums.Add(2);    
//nums.Add(3);    
//nums.Add(6);

//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}

//int[] arr = { 1, 2, 3 };

//var data = arr.ToList();

//var result =nums.ToArray();


//List<int> nums2 = new List<int>();

//nums.Add(1);
//nums.Add(2);
//nums.Add(3);
//nums.Add(88);

//nums.AddRange(nums2); 

//foreach (var item in nums)
//{
//    Console.WriteLine(item);
//}


//var result = nums.ToArray();

//Console.WriteLine(nums.Count);

//for (int i = 0; i < nums.Count; i++)
//{
//    Console.WriteLine(nums[i]);
//}

//nums.Remove(6);


//var result = nums.FirstOrDefault(m => m == 5);
//var result = nums.FindAll(m => m == 5);

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

//var result = nums.Exists(x => x == 1);

//Console.WriteLine(result);

//var result = nums.Find(m=>m.Equals(1));
//Console.WriteLine(result);

 
EmployeeController controller = new EmployeeController();

//controller.GetAll();

controller.FilterByPrice();