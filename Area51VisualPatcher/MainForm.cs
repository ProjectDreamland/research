using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area51VisualPatcher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            aspectRatioBox.Items.Add(new Item("4:3", "92 0A 86 3F"));
            aspectRatioBox.Items.Add(new Item("16:9", "12 8F A4 3F"));
            aspectRatioBox.Items.Add(new Item("16:10", "14 A0 99 3F"));
            aspectRatioBox.Items.Add(new Item("21:9", "15 F6 C8 3F"));

            aspectRatioBox.SelectedIndex = 1;
        }

        /// <summary>
        /// Copy data from a file to an other, replacing search term, ignoring case.
        /// </summary>
        /// <param name="originalFile"></param>
        /// <param name="outputFile"></param>
        /// <param name="searchTerm"></param>
        /// <param name="replaceTerm"></param>
        private static void ReplaceTextInBinaryFile(string originalFile, string outputFile, string searchTerm,
            string replaceTerm)
        {
            byte b;
            //UpperCase bytes to search
            byte[] searchBytes = Encoding.UTF8.GetBytes(searchTerm.ToUpper());
            //LowerCase bytes to search
            byte[] searchBytesLower = Encoding.UTF8.GetBytes(searchTerm.ToLower());
            //Temporary bytes during found loop
            byte[] bytesToAdd = new byte[searchBytes.Length];
            //Search length
            int searchBytesLength = searchBytes.Length;
            //First Upper char
            byte searchByte0 = searchBytes[0];
            //First Lower char
            byte searchByte0Lower = searchBytesLower[0];
            //Replace with bytes
            byte[] replaceBytes = Encoding.UTF8.GetBytes(replaceTerm);
            int counter = 0;
            using (FileStream inputStream = File.OpenRead(originalFile))
            {
                //input length
                long srcLength = inputStream.Length;
                using (BinaryReader inputReader = new BinaryReader(inputStream))
                {
                    using (FileStream outputStream = File.OpenWrite(outputFile))
                    {
                        using (BinaryWriter outputWriter = new BinaryWriter(outputStream))
                        {
                            for (int nSrc = 0; nSrc < srcLength; ++nSrc)
                                //first byte
                                if ((b = inputReader.ReadByte()) == searchByte0
                                    || b == searchByte0Lower)
                                {
                                    bytesToAdd[0] = b;
                                    int nSearch = 1;
                                    //next bytes
                                    for (; nSearch < searchBytesLength; ++nSearch)
                                        //get byte, save it and test
                                        if ((b = bytesToAdd[nSearch] = inputReader.ReadByte()) != searchBytes[nSearch]
                                            && b != searchBytesLower[nSearch])
                                        {
                                            break; //fail
                                        }
                                    //Avoid overflow. No need, in my case, because no chance to see searchTerm at the end.
                                    //else if (nSrc + nSearch >= srcLength)
                                    //    break;

                                    if (nSearch == searchBytesLength)
                                    {
                                        //success
                                        ++counter;
                                        outputWriter.Write(replaceBytes);
                                        nSrc += nSearch - 1;
                                    }
                                    else
                                    {
                                        //failed, add saved bytes
                                        outputWriter.Write(bytesToAdd, 0, nSearch + 1);
                                        nSrc += nSearch;
                                    }
                                }
                                else
                                    outputWriter.Write(b);
                        }
                    }
                }
            }
            Console.WriteLine("ReplaceTextInBinaryFile.counter = " + counter);
        }


        private void patchButton_Click(object sender, EventArgs e)
        {
            area51FileDialog.FileName = "a51.exe";
            area51FileDialog.Filter = "Area 51 Game|a51.exe";
            DialogResult result = area51FileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var gamePath = area51FileDialog.FileName;
                try
                {
                    using (var fs = new FileStream(gamePath,
                        FileMode.Open,
                        FileAccess.ReadWrite))
                    {
                        fs.Position = 0x338C20;
                        fs.WriteByte(Convert.ToByte(0x0));
                        fs.WriteByte(Convert.ToByte(0x0));
                        fs.WriteByte(Convert.ToByte(0x0));
                        fs.WriteByte(Convert.ToByte(0x0));
                        fs.WriteByte(Convert.ToByte(0x0));
                        fs.WriteByte(Convert.ToByte(0x0));
                        fs.WriteByte(Convert.ToByte(0x24));
                        fs.WriteByte(Convert.ToByte(0x40));
                        var desiredAspectRatio = ((Item) aspectRatioBox.SelectedItem).Value.Split(' ');
                        foreach (var byteValue in desiredAspectRatio)
                        {
                            fs.WriteByte(Convert.ToByte(byteValue, 16));
                        }
                    }


                    ReplaceTextInBinaryFile(gamePath, gamePath + "-patched", "gamespy.com", "openspy.net");

                    if (System.IO.File.Exists(gamePath))
                    {
                        try
                        {
                            System.IO.File.Delete(gamePath);
                            System.IO.File.Move(gamePath + "-patched", gamePath);
                            multiplayerLabel.Text = "Game Patched: True";
                        }
                        catch (System.IO.IOException ex)
                        {
                            multiplayerLabel.Text = "Game Patched: False";
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                catch (Exception exception)
                {
                    multiplayerLabel.Text = "Game Patched: False";
                    MessageBox.Show(exception.Message, "Error");
                }
            }

            else
            {
                multiplayerLabel.Text = "Game Patched: False";
                MessageBox.Show("Please select the game!");
            }
        }

        private void twitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/andrewmd5");
        }

        private void githubToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Codeusa/Area51Patcher");
        }
    }

    class Item
    {
        public string Name;
        public string Value;

        public Item(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public override string ToString()
        {
            // Generates the text shown in the combo box
            return Name;
        }
    }
}