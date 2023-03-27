using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab7_1
{
    public partial class FileManipulator : Form
    {
        // Declaring the structures and variables to be used on files
        FileStream fileStream;
        FileStream binaryStream;
        StreamWriter textOut;
        StreamReader textIn;
        BinaryWriter binaryOut;
        BinaryReader binaryIn;
        DateTime date;
        string path = @".\Files\lab7_1.txt"; // Can be changed later if you need to change
        string pathBinary = @".\Files\Blab7_1.txt";
        string firstName;
        string lastName;
        string textToPrint;
        // the path
        public FileManipulator()
        {
            InitializeComponent();
        }

        private void FileManipulator_Load(object sender, EventArgs e)
        {
            textFName.Text = "Bonnie";
            textLName.Text = "Nunes";
            textFName.Focus();
        }

        private void writeTextFile_Click(object sender, EventArgs e)
        {
            // Working with FileStream, StreamWriter, and Binary
            try
            {
                fileStream = new FileStream(path, FileMode.Append, FileAccess.Write);
                textOut = new StreamWriter(fileStream);
                date = DateTime.Now;

                textOut.WriteLine(textFName.Text + " | " + textLName.Text 
                    + " | " + date.ToString("F"));
                binaryOut.Write(textFName.Text);
                binaryOut.Write(textLName.Text);

                textOut.Close();
                binaryOut.Close();

                MessageBox.Show("The data was successful writen into the file " +
                    path + ".");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(fileStream + " not found.", "File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(path + " not found.", "Directory Not Found");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "IOException");
            }
            finally
            {
                if (fileStream != null) fileStream.Close();
            }
        }

        private void readTextFile_Click(object sender, EventArgs e)
        {
            textIn = new StreamReader(path);
            textToPrint = "First Name | Last Name\n\n";

            int counter = 0;
            
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split('|');
                textToPrint += columns[0] + " | " + columns[1] + "\n";

                counter++;

                if (counter == 3 )
                {
                    MessageBox.Show(textToPrint);
                    counter = 0;
                    textToPrint = "First Name | Last Name\n\n";
                }
            }
            if (counter != 0)
            {
                MessageBox.Show(textToPrint);
                counter = 0;
                textToPrint = "First Name | Last Name\n\n";
            }
            textIn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            binaryStream = new FileStream(pathBinary, FileMode.Append, FileAccess.Write);
            binaryOut = new BinaryWriter(binaryStream);

            if (textFName.Text == "")
            {
                MessageBox.Show("First name must not be null.", "Error: Textbox Empty");
            }
            else
            {
                binaryOut.Write(textFName.Text.Trim());
            }
            if (textLName.Text == "")
            {
                MessageBox.Show("Last name must not be null.", "Error: Textbox Empty");
            }
            else
            {
                binaryOut.Write(textLName.Text.Trim());
            }
            try
            {
                binaryOut.Write(Convert.ToInt32(textAge.Text.Trim()));
                binaryOut.Close();
                binaryStream.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(pathBinary + " not found.", "File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(pathBinary + " not found.", "Directory Not Found");
            }
            catch (IOException ex)
            { 
                MessageBox.Show(ex.Message, "IOException"); 
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message +
                    ":\nAge must not be null.", "Error: Text Box Empty");
            }
            finally { 
                if (binaryStream != null) binaryStream.Close(); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            binaryStream = new FileStream(pathBinary, FileMode.OpenOrCreate, FileAccess.Read);
            binaryIn = new BinaryReader(binaryStream);
            string textToPrint = "FName\t LName\t Age\n";
            string LName, FName;
            int Age;

            int counter = 0;

            while (binaryIn.PeekChar() != -1)
            {
                FName = binaryIn.ReadString();
                LName = binaryIn.ReadString();
                Age = binaryIn.ReadInt32();
                try
                {
                    

                    textToPrint += FName + "\t" + LName + "\t" + Age + "\n";

                    counter++;

                    if (counter == 3)
                    {
                        MessageBox.Show(textToPrint);
                        counter = 0;
                        textToPrint = "FName\t LName\t Age\n";
                    }                    
                }
                catch(EndOfStreamException ex)
                {
                    MessageBox.Show("Something wrong with binary file.", "End of Stream");                  
                }
            }
            if (counter != 0)
            {
                MessageBox.Show(textToPrint);
                counter = 0;
            }
            binaryIn.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this application?",
                "Exit?", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }
    }
}
