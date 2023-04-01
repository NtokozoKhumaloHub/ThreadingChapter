using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingChapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*--------------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("Hello World! 1");
            Thread.Sleep(1000);

            Console.WriteLine("Hello World! 2");
            Thread.Sleep(2000);

            Console.WriteLine("Hello World! 3");
            Thread.Sleep(3000);

            Console.WriteLine("Hello World! 4");
            Thread.Sleep(4000);
            */

            /*--------------------------------------------------------------------------------------------------------------------------------
            new Thread(() => 
            { 
                Thread.Sleep(8000);
                Console.WriteLine("Hello World! 4");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(6000);
                Console.WriteLine("Hello World! 3");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("Hello World! 2");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Hello World! 1");
            }).Start();
            */
            /*--------------------------------------------------------------------------------------------------------------------------------
            var taskCompletionSource = new TaskCompletionSource<bool>();


            var thread = new Thread(() =>
            {
                Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started");
                Thread.Sleep(1000);
                taskCompletionSource.SetResult(true);
                Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended");
            });
            Console.WriteLine($"Thread number: {thread.ManagedThreadId}");
            thread.Start();
            bool isCompleted = taskCompletionSource.Task.Result;
            Console.WriteLine($"Thread completed: {isCompleted}");

            */
            /*
            Enumerable.Range(18, 5).ToList().ForEach(x =>
            {
                new Thread(() =>
                {
                    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started");
                    Thread.Sleep(4000);
                    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended");
                }).Start();

            });
            */

            Enumerable.Range(0, 100).ToList().ForEach(x =>
            {
                ThreadPool.QueueUserWorkItem((o) => 
                {
                    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} started");
                    Thread.Sleep(4000);
                    Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId} ended");
                });

            });
            Console.ReadLine();

        }
    }
}
