using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DJIKPA_Daniel_Elie_TP2_ST2TRD
{
    public partial class FormTP2 : Form
    {
        public FormTP2()
        {
            InitializeComponent();
        }

        // Hide key when we select Binary Encryption
        private void comboBoxChooseEncryptionMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxChooseEncryptionMode.SelectedItem.ToString() == "Binary")
                panelKey.Hide();
            else
                panelKey.Show();
        }

        // Manage textBoxKey
        private void textBoxKey_Enter(object sender, EventArgs e)
        {
            if (textBoxKey.Text == "Enter Your Key")
            {
                textBoxKey.Clear();
                textBoxKey.ForeColor = Color.Black;
            }
        }

        private void textBoxKey_Leave(object sender, EventArgs e)
        {
            if (textBoxKey.Text == "")
            {
                textBoxKey.Text = "Enter Your Key";
                textBoxKey.ForeColor = Color.Silver;
            }
        }

        // Manage textBoxEncryption
        private void textBoxEncryption_Enter(object sender, EventArgs e)
        {
            if (textBoxEncryption.Text == "Text to Encrypt")
            {
                textBoxEncryption.Clear();
                textBoxEncryption.ForeColor = Color.Black;
            }
        }

        private void textBoxEncryption_Leave(object sender, EventArgs e)
        {
            if (textBoxEncryption.Text == "")
            {
                textBoxEncryption.Text = "Text to Encrypt";
                textBoxEncryption.ForeColor = Color.Silver;
            }
        }

        // Manage textBoxDecryption
        private void textBoxDecryption_Enter(object sender, EventArgs e)
        {
            if (textBoxDecryption.Text == "Text Decrypted")
            {
                textBoxDecryption.Clear();
                textBoxDecryption.ForeColor = Color.Black;
            }
        }

        private void textBoxDecryption_Leave(object sender, EventArgs e)
        {
            if (textBoxDecryption.Text == "")
            {
                textBoxDecryption.Text = "Text Decrypted";
                textBoxDecryption.ForeColor = Color.Silver;
            }
        }

        //             BINARY
        public static string StringToBinary(string data)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in data.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
                sb.Append(' ');
            }
            return sb.ToString();
        }

        public static string BinaryToString(string str)
        {
            String data = Regex.Replace(str, " ", string.Empty);
            List<Byte> byteList = new List<Byte>();

            for (int i = 0; i < data.Length; i += 8)
            {
                byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
            }
            return Encoding.ASCII.GetString(byteList.ToArray());
        }

        //             CAESAR
        public static char cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {

                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);


        }

        public static string Encipher(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += cipher(ch, key);

            return output;
        }

        public static string Decipher(string input, int key)
        {
            return Encipher(input, 26 - key);
        }

        //              VIGNERE
        public static String generateKey(String str, String key)
        {
            int x = str.Length;

            for (int i = 0; ; i++)
            {
                if (x == i)
                    i = 0;
                if (key.Length == str.Length)
                    break;
                key += (key[i]);

            }
            return key;
        }

        // This function returns the encrypted text
        // generated with the help of the key
        public static String cipherText(String text, String key)
        {
            String cipher_text = "";
            String str = text.ToUpper();

            for (int i = 0; i < str.Length; i++)
            {
                // converting in range 0-25
                int x = (str[i] + key[i]) % 26;

                // convert into alphabets(ASCII)
                if (str[i] == ' ')
                {
                    x = ' ';
                }
                else
                    x += 'A';

                cipher_text += (char)(x);
            }

            string cast = "";
            for (int i = 0; i < cipher_text.Length; i++)
            {
                if (text[i] >= 'a' && text[i] != ' ')
                {
                    int x = cipher_text[i] + 32;
                    cast += (char)x;
                }
                else
                {
                    cast += cipher_text[i];
                }
            }

            return cast;
        }

        // This function decrypts the encrypted text
        // and returns the original text
        public static String originalText(String text, String key)
        {
            String orig_text = "";
            String cipher_text = text.ToUpper();

            for (int i = 0; i < cipher_text.Length && i < key.Length; i++)
            {
                // converting in range 0-25
                int x = (cipher_text[i] - key[i] + 26) % 26;

                // convert into alphabets(ASCII)

                if (cipher_text[i] == ' ')
                {
                    x = ' ';
                }
                else
                    x += 'A';
                orig_text += (char)(x);
            }

            string cast = "";
            for (int i = 0; i < orig_text.Length; i++)
            {
                if (text[i] >= 'a' && text[i] != ' ')
                {
                    int x = orig_text[i] + 32;

                    cast += (char)x;

                }
                else
                {
                    cast += orig_text[i];
                }
            }

            return cast;
        }



        private void buttonEncryption_Click(object sender, EventArgs e)
        {
            if (textBoxEncryption.Text != null)
            {
                if(comboBoxChooseEncryptionMode.SelectedItem != null )
                {
                    textBoxDecryption.ForeColor = Color.Orange;
                    if (comboBoxChooseEncryptionMode.SelectedItem.ToString() == "Binary")
                    {
                        try
                        {
                            textBoxDecryption.Text = StringToBinary(textBoxEncryption.Text);
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        
                    }
                    else if (comboBoxChooseEncryptionMode.SelectedItem.ToString() == "Caesar")
                    {
                        try
                        {
                            int key = Convert.ToInt32(int.Parse(textBoxKey.Text));
                            textBoxDecryption.Text = Encipher(textBoxEncryption.Text, key);
                        }
                        catch (FormatException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                    else if (comboBoxChooseEncryptionMode.SelectedItem.ToString() == "Vignere")
                    {
                        if(textBoxKey.Text != null)
                        {
                            try
                            {
                                String key = generateKey(textBoxEncryption.Text, textBoxKey.Text);
                                String cipher_text = cipherText(textBoxEncryption.Text, key);
                                textBoxDecryption.Text = cipher_text;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                            MessageBox.Show("invalid key !");

                    }
                }
                else
                   MessageBox.Show("Empty Encryption Mode !");

            }
            else
            {
                MessageBox.Show("empty field !");
            }
        }

        private void buttonDecryption_Click(object sender, EventArgs e)
        {
            if (textBoxEncryption.Text != null)
            {
                if (comboBoxChooseEncryptionMode.SelectedItem != null)
                {
                    if (comboBoxChooseEncryptionMode.SelectedItem.ToString() == "Binary")
                    {
                        try
                        {
                            textBoxDecryption.Text = BinaryToString(textBoxEncryption.Text);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else if (comboBoxChooseEncryptionMode.SelectedItem.ToString() == "Caesar")
                    {
                        if (textBoxKey.Text != null)
                        {
                            int key = Convert.ToInt32(int.Parse(textBoxKey.Text));
                            textBoxDecryption.Text = Decipher(textBoxEncryption.Text, key);
                        }
                        else
                        {
                            MessageBox.Show("empty key !");
                        }

                    }
                    else if (comboBoxChooseEncryptionMode.SelectedItem.ToString() == "Vignere")
                    {
                        if (textBoxKey.Text != null)
                        {
                            String key = generateKey(textBoxEncryption.Text, textBoxKey.Text);
                            textBoxDecryption.Text = originalText(textBoxEncryption.Text, key);
                        }
                        else
                        {
                            MessageBox.Show("error format key !");
                        }

                    }
                }
                else
                    MessageBox.Show("Empty Encryption Mode!");
              
            }
            else
            {
                MessageBox.Show("empty field !");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxEncryption.Text = "";
            textBoxDecryption.Text = "";
        }

        private void buttonArrowDecryptToEncrypt_Click(object sender, EventArgs e)
        {
            textBoxEncryption.Text = textBoxDecryption.Text;
        }

        private void buttonArrowEncryptToDecrypt_Click(object sender, EventArgs e)
        {
            textBoxDecryption.Text = textBoxEncryption.Text;
        }
    }
}
