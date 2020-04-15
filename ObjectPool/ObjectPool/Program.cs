using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace ObjectPool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
             
            
            for (int i = 0; i < 10; i++)
            {
                PoolManager.Instance.GetStudent();
            }
            Console.ReadKey();
        }
    }

    class PoolManager
    {

        private static readonly Object s_lock = new Object();
        private static PoolManager instance = null;

        private PoolManager()
        {
        }

        public static PoolManager Instance
        {
            get
            {
                if (instance != null) return instance;
                Monitor.Enter(s_lock);
                PoolManager temp = new PoolManager();
                Interlocked.Exchange(ref instance, temp);
                Monitor.Exit(s_lock);
                return instance;
            }
        }
        private static int _PoolMaxSize = 3;
        private static readonly Queue objPool = new Queue(_PoolMaxSize);
        private static readonly Queue waitingPool = new Queue();

        public async Task<Student> GetStudent(string from = null)
        {
            Student oStudent = new Student();
            if (objPool.Count < _PoolMaxSize )
            {
                objPool.Enqueue(oStudent);
                Console.WriteLine($"++Enqueued {from}");
                await Task.Delay(10000);
                objPool.Dequeue();
                Console.WriteLine($"--Dequeued {from}");
                CheckQueue(); //yer boşaltıldıktan sonra bekleyenlere haber veriyor
            }
            else
            {
                AddToWaitingQueue(oStudent);
            }
            return oStudent;
        }
        protected void AddToWaitingQueue(Student s)
        {
            Console.WriteLine("Added To Waiting List");
            waitingPool.Enqueue(s);
        }
        protected void CheckQueue()
        {
            if (objPool.Count< _PoolMaxSize)
            {
                // Retrieve from pool
                Console.WriteLine("CheckQueue");
                var s = waitingPool.Dequeue();
                GetStudent("from waiting list.");
            }
        }
    }
    class Student
    {
        public Student()
        {
        }
   
    }
}
