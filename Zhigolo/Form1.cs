using System;
using TeleSharp.TL;
using TLSharp.Core;
using System.Threading;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Zhigolo
{
    public partial class Form1 : Form
    {
        StreamReader reader;
        Random rnd = new Random();
        TimeSpan milli;
        public Form1()
        {
            InitializeComponent();
        }

        TelegramClient zhigalo;
        string fullPathToDat;


        string hash;

        private async void connect_Click(object sender, EventArgs e)
        {
            try
            {
                var store = new FileSessionStore();
                if (File.Exists(Directory.GetCurrentDirectory() + @"\session.dat"))
                {
                    fullPathToDat = Directory.GetCurrentDirectory() + @"\session";
                    try
                    {
                        zhigalo = new TelegramClient(int.Parse(apiId.Text), hashId.Text, store, fullPathToDat);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("API_ID or HASH_ID are incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    try
                    {
                        zhigalo = new TelegramClient(int.Parse(apiId.Text), hashId.Text, store);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("API_ID or HASH_ID are incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                MessageBox.Show("Connected!", "Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connect.Enabled = false;

                label3.Enabled = true;
                phone.Enabled = true;
                auth.Enabled = true;
                

                await zhigalo.ConnectAsync();
            }
            catch (TLSharp.Core.Network.Exceptions.FloodException floodException)
            {
                Thread.Sleep(floodException.TimeToWait);
            }
        }

        private async void auth_Click(object sender, EventArgs e)
        {
            try
            {
                bool authorized = zhigalo.IsUserAuthorized();
                if (!authorized)
                {
                    try
                    {
                        hash = await zhigalo.SendCodeRequestAsync(phone.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Phone is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    label4.Enabled = true;
                    code.Enabled = true;
                    start.Enabled = true;
                }
                else
                {
                    MessageBox.Show("You are now logged in!", "Zhigan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    start.Enabled = false;

                    complActive.Enabled = true;
                    label5.Enabled = true;
                    chooseCompl.Enabled = true;
                    label6.Enabled = true;
                    milliBox.Enabled = true;
                    contactsBt.Enabled = true;
                    label7.Enabled = true;
                    userBox.Enabled = true;
                    code.Enabled = true;
                }
            }
            catch (TLSharp.Core.Network.Exceptions.FloodException floodException)
            {
                Thread.Sleep(floodException.TimeToWait);
            }
        }

        private async void start_Click(object sender, EventArgs e)
        {
            try
            {
                var user = await zhigalo.MakeAuthAsync(phone.Text, hash, code.Text);
            }
            catch (TLSharp.Core.Network.Exceptions.FloodException floodException)
            {
                Thread.Sleep(floodException.TimeToWait);
            }
            Properties.Settings.Default.HASH_ID = hashId.Text;
            Properties.Settings.Default.API_ID = apiId.Text;
            Properties.Settings.Default.Phone = phone.Text;
            Properties.Settings.Default.Code = code.Text;
            Properties.Settings.Default.Save();

            start.Enabled = false;
            complActive.Enabled = true;
            label5.Enabled = true;
            chooseCompl.Enabled = true;
            label6.Enabled = true;
            milliBox.Enabled = true;
            contactsBt.Enabled = true;
            label7.Enabled = true;
            userBox.Enabled = true;
        }

        private async void contactsBt_Click(object sender, EventArgs e)
        {
            try
            {
                if (complimentsBox.Text != "")
                {
                    if (usernameChoice.Checked)
                    {
                        await Task.Run(() => SendComplimentsUsername());
                    }
                    else
                    {
                        await Task.Run(() => SendComplimentsPhone());
                    }
                }
                else
                {
                    MessageBox.Show("Compliments are not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (TLSharp.Core.Network.Exceptions.FloodException floodException)
            {
                Thread.Sleep(floodException.TimeToWait);
            }
        }

        private async Task SendComplimentsUsername()
        {
            try
            {
                try
                {
                    milli = TimeSpan.FromSeconds(int.Parse(milliBox.Text));
                }
                catch (Exception ex)
                {
                    milli = TimeSpan.FromSeconds(10);
                }
                string contact = userBox.Text;
                var result = await zhigalo.SearchUserAsync(contact);
                var user = result.Users
                    .Where(x => x.GetType() == typeof(TLUser))
                    .OfType<TLUser>()
                    .FirstOrDefault(x => x.Username == contact.TrimStart('@'));

                if (user == null)
                {
                    var contacts = await zhigalo.GetContactsAsync();

                    user = contacts.Users
                        .Where(x => x.GetType() == typeof(TLUser))
                        .OfType<TLUser>()
                        .FirstOrDefault(x => x.Username == contact.TrimStart('@'));
                }

                if (user == null)
                {
                    throw new Exception("Username was not found: " + contact);
                }
                await zhigalo.SendTypingAsync(new TLInputPeerUser() { UserId = user.Id, AccessHash = user.AccessHash.Value });
                string compliment = Get_Compliment();
                await zhigalo.SendMessageAsync(new TLInputPeerUser() { UserId = user.Id, AccessHash = user.AccessHash.Value }, compliment);
                Thread.Sleep(milli);
                SendComplimentsUsername();
            }
            catch (TLSharp.Core.Network.Exceptions.FloodException floodException)
            {
                Thread.Sleep(floodException.TimeToWait);
                milli = floodException.TimeToWait;
                SendComplimentsUsername();
            }
        }
        private async Task SendComplimentsPhone()
        {
            try
            {
                milli = TimeSpan.FromSeconds(int.Parse(milliBox.Text));
                string phone = userBox.Text;
                var result = await zhigalo.GetContactsAsync();
                var user = result.Users
                .OfType<TLUser>()
                .FirstOrDefault(x => x.Phone == phone);


                if (user == null)
                {
                    throw new Exception("Number was not found in Contacts List of user: " + phone);
                }

                await zhigalo.SendTypingAsync(new TLInputPeerUser() { UserId = user.Id, AccessHash = user.AccessHash.Value });
                string compliment = Get_Compliment();
                Thread.Sleep(milli);
                await zhigalo.SendMessageAsync(new TLInputPeerUser() { UserId = user.Id, AccessHash = user.AccessHash.Value }, compliment);
                SendComplimentsPhone();
            }
            catch (TLSharp.Core.Network.Exceptions.FloodException floodException)
            {
                Thread.Sleep(floodException.TimeToWait);
                milli = floodException.TimeToWait;
                SendComplimentsPhone();
            }
        }
        private string Get_Compliment()
        {
            string compliments = "";
            complimentsBox.Invoke(new Action(() => compliments = complimentsBox.Lines[rnd.Next(0, complimentsBox.Lines.Count() - 1)]));
            return compliments;
        }
        private void chooseCompl_Click(object sender, EventArgs e)
        {
            complActive.Checked = true;

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                reader = new StreamReader(dialog.FileName);
                complimentsBox.Text = reader.ReadToEnd();
            }
        }

        private void usernameChoice_Click(object sender, EventArgs e)
        {
            label7.Text = "Username";
            phoneChoice.Checked = false;
            usernameChoice.Checked = true;
        }

        private void phoneChoice_Click(object sender, EventArgs e)
        {
            label7.Text = "Phone Contact";
            phoneChoice.Checked = true;
            usernameChoice.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.API_ID != "")
            {
                apiId.Text = Properties.Settings.Default.API_ID;
            }
            if (Properties.Settings.Default.HASH_ID != "")
            {
                hashId.Text = Properties.Settings.Default.HASH_ID;
            }
            if (Properties.Settings.Default.Phone != "")
            {
                phone.Text = Properties.Settings.Default.Phone;
            }
            if (Properties.Settings.Default.Code != "")
            {
                code.Text = Properties.Settings.Default.Code;
            }
        }
    }
}