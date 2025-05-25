using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOPZooWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Animals> animalsList = new List<Animals>();

        public MainWindow()
        {
           
            AddAnimals();

            InitializeComponent();
        }

        private void AddAnimals()
        {
            animalsList.Add(new Dog("Buddy", "Dog", 5, "Kennel"));
            animalsList.Add(new Eagle("Eagle", "Eagle", 3, "Sky")); // Example of adding an Eagle
            animalsList.Add(new Dolphin("Flipper", "Dolphin", 4, "Ocean")); // Example of adding a Dolphin
            animalsList.Add(new Elephant("Dumbo", "Elephant", 10, "Savannah")); // Example of adding an Elephant
        }
        private void ViewAnimals_Click(object sender, RoutedEventArgs e)
        {
            // Example of how to use the animalsList
            foreach (var animal in animalsList)
            {
                animal.MakeSound();
                animal.Sleep();
                animal.Feed();
                animal.Play();
                Console.WriteLine(animal.Description);
            }
        }
        private void AddAnimal_Click(object sender, RoutedEventArgs e)
        {
            // Example of how to add a new animal
            var newAnimal = new Dog("Max", "Dog", 2, "Kennel");
            animalsList.Add(newAnimal);
            MessageBox.Show($"{newAnimal.Name} has been added to the zoo!");
        }
    }
}