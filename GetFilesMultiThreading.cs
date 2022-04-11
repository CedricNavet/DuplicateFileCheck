using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DuplicateFileCheck
{
    public class GetFilesMultiThreading
    {

        public Mutex Mutex = new Mutex();
        public List<string> Files = new List<string>();

        public List<string> Start(string path)
        {
            var directories = GetDirectoires(@"\\?\"+path);
            SearchFiles(directories);
            Console.WriteLine("end");
            return Files;
        }

        private void SearchFiles(List<string> directories)
        {
            int maxDirByThread = directories.Count / 64;
            List<List<string>> directoriesSplit = new List<List<string>>();
            for (int i = 0; i < 64; i++)
            {
                directoriesSplit.Add(new List<string>());
            }
            int counterReached = 0;
            int counter = 0;
            foreach (var item in directories)
            {
                counter++;
                if (counter == maxDirByThread)
                {
                    counter = 0;
                    counterReached++;
                    if (counterReached >= 64)
                        directoriesSplit[63].Add(item);
                    else
                        directoriesSplit[counterReached].Add(item);
                }
                else
                {
                    if (counterReached >= 64)
                        directoriesSplit[63].Add(item);
                    else
                        directoriesSplit[counterReached].Add(item);
                }
            }

            List<Action> actions = new List<Action>();

            foreach (var directory in directoriesSplit)
            {
                var t = new Dir() { Directory = directory };
                actions.Add(() => SearchFileInDirectory(t));
            }
            SpawnAndWait(actions);
        }

        private void SearchFileInDirectory(object state)
        {

            try
            {
                Dir dir = (Dir)state;
                List<string> files = new List<string>();
                foreach (var item in dir.Directory)
                {
                    files.AddRange(Directory.GetFiles(item));
                }

                Mutex.WaitOne();
                Files.AddRange(files);
                Mutex.ReleaseMutex();
            }
            catch (UnauthorizedAccessException)
            {
                Mutex.ReleaseMutex();
                throw new UnauthorizedAccessException();
            }
            catch (Exception ex)
            {
                Mutex.ReleaseMutex();
                throw new Exception(ex.Message);
            }

        }

        class Dir
        {
            public List<string> Directory = new List<string>();
        }

        public List<string> GetDirectoires(string path)
        {
            List<string> directories = new List<string>();
            try
            {

                var collection = Directory.GetDirectories(path, "*");

                foreach (var item in collection)
                {
                    if (Directory.Exists(item))
                    {
                        directories.Add(item);
                        directories.AddRange(GetDirectoires(item));
                        
                    }

                }
                return directories;
            }
            catch (UnauthorizedAccessException)
            {

                throw new UnauthorizedAccessException();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }


        public static void SpawnAndWait(IEnumerable<Action> actions)
        {
            var list = actions.ToList();
            var handles = new ManualResetEvent[actions.Count()];
            for (var i = 0; i < list.Count; i++)
            {
                handles[i] = new ManualResetEvent(false);
                var currentAction = list[i];
                var currentHandle = handles[i];
                Action wrappedAction = () => { try { currentAction(); } finally { currentHandle.Set(); } };
                ThreadPool.QueueUserWorkItem(x => wrappedAction());
            }

            Mutex.WaitAll(handles);
        }
    }
}
