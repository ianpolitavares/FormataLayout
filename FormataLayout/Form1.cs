using System.Drawing;
using System.Windows.Forms;

namespace FormataLayout
{
    public partial class Form1 : Form
    {
        string[] nomes = { "cdbancli", "agencia", "conta", "dac" };
        int[] layout = { 5, 4, 5, 1 };

        public Form1()
        {
            InitializeComponent();

            InitializeFields();

        }

        private void InitializeFields()
        {
            foreach (string nome in nomes)
            {
                dataGridView1.Rows.Add(nome, "");
            }

            foreach (int i in layout)
            {
                txtLayout.AppendText(i.ToString());
                txtLayout.AppendText(Environment.NewLine);
            }
        }

        private void LoadDataIntoDataGridView()
        {
            // Limpa o DataGridView
            dataGridView1.Rows.Clear();

            // Obtém a string do TextBox txtString
            string inputString = txtString.Text;

            int currentPosition = 0;

            // Itera sobre o layout para dividir a string de entrada
            for (int i = 0; i < layout.Length; i++)
            {
                int length = layout[i];
                string valor = string.Empty;

                if (currentPosition + length <= inputString.Length)
                {
                    valor = inputString.Substring(currentPosition, length);
                    currentPosition += length;
                }
                else if (currentPosition < inputString.Length)
                {
                    valor = inputString.Substring(currentPosition);
                    currentPosition = inputString.Length;
                }

                if (i < nomes.Length)
                {
                    dataGridView1.Rows.Add(nomes[i], valor);
                }
                else
                {
                    dataGridView1.Rows.Add("", valor);
                }
            }
        }

        private void btn_processa_Click(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }
    }
}