using WinFormsApp2.Business.Concert;
using WinFormsApp2.Entities;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person person= new Person();
            person.FirstName = textBox1.Text;
            person.LastName = textBox2.Text;
            person.Adress = textBox4.Text;
            person.DateOfBirthYear =Convert.ToInt32(textBox3.Text);
            person.NationalIdentity = Convert.ToInt64(maskedTextBox1.Text);

            PersonManager personManager= new PersonManager();
           
            if (personManager.PersonControl(person))
            {
                if(personManager.MaskControl(person))
                {
                    
                    MessageBox.Show($"Say�n {person.FirstName} {person.LastName} maskeniz en yak�n zamanda {person.Adress} adl� adrese teslim edilecektir . Sa�l�kl� g�nler dileriz .");
                }

                else
                {
                  
                    MessageBox.Show("Daha �nce maske ald���n�z i�in size maalesef maske temin edememekteyiz :(");
                }
            }

            else
            {
                MessageBox.Show("Girmi� oldugunuz bilgilere uygun bir T.C. vatanda�� bulunamam��t�r. L�tfen tekrar deneyiniz...");
                
            }
        }
    }
}