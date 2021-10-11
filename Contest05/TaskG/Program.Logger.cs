    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Program
    {
        public static bool ParseCommandsCount(string input, out int count)
        {
            return (int.TryParse(input, out count) && count > 0);
            throw new NotImplementedException();
        }

        public class Logger
        {
            string[] logs;
            private static Logger logger = new Logger();
            List<string> a = new List<string>();

            public static Logger GetLogger(int n)
            {

                logger.logs[n] = Console.ReadLine();
                return logger;
            }
            public static void HandleCommand(string command)
            {

                if (command[0] == 'A')
                {
                    int t = 0;
                    int h = 0;

                    int y = 0;
                    foreach (char i in command)
                    {
                        if (i == '<')
                        {
                            t = y;
                        }
                        if (i == '>')
                        {
                            h = y;
                        }
                        y++;
                    }
                
                    char[] g = new char[h - 1 - t];
                    int e = 0;
                    for (int i = t + 1; i < h; i++)
                    {
                        g[e] = command[i];
                        e++;
                    }
                    string o = String.Concat(g);
                    logger.a.Add(o);
                }
                if (command[0] == 'D')  
                {
                    if (logger.a.ToArray().Length != 0) 
                    {
                        logger.a.Remove(logger.a.Last());
                    
                    }
                    else
                    {
                        File.AppendAllText("logs.log", "No active logs"+Environment.NewLine);
                    }
                
                }
                if (command[0] == 'W')
                {
                    if (logger.a.ToArray().Length!=0)
                    {
                        File.AppendAllLines("logs.log", logger.a);
                        logger.a.Clear();
                    }
                    else
                    {
                        File.AppendAllText("logs.log", "No active logs"+Environment.NewLine);
                    }
                }
            }

        }
    }

