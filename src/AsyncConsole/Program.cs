﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncConsole
{
    // https://blogs.msdn.microsoft.com/pfxteam/2012/01/20/await-synchronizationcontext-and-console-apps/
    public class Program
    {
        private static async Task Main(string[] args)
        {
            //await DemoAsync();
            AsyncPump.Run(async delegate
            {
                await DemoAsync();
            });
        }

        private static async Task DemoAsync()
        {
            var dictionary = new Dictionary<int, int>();

            for (var i = 0; i < 10000; i++)
            {
                var id = Thread.CurrentThread.ManagedThreadId;
                dictionary[id] = dictionary.TryGetValue(id, out var count) ? count + 1 : 1;
                await Task.Yield();
            }

            foreach (var pair in dictionary) Console.WriteLine(pair);
            Console.ReadKey();
        }
    }
}