using ConferenceManagement.Client;
using ConferenceManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConferenceManagement.View.AuthorView
{
    public partial class AddAbstract : Form
    {
        private AuthorForm parentFormAuthor;
        private ClientController ctrl;

        public AddAbstract()
        {
            InitializeComponent();
        }

        public void initializeAuthorComponents()
        {
            comboBox_section.DataSource = getAllSectionName(); 
        }

        public AuthorForm ParentFormAuthor
        {
            get
            {
                return parentFormAuthor;
            }

            set
            {
                parentFormAuthor = value;
            }
        }

        public ClientController Ctrl
        {
            get
            {
                return ctrl;
            }

            set
            {
                ctrl = value;
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();

            parentFormAuthor.Show();
        }

        //returns a list with all sections name which will be set to combobox
        private List<String> getAllSectionName()
        {
            List<Section> sections = ctrl.getAllSections();
            List<String> sectionsName = new List<String>();
            foreach(Section section in sections)
            {
                sectionsName.Add(section.SectionName);
            }
            return sectionsName;
        }
    }
}
