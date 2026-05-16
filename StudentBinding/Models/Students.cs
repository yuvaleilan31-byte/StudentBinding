using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBinding.Models
{
    public class Students : ObservableObject
    {
        private int age;
        private string name;
        private string email;
        private string telephone;
        private string houseInHogwarts;
        private DateTime date;
        private string image;
        public bool is_on_screen { get; set; }

        public Students(int age, string name, string email, string telephone, string houseInHogwarts, bool is_on_screen, DateTime date, string image)
        {
            this.age = age;
            this.name = name;
            this.email = email;
            this.telephone = telephone;
            this.houseInHogwarts = houseInHogwarts;
            this.is_on_screen = is_on_screen;
            this.date = date;
            this.image = image;
        }

        public int Age {
            get { return age; }
            set
            {
                if (value != age && value > -1 && value < 180)
                {
                    age = value;
                    OnPropertyChanged("age");
                }
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value != name)
                {
                    name = value;
                    OnPropertyChanged("name");
                }
            }
        }
        public string Telephone
        {
            get { return telephone; }
            set
            {
                if (value != telephone)
                {
                    telephone = value;
                    OnPropertyChanged("telephone");
                }
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (value != email)
                {
                    email = value;
                    OnPropertyChanged("email");
                }
            }
        }
        
        public string HouseInHogwarts
        {
            get { return houseInHogwarts; }
            set
            {
                if (value != houseInHogwarts)
                {
                    houseInHogwarts = value;
                    OnPropertyChanged("houseInHogwarts");
                }
            }
        }
        public DateTime Date
        {
            get { return date; }
            set
            {
                if (value != date)
                {
                    date = value;
                    OnPropertyChanged("date");
                }
            }
        }
        public string Image
        {
            get { return image; }
            set
            {
                if (value != value)
                {
                    image = value;
                    OnPropertyChanged("image");
                }
            }
        }

        public void Is_on_screen(){
            is_on_screen = !this.is_on_screen;
        }

    }
}
