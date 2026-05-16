using StudentBinding.Models;
namespace StudentBinding
{
    public partial class MainPage : ContentPage
    {
        private Students calmStudent;
        private Students angryStudent;
        private Students currentStudent;
        public Students CurrentStudent
        {
            get => currentStudent;
            set
            {
                if (currentStudent != value)
                {
                    currentStudent = value;
                    OnPropertyChanged(nameof(CurrentStudent));
                }
            }
        }
        public MainPage()
        {
            InitializeComponent();
            calmStudent = new Students(age: 17, name: "Manny Sprinkler", email: "mannyS@gmail.com", telephone: "0543119876", houseInHogwarts: "Ravenclaw", is_on_screen: true, date: new DateTime(2019, 08, 02) , image: "daniel.png");
            angryStudent = new Students(age: 17, name: "Nevo Ofek", email: "OfekNevo@gmail.com", telephone: "098765432", houseInHogwarts: "Grifindor", is_on_screen: false, date: new DateTime(2004, 04, 18), image: "noa.png");
            currentStudent = calmStudent;
            BindingContext = CurrentStudent;

        }

        private void change_student_Clicked(object sender, EventArgs e)
        {
            if (CurrentStudent == calmStudent)
            {
                CurrentStudent = angryStudent;
            }
            else
            {
                CurrentStudent = calmStudent;
            }
            BindingContext = CurrentStudent;

        }
        
    }
}
