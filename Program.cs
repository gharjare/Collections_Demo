namespace CollectionsDemo
{
    class program
    {
        public static void Main(string[] args)
        {
            doListDemo();
            doStackDemo();
            doQueueDemo();
            doSetDemo();
            doDictionaryDemo();
        }
        private static void doListDemo()
        {
            Console.WriteLine("In doListDemo");

            List<string> list = new List<string>();
            list.Add("Ravi");
            list.Add("Vavi");
            list.Add("Chetan");
            list.Add("Ajay");

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }
        private static void doStackDemo()
        {
            Console.WriteLine("In doStackDemo");

            Stack<string> stack = new Stack<string>();
            stack.Push("Ayush");
            stack.Push("Ganvir");
            stack.Push("Amit");
            stack.Push("Ashish");
            stack.Push("Garima");
            string pop = stack.Pop();

            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Popped element is:" + pop);
        }
        private static void doQueueDemo()
        {
            Console.WriteLine("In doQueueDemo");

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Amit sharma");
            queue.Enqueue("Vijay raj");
            queue.Enqueue("jaishankar ");
            queue.Enqueue("raj");

            Console.WriteLine("Peek element is:" + queue.Peek());

            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
            string dequeue = queue.Dequeue();

            Console.WriteLine("After dequeue the elements are");


        }
        private static void doSetDemo()
        {
            Console.WriteLine("In doSetDemo");

            HashSet<string> set = new HashSet<string>();
            set.Add("Ravi");
            set.Add("Vijay");
            set.Add("Ravi");
            set.Add("Ajay");

            foreach (var element in set)
            {
                Console.WriteLine(element);
            }
        }
        private static void doDictionaryDemo()
        {
            Console.WriteLine("In doDictionaryDemo");

            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(100, "Amit");
            dictionary.Add(200, "Rahul");
            dictionary.Add(300, "Vijay");

            Console.WriteLine("Access the value using key(key=100)" + dictionary[100]);

            foreach (var element in dictionary)
            {
                Console.WriteLine("Key : " + element.Key + "Value :" + element.Value);
            }



        }
    }


}
