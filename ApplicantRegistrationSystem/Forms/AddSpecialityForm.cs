using ApplicantRegistrationSystem.DAL.Models;
using ApplicantRegistrationSystem.Repository.Implementation;
using ApplicantRegistrationSystem.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicantRegistrationSystem.Forms
{
    public partial class AddSpecialityForm : Form
    {
        private readonly ISpecialityRepository _specialityRepository;

        public AddSpecialityForm()
        {
            InitializeComponent();

            _specialityRepository = new SpecialityRepository();
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            var speciality = new Speciality
            {
                Name = textBoxName.Text
            };

            await _specialityRepository.AddAsync(speciality);
            MessageBox.Show("Специальность добавлена!");
            Close();
        }
    }
}
