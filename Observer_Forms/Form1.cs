namespace Observer_Forms
{
    public partial class Form1 : Form
    {
        float temperature, humidity;
        WeatherStation station;
        string name;
        int selecteDevice;
        public Form1()
        {
            InitializeComponent();

            station = new WeatherStation();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ParseValues();
        }

        void ParseValues()
        {
            try
            {
                temperature = float.Parse(txtTemp.Text);
                humidity = float.Parse(txtHum.Text);

                UpdateValues();
            }
            catch
            {
                MessageBox.Show("Jeden nebo více z inputù není èíslo.");
            }
        }
        void UpdateValues()
        {
            station.SetMeasurements(temperature, humidity);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            if (name.Length < 4)
            {
                MessageBox.Show("Jméno není dostateènì dlouhé");
                return;
            }

            station.AddObserver(new Device(name));
            lstDevices.Items.Add(name);

            txtName.Text = "";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                selecteDevice = lstDevices.SelectedIndex;

                station.RemoveObserver(selecteDevice);
                lstDevices.Items.RemoveAt(selecteDevice);
            }
            catch
            {
                MessageBox.Show("Není vybrán žádný prvek");
            }
        }
    }
}