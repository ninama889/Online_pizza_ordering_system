using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AdminControl
{
    [DataContract]
    public class Category
    {
        int id;
        string name;
        string img;
        bool active;
        DateTime created;

        [DataMember]
        public int CategoryId
        {
            get { return id; }
            set { id = value; }
        }
        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [DataMember]
        public string ImageUrl
        {
            get { return img; }
            set { img = value; }
        }
        [DataMember]
        public bool IsActive
        {
            get { return active; }
            set { active = value; }
        } 
        [DataMember]
        public DateTime CreatedDate
        {
            get { return created; }
            set { created = value; }
        }
    }
}
