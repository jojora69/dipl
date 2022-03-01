using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomSemivan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["DB"].ConnectionString);
            MySqlDataAdapter tg = new MySqlDataAdapter("select groups_students.Group_name as Группы, specialty.Specialty_name as Специальность from groups_students join specialty on groups_students.id_specialty = specialty.idSpecialty", conn);
            MySqlDataAdapter tl = new MySqlDataAdapter("select number_lesson.name_lesson as Предметы from lesson join number_lesson on lesson.id_number_lesson = number_lesson.idNumber_lesson", conn);

            DataSet dataSet0 = new DataSet();
            DataSet dataSet1 = new DataSet();


            tg.Fill(dataSet0);
            tl.Fill(dataSet1);


            data_groups.DataSource = dataSet0.Tables[0];
            data_less.DataSource = dataSet1.Tables[0];

        }
    }
}
