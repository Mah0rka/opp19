namespace opp19
{
    public partial class OOP19 : Form
    {

        string[] array;
        int counter = 0;
        public OOP19()
        {
            InitializeComponent();
            array = new string[0];

        }

        private void button1_Click(object sender, EventArgs e)//заповнення масиву
        {
            if (textBox1.Text == String.Empty)
                return;
            if (array.Length == counter)
                Array.Resize(ref array, (array.Length + 1));
            array[counter] = textBox1.Text;

            label_ans.Text += array[counter] + "; ";
            counter++;
        }

        private void button_sort_Click(object sender, EventArgs e)//Впорядкування його по зростанню кодів символів.
        {
            Array.Sort(array);
            label_ans.Text += "\n\nВідсортований масив:\n\n";
            for (int i = 0; i < array.Length; i++)
            {
                label_ans.Text += array[i] + "; ";
            }
        }
    }
}
