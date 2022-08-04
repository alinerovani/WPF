using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Names.Commands;
using Names.DTO;
using Names.Model;
using Names.Queries;
using Names.Repository;
using Names.Helpers;

namespace Names
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            btnDelete.Visibility = Visibility.Hidden;
            btnUpdate.Visibility = Visibility.Hidden;
        }
        private void AddName()
        {
            var items = RetrieveListItems();

            try
            {
                var personCommand = new PersonCommand(new PersonCommandRepository(items));
                personCommand.SavePerson(new Model.Person
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    BirthDate = ConversorHelper.CDateTime(txtBirthDate.Text)
                });

                ClearControls();
                lstPeople.ItemsSource = items;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
        }

        private void UpdateName()
        {
            var items = RetrieveListItems();

            try
            {
                var personCommand = new PersonCommand(new PersonCommandRepository(items));
                personCommand.UpdatePerson(new Model.Person
                {
                    ID = lstPeople.SelectedIndex,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    BirthDate = ConversorHelper.CDateTime(txtBirthDate.Text)
                });

                ClearControls();
                lstPeople.ItemsSource = items;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
        }

        private void DeleteName()
        {
            var items = RetrieveListItems();
            try
            {
                var personCommand = new PersonCommand(new PersonCommandRepository(items));
                personCommand.DeletePerson(lstPeople.SelectedIndex);

                ClearControls();
                lstPeople.ItemsSource = items;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }
        } 

        private void lstPeople_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstPeople.SelectedItem == null)
                return;

            var person = (Person)lstPeople.SelectedItem;

            txtFirstName.Text = person.FirstName;
            txtLastName.Text = person.LastName;
            txtBirthDate.Text = person.BirthDate.ToString("dd/MM/yyyy");

            btnAdd.Visibility = Visibility.Hidden;
            btnDelete.Visibility = Visibility.Visible;
            btnUpdate.Visibility = Visibility.Visible;
        }

        private void QueryPeople()
        {
            var items = RetrieveListItems();

            PersonQuery personQuery = new PersonQuery(new PersonQueryRepository(items));
            var people = personQuery.GetAll();
            lstPeople.ItemsSource = people;
        }

        private void ClearControls()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtBirthDate.Clear();

            btnDelete.Visibility = Visibility.Hidden;
            btnUpdate.Visibility = Visibility.Hidden;
            btnAdd.Visibility = Visibility.Visible;
        }

        private List<Person> RetrieveListItems()
        {
            List<Person> items = new List<Person>();
            Person item = new Person();

            for (int i = 0; i < lstPeople.Items.Count; i++)
            {
                item = (Person)lstPeople.Items[i];
                item.ID = i;
                items.Add(item);
            }

            return items;
        }

        protected void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddName();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            UpdateName();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            DeleteName();
        }
    }
}
