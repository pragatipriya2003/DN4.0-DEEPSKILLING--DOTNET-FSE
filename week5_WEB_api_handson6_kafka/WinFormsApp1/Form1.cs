using Confluent.Kafka;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly IProducer<Null, string> _producer;

        public Form1()
        {
            InitializeComponent();

            // Kafka producer configuration
            var config = new ProducerConfig
            {
                BootstrapServers = "localhost:9092"
            };

            _producer = new ProducerBuilder<Null, string>(config).Build();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text.Trim();
            if (string.IsNullOrWhiteSpace(message)) return;

            try
            {
                // Send message to Kafka topic
                await _producer.ProduceAsync("chat-topic", new Message<Null, string> { Value = message });

                // Display it in chat window
                txtChat.AppendText($"You: {message}\r\n");
                txtMessage.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending message: {ex.Message}");
            }
        }
    }
}
