using Microsoft.VisualBasic;
using System.Collections.ObjectModel;
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
        // private List<Animals> animalsList = new List<Animals>();
        ObservableCollection<Animals> animalsList = new ObservableCollection<Animals>();

        public MainWindow()
        {
          

            InitializeComponent();
            AddAnimals();
        }

        private void AddAnimals()
        {
            animalsList.Add(new Dog("Buddy", "Dog", 5, "Kennel"));
            animalsList.Add(new Eagle("Eagle", "Eagle", 3, "Sky"));
            animalsList.Add(new Dolphin("Flipper", "Dolphin", 4, "Ocean")); 
            animalsList.Add(new Elephant("Dumbo", "Elephant", 10, "Savannah"));
          //  AnimalList.Items.Clear(); 
            AnimalList.ItemsSource = animalsList; 
           
        }

        private void AddAnimal_Click(object sender, RoutedEventArgs e)
        {
            string name = Interaction.InputBox("Bitte gib den Namen des Tieres ein:", "Tier hinzufügen", "Max");
            if (string.IsNullOrWhiteSpace(name)) return;

            string type = Interaction.InputBox("Bitte gib den Typ des Tieres ein (z. B. Dog, Eagle, Dolphin, Elephant):", "Tier hinzufügen", "Dog");
            if (string.IsNullOrWhiteSpace(type)) return;

            string ageInput = Interaction.InputBox("Bitte gib das Alter des Tieres ein:", "Tier hinzufügen", "2");
            if (!int.TryParse(ageInput, out int age))
            {
                MessageBox.Show("Ungültige Eingabe für Alter!");
                return;
            }

            string habitat = Interaction.InputBox("Bitte gib den Lebensraum des Tieres ein:", "Tier hinzufügen", "Kennel");
            if (string.IsNullOrWhiteSpace(habitat)) return;

            Animals newAnimal = CreateAnimal(name, type, age, habitat);
            animalsList.Add(newAnimal);

            MessageBox.Show($"{newAnimal.Name} wurde dem Zoo hinzugefügt!");
        }

        private Animals CreateAnimal(string name, string type, int age, string habitat)
        {
            switch (type.ToLower())
            {
                case "dog":
                    return new Dog(name, type, age, habitat);
                case "eagle":
                    return new Eagle(name, type, age, habitat);
                case "dolphin":
                    return new Dolphin(name, type, age, habitat);
                case "elephant":
                    return new Elephant(name, type, age, habitat);
                default:
                    MessageBox.Show($"Unbekannter Tier-Typ: {type}. Standardmäßig wird ein Hund erstellt.");
                    return new Dog(name, type, age, habitat);
            }
        }
    }
}