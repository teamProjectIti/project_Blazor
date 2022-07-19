using System.Collections.Generic;

namespace projectBlazor.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
