using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AdminControl
{
    [DataContract]
    public class Product
    {
        int id;
        string name;
        string description;
        decimal price;
        int quantity;
        string img;
        int categoryId;
        bool active;
        DateTime created;

        [DataMember]
        public int ProductId
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
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        [DataMember]
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        [DataMember]
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        [DataMember]
        public string ImageUrl
        {
            get { return img; }
            set { img = value; }
        }
        [DataMember]
        public int CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
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
