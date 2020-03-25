using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ManualDataBinding.Data;

namespace ManualDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Create the note to add to our editor
        /// </summary>
        Note note = new Note();

        public MainWindow()
        {
            InitializeComponent();
            Editor.Note = note;
        }

        /// <summary>
        /// Creates a new note and applies it to the editor
        /// </summary>
        /// <param name="sender"> The button clicked </param>
        /// <param name="e"> The event args </param>
        public void OnNewNote(object sender, RoutedEventArgs e)
        {
            note = new Note();
            Editor.Note = note;
        }

        /// <summary>
        /// Event handler to clear the contents of the note
        /// </summary>
        /// <param name="sender"> The button clicked </param>
        /// <param name="e"> The event args </param>
        public void OnClearNote(object sender, RoutedEventArgs e)
        {
            note.Body = "";
        }

        /// <summary>
        /// Event handler to mutate the current note
        /// </summary>
        /// <param name="sender"> The button clicked </param>
        /// <param name="e"> The event args </param>
        public void OnMutateNote(object sender, RoutedEventArgs e)
        {
            note.Title = "An Ode to Coronavirus";
            note.Body = "But this won't make us fall, there is still one man we can call...                  Danny Devito";
        }
    }
}
