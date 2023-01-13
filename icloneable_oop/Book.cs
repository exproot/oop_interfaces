using System;

namespace icloneable_oop {
    public class Book : ICloneable{
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }

        public object Clone() {

            //deep copy
            /* 
            return new Book() {
                Id = this.Id,
                Title = this.Title,
                Price = this.Price
            };*/

            return this.MemberwiseClone(); //shallow copy

        }
    }
}
