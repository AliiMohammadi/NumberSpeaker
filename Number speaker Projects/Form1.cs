using OneeChanRemake.Operation_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_speaker_Projects
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            SayNumberchekbox.CheckState = CheckState.Checked;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Execute();
        }
        private void numberTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
                Execute();


            return base.ProcessCmdKey(ref msg, keyData);
        }

        void Execute()
        {
            Execute(numberTXT.Text);
        }
        void Execute(string InputText)
        {
            try
            {
                if (string.IsNullOrEmpty(InputText))
                    return;

                int input = int.Parse(InputText);

                if (input > 9999 || input < 0)
                {
                    MessageBox.Show("عدد در محدوده گفتاری نیست!");
                    return;
                }

                numberTXT.Clear();

                speakBTN.Enabled = false;

                SayWordBeforNumber();

                SaySequence(Translator.Translate(input));

                speakBTN.Enabled = true;
            }
            catch (Exception r)
            {
                MessageBox.Show("Error:" + r.Message);
                numberTXT.Clear();
            }
        }

        void SaySequence(List<string> list)
        {
            foreach (var item in list)
            {
                int dur = Speaker.WavFileDuratio(item);
                Speaker.Speak(item);
                Thread.Sleep(dur);
            }
        }
        void SayWordBeforNumber()
        {
            if (SayNumberchekbox.CheckState == CheckState.Checked)
            {
                Speaker.Speak("number");
                Thread.Sleep(1400);
            }
        }

        private void InfoBTN_Click(object sender, EventArgs e)
        {
            string help = "نرم افزار شماره صدازن مناسب برای صدا زدن عدد فاکتور مشتری در رستوران ها.\n\r طراح اپلیکیشن اقای علی محمدی \n\r فستفودی چیکسو \n\r ادرس ایمیل \n\r alimohammady0921@gmail.com";
            MessageBox.Show(help);
        }
    }
}
