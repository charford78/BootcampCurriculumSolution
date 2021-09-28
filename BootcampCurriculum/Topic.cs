using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampCurriculum
{
    class Topic
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Difficulty { get; set; }
        private static int NextId { get; set; } = 1;

        
        public void Print()
        {
            Console.WriteLine($"{Id} | {Name} | {Category} | {Difficulty}");
        }

        public Topic()
        {
            this.Id = NextId++;
        }
    }
}
