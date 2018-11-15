using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_1_4_lab
{
    class Program
    {

        // 1) declare enum ComputerType
        enum ComputerType
        {
            Desktop,
            Notebook
        }

        // 2) declare struct Computer
        struct Computer
        {
            public ComputerType computerType;
            public int ram;
            public int hdd;
            public float cpu;

            public void RamRand()
            {
                Random rand = new Random((int)DateTime.Now.Ticks);
                int counter = rand.Next(3);
                if (counter == 0)
                {
                    ram = 4;
                }
                if (counter == 1)
                {
                    ram = 8;
                }
                if (counter == 2)
                {
                    ram = 16;
                }
            }

            public void ComputerTypeRand()
            {
                Random rand = new Random((int)DateTime.Now.Ticks);
                int counter = rand.Next(100);
                if (counter % 2 == 0)
                {
                    computerType = ComputerType.Notebook;
                }
                else 
                {
                    computerType = ComputerType.Desktop;
                }
            }

            public void HddRand()
            {
                Random rand = new Random((int)DateTime.Now.Ticks);
                int counter = rand.Next(100);
                if (counter % 2 == 0)
                {
                    hdd = 500;
                }
                else
                {
                    hdd = 1000;
                }
            }

            public void CpuRand()
            {
                Random rand = new Random((int)DateTime.Now.Ticks);
                int counter = rand.Next(3);
                if (counter == 0)
                {
                    cpu = 1.6f;
                }
                if (counter == 1)
                {
                    cpu = 2.5f;
                }
                if (counter == 2)
                {
                    cpu = 3.1f;
                }
            }


        }
        


        static void Main(string[] args)
        {
            // 3) declare jagged array of computers size 4 (4 departments)
            Computer[][] computers = new Computer[4][];



            // 4) set the size of every array in jagged array (number of computers)
            computers[0] = new Computer[2];
            computers[1] = new Computer[4];
            computers[2] = new Computer[3];
            computers[3] = new Computer[2];

            // 5) initialize array
            // Note: use loops and if-else statements

            for (int i = 0; i < computers.Length; i++)
            {
                for (int j = 0; j < computers[i].Length; j++)
                {
                    computers[i][j].ComputerTypeRand();
                    computers[i][j].RamRand();
                    computers[i][j].CpuRand();
                    computers[i][j].HddRand();
                    Console.WriteLine($"computertype = {computers[i][j].computerType}, ram = {computers[i][j].ram}, cpu = {computers[i][j].cpu}, hdd = {computers[i][j].hdd}");
                }

            }


            // 6) count total number of every type of computers

            int desktopCount = 0;
            int notebokCount = 0;
            int computersCount = 0;
            for (int i = 0; i < computers.Length; i++)
            {
                for (int j = 0; j < computers[i].Length; j++)
                {
                    if (computers[i][j].computerType == ComputerType.Notebook)
                    {
                        
                        notebokCount++;
                    }
                    else
                    {
                        desktopCount++;
                    }
                    computersCount++;
                }

            }
            Console.WriteLine($"Count Notebooks = {notebokCount}, Desktops = {desktopCount}");
            

            // 7) count total number of all computers
            // Note: use loops and if-else statements
            // Note: use the same loop for 6) and 7)
            Console.WriteLine($"Total computers count =  {computersCount}");
            


            // 8) find computer with the largest storage (HDD) - 
            // compare HHD of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements

            int maxHddValue = 0;
            int maxHddI = 0;
            int maxHddJ = 0;
            for (int i = 0; i < computers.Length; i++)
            {
                for (int j = 0; j < computers[i].Length; j++)
                {
                    if (computers[i][j].hdd >= maxHddValue)
                    {

                        maxHddValue = computers[i][j].hdd;
                        maxHddI = i;
                        maxHddJ = j;
                    }
                }
            }
            Console.WriteLine($"computer with the largest storage =  {maxHddI} {maxHddJ}");


            // 9) find computer with the lowest productivity (CPU and memory) - 
            // compare CPU and memory of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            // Note: use logical oerators in statement conditions

            float minCpuValue = computers[0][0].cpu;
            int minRamValue = computers[0][0].ram;
            int minProductivityPcI = 0;
            int minProductivityPcJ = 0;
            for (int i = 0; i < computers.Length; i++)
            {
                for (int j = 0; j < computers[i].Length; j++)
                {
                    if (computers[i][j].cpu <  minCpuValue && computers[i][j].ram < minRamValue )
                    {

                        minCpuValue = computers[i][j].cpu;
                        minRamValue = computers[i][j].ram;
                        minProductivityPcI = i;
                        minProductivityPcJ = j;
                    }
                }
            }
            Console.WriteLine($"computer with the lowest productivity =  {minProductivityPcI} {minProductivityPcJ}");

            // 10) make desktop upgrade: change memory up to 8
            // change value of memory to 8 for every desktop. Don't do it for other computers
            // Note: use loops and if-else statements

            
            for (int i = 0; i < computers.Length; i++)
            {
                for (int j = 0; j < computers[i].Length; j++)
                {
                    if (computers[i][j].computerType == ComputerType.Desktop && computers[i][j].ram < 8)
                    {

                        computers[i][j].ram = 8;
                    }
                    Console.WriteLine($"computertype = {computers[i][j].computerType}, ram = {computers[i][j].ram}, cpu = {computers[i][j].cpu}, hdd = {computers[i][j].hdd}");
                }
            }
            Console.ReadLine();
        }
 
    }
}
